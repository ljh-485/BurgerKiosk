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
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamburger = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).BeginInit();
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
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picHamburger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.Location = new Point(57, 204);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(449, 513);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴선택";
            // 
            // picChickenBurger
            // 
            picChickenBurger.BackgroundImageLayout = ImageLayout.Stretch;
            picChickenBurger.Image = Properties.Resources.치킨버거;
            picChickenBurger.Location = new Point(256, 340);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(142, 126);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 5;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.BackgroundImageLayout = ImageLayout.Stretch;
            picBulgogiBurger.Image = Properties.Resources.불고기버거;
            picBulgogiBurger.Location = new Point(256, 203);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(142, 131);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 4;
            picBulgogiBurger.TabStop = false;
            picBulgogiBurger.Click += pictureBox2_Click;
            // 
            // picHamburger
            // 
            picHamburger.BackgroundImageLayout = ImageLayout.Stretch;
            picHamburger.Image = Properties.Resources.햄버거;
            picHamburger.Location = new Point(256, 75);
            picHamburger.Name = "picHamburger";
            picHamburger.Size = new Size(142, 122);
            picHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamburger.TabIndex = 3;
            picHamburger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoChickenBurger.Location = new Point(39, 363);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(179, 49);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += UpdateOrder;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.Location = new Point(39, 234);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(211, 49);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += UpdateOrder;
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
            rdoHamBurger.CheckedChanged += UpdateOrder;
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
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            grpOption.Text = "추가옵션";
            grpOption.Enter += grpOption_Enter;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(17, 285);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(191, 49);
            chkSauce.TabIndex = 3;
            chkSauce.TabStop = false;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += UpdateOrder;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(17, 219);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(191, 49);
            chkCheese.TabIndex = 2;
            chkCheese.TabStop = false;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += UpdateOrder;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCola.Location = new Point(17, 148);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(116, 49);
            chkCola.TabIndex = 1;
            chkCola.TabStop = false;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += UpdateOrder;
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
            chkPotato.CheckedChanged += UpdateOrder;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOrder.Location = new Point(797, 204);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(522, 390);
            grpOrder.TabIndex = 0;
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
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(25, 67);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(469, 240);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
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
            btnOrder.TabIndex = 3;
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
            btnInit.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).EndInit();
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
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picHamburger;
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
