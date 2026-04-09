namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = lblAppName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        int totalCost = 0;
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }

            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }

            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
            }

            if (totalCost == 0)
            {
                // 아무것도 선택하지 않았을 때
                lblTotalCost.ForeColor = Color.Red; // 글자색 빨간색
                lblTotalCost.Text = "메뉴를 선택해주세요";
            }
            else
            {
                // 메뉴가 정상적으로 선택되었을 때
                lblTotalCost.ForeColor = Color.Blue; // 글자색 기본 검정색
                lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
        }


        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpOption_Enter(object sender, EventArgs e)
        {

        }
    }
}
