using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO;

namespace Recognator
{
    public class RecognatorBrains: Emgu.Util.DisposableObject
    {
        //private Emgu.CV.OCR.Tesseract _ocr;
        private Tesseract.TesseractEngine _ocr;
        
        public RecognatorBrains()
        {

            //_ocr = new Emgu.CV.OCR.Tesseract("C:/Users/sedgu/Documents/emgucv-windesktop 3.2.0.2682/Emgu.CV.Example/LicensePlateRecognition/obj/Debug/tessdata", "eng", OcrEngineMode.TesseractOnly);
            InitOcr(Directory.GetCurrentDirectory()+"\\", "eng", Emgu.CV.OCR.OcrEngineMode.Default);
            _ocr.SetVariable("tessedit_char_whitelist", "ABEKMHOPCTXY-1234567890");
        }



        //тренировочная выборка
        private static void TesseractDownloadLangFile(String folder, String lang)
        {
            String subfolderName = "tessdata";
            String folderName = System.IO.Path.Combine(folder, subfolderName);
            if (!System.IO.Directory.Exists(folderName))
            {
                System.IO.Directory.CreateDirectory(folderName);
            }
            String dest = System.IO.Path.Combine(folderName, String.Format("{0}.traineddata", lang));
            if (!System.IO.File.Exists(dest))
                using (System.Net.WebClient webclient = new System.Net.WebClient())
                {
                    String source =
                        String.Format("https://github.com/tesseract-ocr/tessdata/blob/4592b8d453889181e01982d22328b5846765eaad/{0}.traineddata?raw=true", lang);

                    Console.WriteLine(String.Format("Downloading file from '{0}' to '{1}'", source, dest));
                    webclient.DownloadFile(source, dest);
                    Console.WriteLine(String.Format("Download completed"));
                }
        }

        //инициализируем тесеракт
        private void InitOcr(String path, String lang, Emgu.CV.OCR.OcrEngineMode mode)
        {
            try
            {
                if (_ocr != null)
                {
                    _ocr.Dispose();
                    _ocr = null;
                }

                if (String.IsNullOrEmpty(path))
                    path = ".";

                TesseractDownloadLangFile(path, lang);
                TesseractDownloadLangFile(path, "osd"); //script orientation detection
                String pathFinal = path.Length == 0 ||
                                   path.Substring(path.Length - 1, 1).Equals(Path.DirectorySeparatorChar.ToString())
                    ? path
                    : String.Format("{0}{1}", path, System.IO.Path.DirectorySeparatorChar);

                //_ocr = new Emgu.CV.OCR.Tesseract(pathFinal, lang, mode);
                _ocr = new Tesseract.TesseractEngine(pathFinal, lang);
            }
            catch (System.Net.WebException e)
            {
                _ocr = null;
                throw  new Exception("Unable to download tesseract lang file. Please check internet connection.", e);
            }
            //catch (Exception e)
            //{
            //    _ocr = null;
            //    Console.WriteLine(e.Message);
            //}
        }



        /*
        /// <summary>
        /// Compute the white pixel mask for the given image. 
        /// A white pixel is a pixel where:  saturation &lt; 40 AND value &gt; 200
        /// </summary>
        /// <param name="image">The color image to find white mask from</param>
        /// <returns>The white pixel mask</returns>
        private static Image<Gray, Byte> GetWhitePixelMask(Image<Bgr, byte> image)
        {
           using (Image<Hsv, Byte> hsv = image.Convert<Hsv, Byte>())
           {
              Image<Gray, Byte>[] channels = hsv.Split();

              try
              {
                 //channels[1] is the mask for satuation less than 40, this is the mask for either white or black pixels
                 channels[1]._ThresholdBinaryInv(new Gray(40), new Gray(255));

                 //channels[2] is the mask for bright pixels
                 channels[2]._ThresholdBinary(new Gray(200), new Gray(255));

                 CvInvoke.BitwiseAnd(channels[1], channels[2], channels[0], null);
              }
              finally
              {
                 channels[1].Dispose();
                 channels[2].Dispose();
              }
              return channels[0];
           }
        }*/

        /// <summary>
        /// Detect license plate from the given image
        /// </summary>
        /// <param name="img">The image to search license plate from</param>
        /// <param name="licensePlateImagesList">A list of images where the detected license plate regions are stored</param>
        /// <param name="filteredLicensePlateImagesList">A list of images where the detected license plate regions (with noise removed) are stored</param>
        /// <param name="detectedLicensePlateRegionList">A list where the regions of license plate (defined by an MCvBox2D) are stored</param>
        /// <returns>The list of words for each license plate</returns>
        public List<String> DetectLicensePlate(
                   Emgu.CV.IInputArray img,
                   List<Emgu.CV.IInputOutputArray> licensePlateImagesList,
                   List<Emgu.CV.IInputOutputArray> filteredLicensePlateImagesList,
                   List<Emgu.CV.Structure.RotatedRect> detectedLicensePlateRegionList)
        {
            List<String> licenses = new List<String>();



            using (Emgu.CV.Mat gray = new Emgu.CV.Mat())
            using (Emgu.CV.Mat binary = new Emgu.CV.Mat())
            using (Emgu.CV.Mat canny = new Emgu.CV.Mat())
            using (Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint())
            {
                Emgu.CV.CvInvoke.CvtColor(img, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                Emgu.CV.CvInvoke.cvSetImageROI(gray,new Rectangle(100,60,400, 200));
                Emgu.CV.CvInvoke.Canny(gray, canny, 100, 50, 3, false);
                int[,] hierachy = Emgu.CV.CvInvoke.FindContourTree(canny, contours, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                FindLicensePlate(contours, hierachy, 0, gray, canny, licensePlateImagesList, filteredLicensePlateImagesList, detectedLicensePlateRegionList, licenses);
            }            
            return licenses;
        }

        private static int GetNumberOfChildren(int[,] hierachy, int idx)
        {
            //first child  
            if (hierachy.Length != 0)
            {
                if (hierachy.Length != 0)

                    idx = hierachy[idx, 2];

                if (idx < 0)
                    return 0;

                int count = 1;
                while (hierachy[idx, 0] > 0)
                {
                    count++;
                    idx = hierachy[idx, 0];
                }
                return count;
            }
            else return 0;
        }

        private void FindLicensePlate(
                       Emgu.CV.Util.VectorOfVectorOfPoint contours, 
                       int[,] hierachy, 
                       int idx,
                       Emgu.CV.IInputArray gray,
                       Emgu.CV.IInputArray canny,
                       List<Emgu.CV.IInputOutputArray> licensePlateImagesList, 
                       List<Emgu.CV.IInputOutputArray> filteredLicensePlateImagesList, 
                       List<Emgu.CV.Structure.RotatedRect> detectedLicensePlateRegionList,
                       List<String> licenses)
        {
            if (hierachy.Length != 0)
            {
                for (; idx >= 0; idx = hierachy[idx, 0])
                {
                    int numberOfChildren = GetNumberOfChildren(hierachy, idx);
                    //if it does not contains any children (charactor), it is not a license plate region
                    if (numberOfChildren == 0) continue;

                    using (Emgu.CV.Util.VectorOfPoint contour = contours[idx])
                    {
                        if (Emgu.CV.CvInvoke.ContourArea(contour) > 400)
                        {
                            if (numberOfChildren < 3)
                            {
                                //If the contour has less than 3 children, it is not a license plate (assuming license plate has at least 3 charactor)
                                //However we should search the children of this contour to see if any of them is a license plate
                                FindLicensePlate(contours, hierachy, hierachy[idx, 2], gray, canny, licensePlateImagesList,
                                   filteredLicensePlateImagesList, detectedLicensePlateRegionList, licenses);
                                continue;
                            }

                            Emgu.CV.Structure.RotatedRect box = Emgu.CV.CvInvoke.MinAreaRect(contour);
                            if (box.Angle < -45.0)
                            {
                                float tmp = box.Size.Width;
                                box.Size.Width = box.Size.Height;
                                box.Size.Height = tmp;
                                box.Angle += 90.0f;
                            }
                            else if (box.Angle > 45.0)
                            {
                                float tmp = box.Size.Width;
                                box.Size.Width = box.Size.Height;
                                box.Size.Height = tmp;
                                box.Angle -= 90.0f;
                            }

                            double whRatio = (double)box.Size.Width / box.Size.Height;
                            if (!(3.0 < whRatio && whRatio < 10.0))
                            //if (!(1.0 < whRatio && whRatio < 2.0))
                            {
                                //if the width height ratio is not in the specific range,it is not a license plate 
                                //However we should search the children of this contour to see if any of them is a license plate
                                //Contour<Point> child = contours.VNext;
                                if (hierachy[idx, 2] > 0)
                                    FindLicensePlate(contours, hierachy, hierachy[idx, 2], gray, canny, licensePlateImagesList,
                                       filteredLicensePlateImagesList, detectedLicensePlateRegionList, licenses);
                                continue;
                            }

                            using (Emgu.CV.UMat tmp1 = new Emgu.CV.UMat())
                            using (Emgu.CV.UMat tmp2 = new Emgu.CV.UMat())
                            {
                                PointF[] srcCorners = box.GetVertices();

                                PointF[] destCorners = new PointF[] {
                                new PointF(0, box.Size.Height - 1),
                                new PointF(0, 0),
                                new PointF(box.Size.Width - 1, 0),
                                new PointF(box.Size.Width - 1, box.Size.Height - 1)};

                                using (Emgu.CV.Mat rot = Emgu.CV.CvInvoke.GetAffineTransform(srcCorners, destCorners))
                                {
                                    Emgu.CV.CvInvoke.WarpAffine(gray, tmp1, rot, Size.Round(box.Size));
                                }

                                //resize the license plate such that the front is ~ 10-12. This size of front results in better accuracy from tesseract
                                Size approxSize = new Size(240, 180);
                                double scale = Math.Min(approxSize.Width / box.Size.Width, approxSize.Height / box.Size.Height);
                                Size newSize = new Size((int)Math.Round(box.Size.Width * scale), (int)Math.Round(box.Size.Height * scale));
                                Emgu.CV.CvInvoke.Resize(tmp1, tmp2, newSize, 0, 0, Emgu.CV.CvEnum.Inter.Cubic);

                                //removes some pixels from the edge
                                int edgePixelSize = 3;
                                Rectangle newRoi = new Rectangle(new Point(edgePixelSize, edgePixelSize),
                                   tmp2.Size - new Size(2 * edgePixelSize, 2 * edgePixelSize));
                                Emgu.CV.UMat plate = new Emgu.CV.UMat(tmp2, newRoi);

                                Emgu.CV.UMat filteredPlate = FilterPlate(plate);

                                //Tesseract.Character[] words;
                                StringBuilder strBuilder = new StringBuilder();
                                using (Emgu.CV.UMat tmp = filteredPlate.Clone())
                                {
                                    //Emgu.CV.OCR.Tesseract.Character[] words;

                                    //_ocr.Recognize(tmp);
                                    //strBuilder.Append(_ocr.GetText());

                                    //words = _ocr.GetCharacters();

                                    Tesseract.Page page = _ocr.Process(tmp.Bitmap, Tesseract.PageSegMode.SingleLine);
                                    //if (page.get.Count == 0) continue;
                                    //foreach (var item in words)
                                    //{
                                    //    strBuilder.Append(item.Text);
                                    //}
                                    //for (int i = 0; i < words.Length; i++)
                                    //{
                                    //    strBuilder.Append(words[i].Text);
                                    //}
                                    strBuilder.Append(page.GetText());
                                    page.Dispose();
                                }

                                licenses.Add(strBuilder.ToString());

                                //изображения номеров
                                licensePlateImagesList.Add(plate);
                                filteredLicensePlateImagesList.Add(filteredPlate);
                                detectedLicensePlateRegionList.Add(box);

                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Filter the license plate to remove noise
        /// </summary>
        /// <param name="plate">The license plate image</param>
        /// <returns>License plate image without the noise</returns>
        private static Emgu.CV.UMat FilterPlate(Emgu.CV.UMat plate)
        {
            Emgu.CV.UMat thresh = new Emgu.CV.UMat();
            Emgu.CV.CvInvoke.Threshold(plate, thresh, 120, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
            //Image<Gray, Byte> thresh = plate.ThresholdBinaryInv(new Gray(120), new Gray(255));

            Size plateSize = plate.Size;
            using (Emgu.CV.Mat plateMask = new Emgu.CV.Mat(plateSize.Height, plateSize.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 1))
            using (Emgu.CV.Mat plateCanny = new Emgu.CV.Mat())
            using (Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint())
            {
                plateMask.SetTo(new Emgu.CV.Structure.MCvScalar(255.0));
                //поиск краёв
                Emgu.CV.CvInvoke.Canny(plate, plateCanny, 100, 50);
                //контуры
                Emgu.CV.CvInvoke.FindContours(plateCanny, contours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (Emgu.CV.Util.VectorOfPoint contour = contours[i])
                    {
                        //отрисовываем квадрат по контуру
                        Rectangle rect = Emgu.CV.CvInvoke.BoundingRectangle(contour);
                        if (rect.Height > (plateSize.Height >> 1))
                        {
                            rect.X -= 1; rect.Y -= 1; rect.Width += 2; rect.Height += 2;
                            Rectangle roi = new Rectangle(Point.Empty, plate.Size);
                            rect.Intersect(roi);
                            Emgu.CV.CvInvoke.Rectangle(plateMask, rect, new Emgu.CV.Structure.MCvScalar(), -1);
                            //plateMask.Draw(rect, new Gray(0.0), -1);
                        }
                    }

                }

                thresh.SetTo(new Emgu.CV.Structure.MCvScalar(), plateMask);
            }

            Emgu.CV.CvInvoke.Erode(thresh, thresh, null, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Constant, Emgu.CV.CvInvoke.MorphologyDefaultBorderValue);
            Emgu.CV.CvInvoke.Dilate(thresh, thresh, null, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Constant, Emgu.CV.CvInvoke.MorphologyDefaultBorderValue);

            return thresh;
        }

        protected override void DisposeObject()
        {
            _ocr.Dispose();
        }
    }
}
