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
    }
}
