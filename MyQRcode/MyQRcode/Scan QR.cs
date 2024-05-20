using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;

namespace MyQRcode
{
    public partial class Scan_QR : Form
    {
        public FilterInfoCollection CaptureDevice;
        public VideoCaptureDevice Final_Frame;
        public Scan_QR()
        {
            InitializeComponent();
        }

        private void Scan_QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Final_Frame.IsRunning) { Final_Frame.Stop(); }
            //Final_Frame.Stop();
            /*
            try
            {
                Final_Frame.Stop();
            }
            catch
            {
                Form f_main = Application.OpenForms[0];

                f_main.StartPosition = FormStartPosition.Manual;

                f_main.Left = this.Left;
                f_main.Top = this.Top;

                f_main.Show();
            }
            */
            
            Form f_main = Application.OpenForms[0];

            f_main.StartPosition = FormStartPosition.Manual;

            f_main.Left = this.Left;
            f_main.Top = this.Top;

            f_main.Show();
            
        }

        private void Scan_QR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo Device in CaptureDevice)
            {
                box_cam.Items.Add(Device.Name);
            }

            box_cam.SelectedIndex = 0;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Final_Frame = new VideoCaptureDevice(CaptureDevice[box_cam.SelectedIndex].MonikerString);
            Final_Frame.NewFrame += new NewFrameEventHandler(NewFinalFrame);
            Final_Frame.Start();
        }

        private void NewFinalFrame(object sender, NewFrameEventArgs eventArgs)
        {
            scan_pic.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)scan_pic.Image);
            
            if(result != null)
            {
                try
                {
                    string decoded = result.ToString();
                    if (decoded != "")
                    {
                        text_QR.Text = decoded;
                        timer1.Stop();
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
