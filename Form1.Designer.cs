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
            grpMenu = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
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
            lblAppName.TabIndex = 1;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.Location = new Point(57, 204);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(449, 513);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴선택";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.치킨버거;
            pictureBox3.Location = new Point(256, 340);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
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
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoChickenBurger.Location = new Point(39, 363);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(179, 49);
            rdoChickenBurger.TabIndex = 0;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.Location = new Point(39, 234);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(211, 49);
            rdoBulgogiBurger.TabIndex = 0;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoHamBurger.Location = new Point(39, 105);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(147, 49);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOption.Location = new Point(512, 204);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(279, 390);
            grpOption.TabIndex = 0;
            grpOption.TabStop = false;
            grpOption.Text = "추가옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(17, 285);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(191, 49);
            chkSauce.TabIndex = 0;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(17, 219);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(191, 49);
            chkCheese.TabIndex = 0;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCola.Location = new Point(17, 148);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(116, 49);
            chkCola.TabIndex = 0;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkPotato.Location = new Point(17, 75);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(180, 49);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOrder.Location = new Point(797, 204);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(522, 390);
            grpOrder.TabIndex = 3;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(25, 310);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(275, 59);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(25, 67);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(469, 240);
            lstOrder.TabIndex = 0;
            lstOrder.SelectedIndexChanged += lstOrder_SelectedIndexChanged;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.LimeGreen;
            btnOrder.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = SystemColors.Control;
            btnOrder.Location = new Point(797, 618);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(250, 77);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Red;
            btnInit.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.ForeColor = SystemColors.Control;
            btnInit.Location = new Point(1074, 618);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(217, 77);
            btnInit.TabIndex = 5;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 813);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox grpMenu;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private GroupBox grpOption;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnInit;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
    }
}
