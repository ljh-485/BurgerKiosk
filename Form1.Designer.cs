namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            lbl = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.RoyalBlue;
            lblAppName.Location = new Point(57, 57);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(547, 78);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox1.Location = new Point(57, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 513);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴선택";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            radioButton1.Location = new Point(39, 105);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(147, 49);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "햄버거";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            radioButton2.Location = new Point(39, 234);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(211, 49);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "불고기버거";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            radioButton3.Location = new Point(39, 363);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(179, 49);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "치킨버거";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox2.Location = new Point(512, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 390);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가옵션";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            radioButton4.Location = new Point(21, 105);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(179, 49);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "감자튀김";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            radioButton5.Location = new Point(21, 175);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(115, 49);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "콜라";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            radioButton6.Location = new Point(21, 245);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(190, 49);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "치즈 추가";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            radioButton7.Location = new Point(21, 310);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(190, 49);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.Text = "소스 추가";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.햄버거;
            pictureBox1.Location = new Point(256, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.불고기버거;
            pictureBox2.Location = new Point(256, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.치킨버거;
            pictureBox3.Location = new Point(256, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox3.Location = new Point(797, 204);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(522, 390);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(469, 240);
            listBox1.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.ForeColor = Color.Blue;
            lbl.Location = new Point(25, 310);
            lbl.Name = "lbl";
            lbl.Size = new Size(275, 59);
            lbl.TabIndex = 1;
            lbl.Text = "총 금액 : 0원";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(797, 618);
            button1.Name = "button1";
            button1.Size = new Size(250, 77);
            button1.TabIndex = 4;
            button1.Text = "주문하기";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1074, 618);
            button2.Name = "button2";
            button2.Size = new Size(217, 77);
            button2.TabIndex = 5;
            button2.Text = "초기화";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 813);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Berger Kiosk v1.0";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Label lbl;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}
