using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognator
{
    class CaptureHolder
    {
        private Capture capture;

        public Capture GetCapture
        {
            get { return capture; }
            private set { capture = value; }
        }

        public CaptureHolder(string path)
        {
            if (capture != null) capture.Dispose();
            try
            {
                capture = new Capture(path);
            }
            catch (AccessViolationException)
            {
                capture.Stop();
            }
        }

    }
}
