namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgLoadBtn = new System.Windows.Forms.Button();
            this.chBxy = new System.Windows.Forms.CheckBox();
            this.chBx = new System.Windows.Forms.CheckBox();
            this.chBy = new System.Windows.Forms.CheckBox();
            this.FlipBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pyUpBtn = new System.Windows.Forms.Button();
            this.xAxis = new System.Windows.Forms.TextBox();
            this.yAxis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rB15 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.grayScale = new System.Windows.Forms.Button();
            this.btBinarization = new System.Windows.Forms.Button();
            this.BlueC = new System.Windows.Forms.RadioButton();
            this.GreenC = new System.Windows.Forms.RadioButton();
            this.GrayC = new System.Windows.Forms.RadioButton();
            this.RedC = new System.Windows.Forms.RadioButton();
            this.tBThresholdValue = new System.Windows.Forms.TrackBar();
            this.labelDivider = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBOtsu = new System.Windows.Forms.CheckBox();
            this.lbT = new System.Windows.Forms.Label();
            this.ckHist = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMorphology = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbCross = new System.Windows.Forms.RadioButton();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.rbRect = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbRepeat = new System.Windows.Forms.TextBox();
            this.cbCustom = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbErode = new System.Windows.Forms.RadioButton();
            this.rbOpen = new System.Windows.Forms.RadioButton();
            this.rbDilate = new System.Windows.Forms.RadioButton();
            this.rbClose = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVideoLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBThresholdValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 313);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(12, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(358, 313);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(380, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 313);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // imgLoadBtn
            // 
            this.imgLoadBtn.Location = new System.Drawing.Point(750, 12);
            this.imgLoadBtn.Name = "imgLoadBtn";
            this.imgLoadBtn.Size = new System.Drawing.Size(145, 48);
            this.imgLoadBtn.TabIndex = 1;
            this.imgLoadBtn.Text = "이미지 불러오기";
            this.imgLoadBtn.UseVisualStyleBackColor = true;
            this.imgLoadBtn.Click += new System.EventHandler(this.imgLoadBtn_Click);
            // 
            // chBxy
            // 
            this.chBxy.AutoSize = true;
            this.chBxy.Location = new System.Drawing.Point(90, 18);
            this.chBxy.Name = "chBxy";
            this.chBxy.Size = new System.Drawing.Size(52, 16);
            this.chBxy.TabIndex = 2;
            this.chBxy.Text = "x + y";
            this.chBxy.UseVisualStyleBackColor = true;
            // 
            // chBx
            // 
            this.chBx.AutoSize = true;
            this.chBx.Location = new System.Drawing.Point(16, 18);
            this.chBx.Name = "chBx";
            this.chBx.Size = new System.Drawing.Size(31, 16);
            this.chBx.TabIndex = 2;
            this.chBx.Text = "x";
            this.chBx.UseVisualStyleBackColor = true;
            // 
            // chBy
            // 
            this.chBy.AutoSize = true;
            this.chBy.Location = new System.Drawing.Point(53, 18);
            this.chBy.Name = "chBy";
            this.chBy.Size = new System.Drawing.Size(31, 16);
            this.chBy.TabIndex = 2;
            this.chBy.Text = "y";
            this.chBy.UseVisualStyleBackColor = true;
            // 
            // FlipBtn
            // 
            this.FlipBtn.Location = new System.Drawing.Point(6, 41);
            this.FlipBtn.Name = "FlipBtn";
            this.FlipBtn.Size = new System.Drawing.Size(145, 48);
            this.FlipBtn.TabIndex = 1;
            this.FlipBtn.Text = "대칭";
            this.FlipBtn.UseVisualStyleBackColor = true;
            this.FlipBtn.Click += new System.EventHandler(this.FlipBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlipBtn);
            this.groupBox1.Controls.Add(this.chBy);
            this.groupBox1.Controls.Add(this.chBx);
            this.groupBox1.Controls.Add(this.chBxy);
            this.groupBox1.Location = new System.Drawing.Point(744, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pyUpBtn
            // 
            this.pyUpBtn.Location = new System.Drawing.Point(6, 111);
            this.pyUpBtn.Name = "pyUpBtn";
            this.pyUpBtn.Size = new System.Drawing.Size(145, 48);
            this.pyUpBtn.TabIndex = 1;
            this.pyUpBtn.Text = "확대";
            this.pyUpBtn.UseVisualStyleBackColor = true;
            this.pyUpBtn.Click += new System.EventHandler(this.pyUpBtn_Click);
            // 
            // xAxis
            // 
            this.xAxis.Location = new System.Drawing.Point(37, 20);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(111, 21);
            this.xAxis.TabIndex = 5;
            // 
            // yAxis
            // 
            this.yAxis.Location = new System.Drawing.Point(37, 52);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(111, 21);
            this.yAxis.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y :";
            // 
            // rB15
            // 
            this.rB15.AutoSize = true;
            this.rB15.Location = new System.Drawing.Point(26, 87);
            this.rB15.Name = "rB15";
            this.rB15.Size = new System.Drawing.Size(50, 16);
            this.rB15.TabIndex = 5;
            this.rB15.TabStop = true;
            this.rB15.Text = "x 1.5";
            this.rB15.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(96, 87);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(40, 16);
            this.rB2.TabIndex = 5;
            this.rB2.TabStop = true;
            this.rB2.Text = "x 2";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // grayScale
            // 
            this.grayScale.Location = new System.Drawing.Point(6, 63);
            this.grayScale.Name = "grayScale";
            this.grayScale.Size = new System.Drawing.Size(145, 48);
            this.grayScale.TabIndex = 1;
            this.grayScale.Text = "채널 변화";
            this.grayScale.UseVisualStyleBackColor = true;
            this.grayScale.Click += new System.EventHandler(this.Channel);
            // 
            // btBinarization
            // 
            this.btBinarization.Location = new System.Drawing.Point(5, 281);
            this.btBinarization.Name = "btBinarization";
            this.btBinarization.Size = new System.Drawing.Size(145, 48);
            this.btBinarization.TabIndex = 1;
            this.btBinarization.Text = "이진화";
            this.btBinarization.UseVisualStyleBackColor = true;
            this.btBinarization.Click += new System.EventHandler(this.btBinarization_Click);
            // 
            // BlueC
            // 
            this.BlueC.AutoSize = true;
            this.BlueC.Location = new System.Drawing.Point(18, 21);
            this.BlueC.Name = "BlueC";
            this.BlueC.Size = new System.Drawing.Size(31, 16);
            this.BlueC.TabIndex = 2;
            this.BlueC.Text = "B";
            this.BlueC.UseVisualStyleBackColor = true;
            // 
            // GreenC
            // 
            this.GreenC.AutoSize = true;
            this.GreenC.Location = new System.Drawing.Point(62, 21);
            this.GreenC.Name = "GreenC";
            this.GreenC.Size = new System.Drawing.Size(32, 16);
            this.GreenC.TabIndex = 2;
            this.GreenC.Text = "G";
            this.GreenC.UseVisualStyleBackColor = true;
            // 
            // GrayC
            // 
            this.GrayC.AutoSize = true;
            this.GrayC.Checked = true;
            this.GrayC.Location = new System.Drawing.Point(100, 41);
            this.GrayC.Name = "GrayC";
            this.GrayC.Size = new System.Drawing.Size(50, 16);
            this.GrayC.TabIndex = 2;
            this.GrayC.TabStop = true;
            this.GrayC.Text = "Gray";
            this.GrayC.UseVisualStyleBackColor = true;
            // 
            // RedC
            // 
            this.RedC.AutoSize = true;
            this.RedC.Location = new System.Drawing.Point(100, 20);
            this.RedC.Name = "RedC";
            this.RedC.Size = new System.Drawing.Size(31, 16);
            this.RedC.TabIndex = 2;
            this.RedC.Text = "R";
            this.RedC.UseVisualStyleBackColor = true;
            // 
            // tBThresholdValue
            // 
            this.tBThresholdValue.Location = new System.Drawing.Point(6, 179);
            this.tBThresholdValue.Maximum = 255;
            this.tBThresholdValue.Name = "tBThresholdValue";
            this.tBThresholdValue.Size = new System.Drawing.Size(145, 45);
            this.tBThresholdValue.TabIndex = 3;
            this.tBThresholdValue.Scroll += new System.EventHandler(this.TtrackBar1_Scroll);
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(6, 125);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(145, 4);
            this.labelDivider.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 4);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "임계값 설정";
            // 
            // chBOtsu
            // 
            this.chBOtsu.AutoSize = true;
            this.chBOtsu.Location = new System.Drawing.Point(42, 259);
            this.chBOtsu.Name = "chBOtsu";
            this.chBOtsu.Size = new System.Drawing.Size(107, 16);
            this.chBOtsu.TabIndex = 6;
            this.chBOtsu.Text = "Otsu Algorithm";
            this.chBOtsu.UseVisualStyleBackColor = true;
            this.chBOtsu.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Location = new System.Drawing.Point(129, 227);
            this.lbT.Name = "lbT";
            this.lbT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbT.Size = new System.Drawing.Size(11, 12);
            this.lbT.TabIndex = 7;
            this.lbT.Text = "0";
            this.lbT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckHist
            // 
            this.ckHist.AutoSize = true;
            this.ckHist.Location = new System.Drawing.Point(16, 136);
            this.ckHist.Name = "ckHist";
            this.ckHist.Size = new System.Drawing.Size(124, 16);
            this.ckHist.TabIndex = 8;
            this.ckHist.Text = "히스토그램 평활화";
            this.ckHist.UseVisualStyleBackColor = true;
            this.ckHist.CheckedChanged += new System.EventHandler(this.ckHist_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckHist);
            this.groupBox3.Controls.Add(this.lbT);
            this.groupBox3.Controls.Add(this.chBOtsu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labelDivider);
            this.groupBox3.Controls.Add(this.tBThresholdValue);
            this.groupBox3.Controls.Add(this.RedC);
            this.groupBox3.Controls.Add(this.GrayC);
            this.groupBox3.Controls.Add(this.GreenC);
            this.groupBox3.Controls.Add(this.BlueC);
            this.groupBox3.Controls.Add(this.btBinarization);
            this.groupBox3.Controls.Add(this.grayScale);
            this.groupBox3.Location = new System.Drawing.Point(907, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 335);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnMorphology
            // 
            this.btnMorphology.Location = new System.Drawing.Point(5, 220);
            this.btnMorphology.Name = "btnMorphology";
            this.btnMorphology.Size = new System.Drawing.Size(145, 48);
            this.btnMorphology.TabIndex = 0;
            this.btnMorphology.Text = "모폴로지 적용";
            this.btnMorphology.UseVisualStyleBackColor = true;
            this.btnMorphology.Click += new System.EventHandler(this.btnMorphology_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbCustom);
            this.groupBox5.Controls.Add(this.tbRepeat);
            this.groupBox5.Controls.Add(this.tbSize);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.rbRect);
            this.groupBox5.Controls.Add(this.rbElipse);
            this.groupBox5.Controls.Add(this.rbCross);
            this.groupBox5.Location = new System.Drawing.Point(6, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 84);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "구조 요소";
            // 
            // rbCross
            // 
            this.rbCross.AutoSize = true;
            this.rbCross.Location = new System.Drawing.Point(86, 20);
            this.rbCross.Name = "rbCross";
            this.rbCross.Size = new System.Drawing.Size(59, 16);
            this.rbCross.TabIndex = 1;
            this.rbCross.TabStop = true;
            this.rbCross.Text = "십자가";
            this.rbCross.UseVisualStyleBackColor = true;
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.Location = new System.Drawing.Point(154, 20);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(47, 16);
            this.rbElipse.TabIndex = 1;
            this.rbElipse.TabStop = true;
            this.rbElipse.Text = "타원";
            this.rbElipse.UseVisualStyleBackColor = true;
            // 
            // rbRect
            // 
            this.rbRect.AutoSize = true;
            this.rbRect.Location = new System.Drawing.Point(10, 20);
            this.rbRect.Name = "rbRect";
            this.rbRect.Size = new System.Drawing.Size(71, 16);
            this.rbRect.TabIndex = 1;
            this.rbRect.TabStop = true;
            this.rbRect.Text = "직사각형";
            this.rbRect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "커널 크기 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "반복 횟수 :";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(80, 54);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(55, 21);
            this.tbSize.TabIndex = 4;
            this.tbSize.Text = "0";
            this.tbSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRepeat
            // 
            this.tbRepeat.Location = new System.Drawing.Point(248, 54);
            this.tbRepeat.Name = "tbRepeat";
            this.tbRepeat.Size = new System.Drawing.Size(55, 21);
            this.tbRepeat.TabIndex = 4;
            this.tbRepeat.Text = "0";
            this.tbRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbCustom
            // 
            this.cbCustom.FormattingEnabled = true;
            this.cbCustom.Items.AddRange(new object[] {
            "대각선(／)",
            "대각선(＼)",
            "수직(│)",
            "수평(─)"});
            this.cbCustom.Location = new System.Drawing.Point(203, 16);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(100, 20);
            this.cbCustom.TabIndex = 6;
            this.cbCustom.Text = "사용자 정의";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbClose);
            this.groupBox6.Controls.Add(this.rbDilate);
            this.groupBox6.Controls.Add(this.rbOpen);
            this.groupBox6.Controls.Add(this.rbErode);
            this.groupBox6.Location = new System.Drawing.Point(6, 155);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 50);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "연산";
            // 
            // rbErode
            // 
            this.rbErode.AutoSize = true;
            this.rbErode.Location = new System.Drawing.Point(89, 20);
            this.rbErode.Name = "rbErode";
            this.rbErode.Size = new System.Drawing.Size(47, 16);
            this.rbErode.TabIndex = 1;
            this.rbErode.TabStop = true;
            this.rbErode.Text = "침식";
            this.rbErode.UseVisualStyleBackColor = true;
            // 
            // rbOpen
            // 
            this.rbOpen.AutoSize = true;
            this.rbOpen.Location = new System.Drawing.Point(164, 20);
            this.rbOpen.Name = "rbOpen";
            this.rbOpen.Size = new System.Drawing.Size(47, 16);
            this.rbOpen.TabIndex = 1;
            this.rbOpen.TabStop = true;
            this.rbOpen.Text = "열기";
            this.rbOpen.UseVisualStyleBackColor = true;
            // 
            // rbDilate
            // 
            this.rbDilate.AutoSize = true;
            this.rbDilate.Location = new System.Drawing.Point(23, 20);
            this.rbDilate.Name = "rbDilate";
            this.rbDilate.Size = new System.Drawing.Size(47, 16);
            this.rbDilate.TabIndex = 1;
            this.rbDilate.TabStop = true;
            this.rbDilate.Text = "팽창";
            this.rbDilate.UseVisualStyleBackColor = true;
            // 
            // rbClose
            // 
            this.rbClose.AutoSize = true;
            this.rbClose.Location = new System.Drawing.Point(240, 20);
            this.rbClose.Name = "rbClose";
            this.rbClose.Size = new System.Drawing.Size(47, 16);
            this.rbClose.TabIndex = 1;
            this.rbClose.TabStop = true;
            this.rbClose.Text = "닫기";
            this.rbClose.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnMorphology);
            this.groupBox4.Location = new System.Drawing.Point(745, 407);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 274);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnVideoLoad
            // 
            this.btnVideoLoad.Location = new System.Drawing.Point(911, 12);
            this.btnVideoLoad.Name = "btnVideoLoad";
            this.btnVideoLoad.Size = new System.Drawing.Size(145, 48);
            this.btnVideoLoad.TabIndex = 1;
            this.btnVideoLoad.Text = "동영상 불러오기";
            this.btnVideoLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rB2);
            this.groupBox2.Controls.Add(this.rB15);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.yAxis);
            this.groupBox2.Controls.Add(this.xAxis);
            this.groupBox2.Controls.Add(this.pyUpBtn);
            this.groupBox2.Location = new System.Drawing.Point(744, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(1070, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "컨볼루젼";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 687);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVideoLoad);
            this.Controls.Add(this.imgLoadBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBThresholdValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button imgLoadBtn;
        private System.Windows.Forms.CheckBox chBxy;
        private System.Windows.Forms.CheckBox chBx;
        private System.Windows.Forms.CheckBox chBy;
        private System.Windows.Forms.Button FlipBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pyUpBtn;
        private System.Windows.Forms.TextBox xAxis;
        private System.Windows.Forms.TextBox yAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rB15;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.Button grayScale;
        private System.Windows.Forms.Button btBinarization;
        private System.Windows.Forms.RadioButton BlueC;
        private System.Windows.Forms.RadioButton GreenC;
        private System.Windows.Forms.RadioButton GrayC;
        private System.Windows.Forms.RadioButton RedC;
        private System.Windows.Forms.TrackBar tBThresholdValue;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBOtsu;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.CheckBox ckHist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMorphology;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbCustom;
        private System.Windows.Forms.TextBox tbRepeat;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbRect;
        private System.Windows.Forms.RadioButton rbElipse;
        private System.Windows.Forms.RadioButton rbCross;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbClose;
        private System.Windows.Forms.RadioButton rbDilate;
        private System.Windows.Forms.RadioButton rbOpen;
        private System.Windows.Forms.RadioButton rbErode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVideoLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

