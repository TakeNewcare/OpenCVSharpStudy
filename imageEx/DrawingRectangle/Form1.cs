using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace DrawingRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dig = new OpenFileDialog();  // 파일 로드
                if (dig.ShowDialog() == DialogResult.OK)
                {
                    Mat image = Cv2.ImRead(dig.FileName);

                    // 픽쳐 박스에 표현하기
                    //pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image); // picturebox 표시를 위해 mat -> bitmap

                    // cv2 기능 이용해서 표현하기
                    Cv2.ImShow("dd", image);
                    Cv2.WaitKey(0);
                    Cv2.DestroyAllWindows();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
