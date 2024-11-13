using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Runtime.Remoting.Channels;
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mat img; // 원본 이미지 보관
        NewImage newImage = null;


        private void imgLoadBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog src = new OpenFileDialog();

            if (src.ShowDialog() == DialogResult.OK)
            {

                img = Cv2.ImRead(src.FileName);


                Cv2.Resize(img, img, new OpenCvSharp.Size(358, 313));

                pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
            }
        }




        // 파이썬에서의 한 채널 분리 후 색상 표현 : cv.imshow('fdfd', img[:,:,1])
        // c# => 채널을 직접 분리하여 작업해야 한다!!!!!!
        private void Channel(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("이미지를 선택해 주세요!");
                return;
            }

            pictureBox2.Image = null;

            if (!(BlueC.Checked || GreenC.Checked || RedC.Checked || GrayC.Checked))
            {
                MessageBox.Show("블루, 그린, 레드 채널 중 선택 해 주세요");
                return;
            }

            Mat[] channels = Cv2.Split(img);
            Mat Channel = new Mat();

            if (BlueC.Checked)
            {
                Channel = channels[0];
            }
            else if (GreenC.Checked)
            {
                Channel = channels[1];
            }
            else if (RedC.Checked)
            {
                Channel = channels[2];
            }
            else
            {
                Cv2.CvtColor(img, Channel, ColorConversionCodes.BGR2GRAY);
            }

            pictureBox2.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Channel);

        }




        private void FlipBtn_Click(object sender, EventArgs e)
        {

            pictureBox2.Image = null;

            if (chBx.Checked == false && chBy.Checked == false && chBxy.Checked == false)
            {
                MessageBox.Show("방향을 선택해 주세요.");

                return;
            }

            // 이미지를 Mat 형식으로 변환!!!!
            Mat src = BitmapConverter.ToMat((Bitmap)pictureBox1.Image);


            Mat flipSrc = new Mat(src.Size(), src.Type());
            // Mat flipSrc = new Mat(src.Size(), MatType.CV_8SC3);
            // 사이즈랑 채널 설정
            // img.Size() : 새로운 Mat 객체의 사이즈를 img 객체를 이용하여 정한다 

            // MatType.... 
            // 데이터 타입(Element Type): 각 픽셀을 구성하는 데이터의 형식(예: CV_8U, CV_32F 등).
            //      CV_8U : 8비트 부호 없는 정수 (0-255 범위)
            // 채널 수(Channels): 한 픽셀이 저장할 수 있는 색상 채널 수(예: 1채널, 3채널, 4채널 등).


            if (chBx.Checked == true){
                Cv2.Flip(src, flipSrc, FlipMode.X);
            }
            if (chBy.Checked == true)
            {
                Cv2.Flip(src, flipSrc, FlipMode.Y);
            }
            if (chBxy.Checked == true)
            {
                Cv2.Flip(src, flipSrc, FlipMode.XY);
            }

            pictureBox2.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(flipSrc);
            
        }

        // 자르기는 안해봄
        // (https://076923.github.io/posts/C-opencv4-10/)

        //  Cv2.PyrDown(img, img);    축소
        //  Cv2.PyrDown(img, img);       확대
        private void pyUpBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(xAxis.Text)  || string.IsNullOrEmpty(yAxis.Text))
            {
                MessageBox.Show("xAxis 또는 yAxis의 텍스트가 비어 있습니다.");
                return ;
            }

            if (!rB15.Checked && !rB2.Checked)
            {
                MessageBox.Show("확대 비율을 선택해 주세요");
                return ;
            }

            int x = int.Parse(xAxis.Text) - 50;
            int y = int.Parse(yAxis.Text) - 50;

            Mat new_img = new Mat(img, new Rect(x, y, 100, 100));  // 이미지 선택 : w, y 시작 좌표, x축으로 자를 크기, y 축으로 자를 크기

            Mat imgPyUp = new Mat();  // 선택한 이미지 확대
            if (rB15.Checked)
            {
                Cv2.Resize(new_img, imgPyUp, new OpenCvSharp.Size(new_img.Width * 1.5, new_img.Height * 1.5));
            }
            else
            {
                Cv2.Resize(new_img, imgPyUp, new OpenCvSharp.Size(new_img.Width * 2, new_img.Height * 2));

            }

            NewImage new_imgForm = new NewImage(imgPyUp);

            new_imgForm.ShowDialog();
            

        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("이미지를 선택해 주세요");
                return ;
            }

             if (e.Button == MouseButtons.Left)
            {
                xAxis.Text = e.X.ToString();
                yAxis.Text = e.Y.ToString();

                
            }

            if (!rB15.Checked && !rB2.Checked)
            {
                rB15.Checked = true;
            }


            DrawingImage(e.X, e.Y);

        }



        private void DrawingImage(int x, int y)
        {
            Mat drawing_src = img.Clone();

            Cv2.Rectangle(drawing_src, new Rect(x-50, y-50, 100, 100), new Scalar(0, 0, 255), 2);

            pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(drawing_src);
        }


        private void TtrackBar1_Scroll(object sender, EventArgs e)
        {
            lbT.Text = tBThresholdValue.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBOtsu.Checked)
            {
                tBThresholdValue.Enabled = false;
               // lbT.Text = "X";
            }
            else
            {
                tBThresholdValue.Enabled = true;
                lbT.Text = tBThresholdValue.Value.ToString();

            }
        }

        // 참고 https://076923.github.io/posts/C-opencv4-11/
        // 이진화
        private void btBinarization_Click(object sender, EventArgs e)
        {

            if(pictureBox2.Image == null){
                MessageBox.Show("채널을 먼저 선택해 주세요");
                return ;
            }

            Mat src = BitmapConverter.ToMat((Bitmap)pictureBox2.Image);
            Mat equalized = new Mat();
            Mat binary = new Mat();


            if (!ckHist.Checked)
            {
                // 균등화 아닐 때
                if (MessageBox.Show("평활화를 진행 하시겠습니까?", "질문", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ckHist.Checked = true;

                    Equalize(src, equalized);

                    // 이진화 바로 진행

                    if (chBOtsu.Checked)
                    {
                        double otsuThreshold = Cv2.Threshold(equalized, binary, 0, 255, ThresholdTypes.Otsu);
                        lbT.Text = otsuThreshold.ToString();
                    }
                    else
                    {
                        Cv2.Threshold(equalized, binary, tBThresholdValue.Value, 255, ThresholdTypes.Binary);
                        
                    }

                    newImage = new NewImage(binary);
                    newImage.Show();
                }
                else
                {

                    // 이진화 바로 진행

                    if (chBOtsu.Checked)
                    {
                        double otsuThreshold = Cv2.Threshold(equalized, binary, 0, 255, ThresholdTypes.Otsu);
                        lbT.Text = otsuThreshold.ToString();
                    }
                    else
                    {
                        Cv2.Threshold(src, binary, tBThresholdValue.Value, 255, ThresholdTypes.Binary);
                    }

                    newImage = new NewImage(binary);
                    newImage.Show();


                }
            }
            else
            {
                // 균등화 진행
                Equalize(src, equalized);

                if (chBOtsu.Checked)
                {
                    double otsuThreshold = Cv2.Threshold(equalized, binary, 0, 255, ThresholdTypes.Otsu);
                    lbT.Text = otsuThreshold.ToString();
                }
                else
                {
                    Cv2.Threshold(equalized, binary, tBThresholdValue.Value, 255, ThresholdTypes.Binary);
                }

                newImage = new NewImage(binary);
                newImage.Show();
            }
  
        }


        public void Equalize(Mat src, Mat equalized)
        {

            if (BlueC.Checked || GreenC.Checked || RedC.Checked)
            {
                Cv2.EqualizeHist(src, equalized);
            }
            else
            {
                Cv2.EqualizeHist(src, equalized);
            }

        }

        private void BtHist_Click(object sender, EventArgs e)
        {
            //if (pictureBox2.Image == null)
            //{
            //    MessageBox.Show("채널 단일화 또는 그레이 스케일로 먼저 변환해 주세요");
            //    return;
            //}

            //ckHist.Checked = true;

            //Mat src = BitmapConverter.ToMat((Bitmap)pictureBox2.Image);

            //Mat equalized = new Mat();

            //if (BlueC.Checked || GreenC.Checked || RedC.Checked)
            //{
            //    Cv2.EqualizeHist(src, equalized);
            //}
            //else
            //{
            //    Cv2.EqualizeHist(src, equalized);
            //}

            //pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(equalized);
               
        }

        private void changeHistogram()
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("채널 단일화 또는 그레이 스케일로 먼저 변환해 주세요");
                return;
            }

            ckHist.Checked = true;

            Mat src = BitmapConverter.ToMat((Bitmap)pictureBox2.Image);

            Mat equalized = new Mat();

            if (BlueC.Checked || GreenC.Checked || RedC.Checked)
            {
                Cv2.EqualizeHist(src, equalized);
            }
            else
            {
                Cv2.EqualizeHist(src, equalized);
            }

            pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(equalized);

        }

        private void ckHist_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHist.Checked)
            {
                changeHistogram();
                this.Height = 699;
                pictureBox3.Visible = true;
            }
            else
            {
                this.Height = 456;
                pictureBox3.Visible = false;
                pictureBox3.Image = null;
            }
        }

        private void btnMorphology_Click(object sender, EventArgs e)
        {
            if (newImage == null)
            {
                MessageBox.Show("이진화를 진행해 주세요");
                return;
            }

            Mat element = null;
            int size = 3;


            if (int.Parse(tbSize.Text) == 0)
            {
                MessageBox.Show("기본 사이즈는 3입니다");
                tbSize.Text = "3";
            }
            else if (int.Parse(tbSize.Text) < 3 || int.Parse(tbSize.Text) % 2 == 0)
            {
                MessageBox.Show("3 이상 홀수로 설정해 주세요.");
                return;
            }
            else
            {
                size = int.Parse(tbSize.Text);
            }


            if (rbRect.Checked)
            {
                element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(size, size));  // 구조요소 인자(shape, size, anchor) => 고정점을 할당하지 않을 시 조금 더 유동적인 커널이 된다.
            }
            else if (rbCross.Checked)
            {
                element = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(size, size));
            }
            else if (rbElipse.Checked)
            {
                element = Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(size, size));
            }
            else
            {
                element = new Mat(size, size, MatType.CV_8U, new Scalar(0));

                int fixSize = (size - 3)/2;

                switch (cbCustom.SelectedIndex)
                {
                    case 0:
                        element.Set(1+ fixSize, 1+ fixSize, 1 + fixSize); // 중앙
                        element.Set(2+ fixSize, 1 + fixSize, 1 + fixSize);
                        element.Set(0+ fixSize, 2 + fixSize, 1 + fixSize);
                        break;
                    case 1:
                        element.Set(1 + fixSize, 1 + fixSize, 1 + fixSize);
                        element.Set(0 + fixSize, 0 + fixSize, 1 + fixSize);
                        element.Set(2 + fixSize, 2 + fixSize, 1 + fixSize);
                        break;
                    case 2:
                        element.Set(1 + fixSize, 1 + fixSize, 1 + fixSize);
                        element.Set(1 + fixSize, 0 + fixSize, 1 + fixSize);
                        element.Set(1 + fixSize, 2 + fixSize, 1 + fixSize);
                        break;
                    case 3:
                        element.Set(1 + fixSize, 1 + fixSize, 1 + fixSize);
                        element.Set(0 + fixSize, 1 + fixSize, 1 + fixSize);
                        element.Set(2 + fixSize, 1 + fixSize, 1 + fixSize);
                        break;
                }

            }


            Mat src = BitmapConverter.ToMat((Bitmap)newImage.pictureBox1.Image);
            Mat dilateOrErode = null;

            int repeat = tbRepeat.Text == null? 3 : int.Parse(tbRepeat.Text);

            if (rbDilate.Checked)
            {
                dilateOrErode = new Mat();
                // Cv2.Dilate(src, dilate, element, new OpenCvSharp.Point(2, 2), 3); // Cv2.Dilate(원본 배열, 결과 배열, 구조 요소, 고정점, 반복 횟수, 테두리 외삽법, 테두리 색상) 고정점???
                Cv2.Dilate(src, dilateOrErode, element, new OpenCvSharp.Point(-1, -1), repeat); // Cv2.Dilate(원본 배열, 결과 배열, 구조 요소, 고정점, 반복 횟수, 테두리 외삽법, 테두리 색상) 고정점???
            }
            else if (rbErode.Checked)
            {
                dilateOrErode = new Mat();
                Cv2.Erode(src, dilateOrErode, element, new OpenCvSharp.Point(-1, -1), repeat); // 고정점 수치를 -1로 두면 자동으로 중앙으로 사용한다.(위는 5x5 사이즈 커널에서 명시적으로 중앙 위치 설정)
            }

            
           
            newImage.pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dilateOrErode);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
