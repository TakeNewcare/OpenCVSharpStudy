using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewImage : Form
    {
        Mat img;

        public NewImage(Mat new_img)
        {
            InitializeComponent();

            img = new_img;
            this.Width = img.Width + 38;
            this.Height = img.Height + 62;

            pictureBox1.Width = img.Width;
            pictureBox1.Height = img.Height;
        }

        

        private void NewImage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
        }

        private void NewImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
