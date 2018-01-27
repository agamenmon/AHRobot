using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;

namespace example
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture = null;
        private bool _captureInProgress;
        private Mat _frame;
        private Mat _grayFrame;
        private Mat _smallGrayFrame;
        private Mat _smoothedGrayFrame;
        private Mat _cannyFrame;

        public Form1()
        {
            InitializeComponent();
            
            CvInvoke.UseOpenCL = false;
            try
            {
                // change camera input, the value in function VideoCapture 
                /*  VideoCapture()                  Create a capture using the default camera
                *   VideoCapture(Int32)             Create a capture using the specific camera
                *   VideoCapture(String)            Create a capture from file or a video stream
                *   VideoCapture(CaptureType)       Create a capture using the specific camera 
                */
                //_capture = new VideoCapture(1);
                _capture = new VideoCapture("test.avi");
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            _frame = new Mat();
            _grayFrame = new Mat();
            _smallGrayFrame = new Mat();
            _smoothedGrayFrame = new Mat();
            _cannyFrame = new Mat();
        }
        // added this method, created. Its not the method on form
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);

                CvInvoke.CvtColor(_frame, _grayFrame, ColorConversion.Bgr2Gray);

                CvInvoke.PyrDown(_grayFrame, _smallGrayFrame);

                CvInvoke.PyrUp(_smallGrayFrame, _smoothedGrayFrame);

                CvInvoke.Canny(_smoothedGrayFrame, _cannyFrame, 100, 60);

                captureImageBox.Image = _frame;
                grayscaleImageBox.Image = _grayFrame;
                smoothedGrayscaleImageBox.Image = _smoothedGrayFrame;
                cannyImageBox.Image = _cannyFrame;

                // process grayFrame here

                //vector<Vec2f> abc;
            }
        }
        // This method process the event button
        private void btStart_Click(object sender, EventArgs e)
        {
            /* _capture: Data's captured from videoCapture, videocapture start, the value _capture is not Zero, Null
             * _captureInProgress: Checking capture video is progressing or not. The return value is TRUE if capture video is started
             * Check _capture is not null. It has data input on camera
             * if progress video is going, _capture will pause by method VideoCapture.Pause
             * if not, _ capture video will start
             *
             */
            if (_capture != null)
            {
                if (_captureInProgress)
                {  //stop the capture
                    captureButton.Text = "Start Capture";
                    _capture.Pause();
                }
                else
                {
                    //start the capture
                    captureButton.Text = "Stop";
                    _capture.Start();
                }
                _captureInProgress = !_captureInProgress;
            }
        }
    }
}
