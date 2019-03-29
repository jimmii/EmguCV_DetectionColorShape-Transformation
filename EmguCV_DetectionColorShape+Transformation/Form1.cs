using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCV_DetectionColorShape_Transformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> input_img;
        //Image<Hsv, byte> hsv_img;

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Img Files|*.bmp;*.png;*.jpg";
                openFileDialog.DefaultExt = ".png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    input_img = new Image<Bgr, byte>(openFileDialog.FileName);
                    pictureBox1.Image = input_img.Bitmap;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       

        private void convertToGrayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (input_img == null)
            {
                return;
            }


            Image<Gray, byte> gray_img = new Image<Gray, byte>(input_img.Width, input_img.Height, new Gray(0));
            //gray_img = input_img.Convert<Gray, byte>();

            CvInvoke.CvtColor(input_img, gray_img, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            pictureBox2.Image = gray_img.Bitmap;
        }

        private void bGRToYCrCbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_img == null)
            {
                return;
            }

            Image<Ycc, byte> output_img = new Image<Ycc, byte>(input_img.Width, input_img.Height);
            Image<Bgr, byte> tmp_img = new Image<Bgr, byte>(input_img.Width, input_img.Height);
            CvInvoke.CvtColor(input_img, output_img, Emgu.CV.CvEnum.ColorConversion.Bgr2YCrCb);
            tmp_img.Data = output_img.Data;
            pictureBox2.Image = tmp_img.Bitmap;

           // CvInvoke.Imshow("YCC", output_img);
        }

        private void bGRToHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_img == null)
            {
                return;
            }

            Image<Hsv, byte> output_img = new Image<Hsv, byte>(input_img.Width, input_img.Height);
            Image<Bgr, byte> tmp_img = new Image<Bgr, byte>(input_img.Width, input_img.Height);
            CvInvoke.CvtColor(input_img, output_img, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            tmp_img.Data = output_img.Data;
            pictureBox2.Image = tmp_img.Bitmap;
        }

        private void bGRToLUVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_img == null)
            {
                return;
            }

            Image<Luv, byte> output_img = new Image<Luv, byte>(input_img.Width, input_img.Height);
            Image<Bgr, byte> tmp_img = new Image<Bgr, byte>(input_img.Width, input_img.Height);
            CvInvoke.CvtColor(input_img, output_img, Emgu.CV.CvEnum.ColorConversion.Bgr2Luv);
            tmp_img.Data = output_img.Data;
            pictureBox2.Image = tmp_img.Bitmap;
        }

        private void bGRToLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_img == null)
            {
                return;
            }

            Image<Lab, byte> output_img = new Image<Lab, byte>(input_img.Width, input_img.Height);
            Image<Bgr, byte> tmp_img = new Image<Bgr, byte>(input_img.Width, input_img.Height);
            CvInvoke.CvtColor(input_img, output_img, Emgu.CV.CvEnum.ColorConversion.Bgr2Lab);
            tmp_img.Data = output_img.Data;
            pictureBox2.Image = tmp_img.Bitmap;
        }

        private void bGRToHLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_img == null)
            {
                return;
            }

            Image<Hls, byte> output_img = new Image<Hls, byte>(input_img.Width, input_img.Height);
            Image<Bgr, byte> tmp_img = new Image<Bgr, byte>(input_img.Width, input_img.Height);
            CvInvoke.CvtColor(input_img, output_img, Emgu.CV.CvEnum.ColorConversion.Bgr2Hls);
            tmp_img.Data = output_img.Data;
            pictureBox2.Image = tmp_img.Bitmap;
        }
    }
}
