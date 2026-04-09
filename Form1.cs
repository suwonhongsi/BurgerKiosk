using System;
using System.Drawing;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = btn_order;
            this.CancelButton = reset_button;

            // 실시간 업데이트 연결
            rdoHamburger.CheckedChanged += Selection_Changed;
            rdoBulgogiBurger.CheckedChanged += Selection_Changed;
            rdoChickenBurger.CheckedChanged += Selection_Changed;
            chkFried.CheckedChanged += Selection_Changed;
            chkCoke.CheckedChanged += Selection_Changed;
            chkCheese.CheckedChanged += Selection_Changed;
            chkSauce.CheckedChanged += Selection_Changed;

            // 탭 설정: 리스트와 체크박스 2~4번은 탭에서 제외
            lstOrder.TabStop = false;
            chkFried.TabStop = true;  // 옵션 그룹의 '입구' 역할
            chkCoke.TabStop = false;
            chkCheese.TabStop = false;
            chkSauce.TabStop = false;

            // 체크박스 방향키 이동 이벤트 연결
            chkFried.KeyDown += CheckBox_Navigation;
            chkCoke.KeyDown += CheckBox_Navigation;
            chkCheese.KeyDown += CheckBox_Navigation;
            chkSauce.KeyDown += CheckBox_Navigation;

            this.Shown += (s, e) => { ClearAllSelections(); this.ActiveControl = null; };
        }

        // 체크박스 안에서 방향키로 이동하는 로직
        private void CheckBox_Navigation(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
                e.Handled = true;
            }
        }

        private void Selection_Changed(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }

        private void UpdateOrderInfo()
        {
            int totalCost = 0;
            lstOrder.Items.Clear();
            lblTotalCost.ForeColor = Color.Black;

            if (rdoHamburger.Checked) { totalCost += 5000; lstOrder.Items.Add("햄버거 5,000원"); }
            else if (rdoBulgogiBurger.Checked) { totalCost += 4000; lstOrder.Items.Add("불고기버거 4,000원"); }
            else if (rdoChickenBurger.Checked) { totalCost += 3000; lstOrder.Items.Add("치킨버거 3,000원"); }

            if (chkFried.Checked) { totalCost += 3500; lstOrder.Items.Add("감자튀김 3,500원"); }
            if (chkCoke.Checked) { totalCost += 2500; lstOrder.Items.Add("콜라 2,500원"); }
            if (chkCheese.Checked) { totalCost += 1500; lstOrder.Items.Add("치즈 추가 1,500원"); }
            if (chkSauce.Checked) { totalCost += 500; lstOrder.Items.Add("소스 추가 500원"); }

            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (!rdoHamburger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요.";
                lblTotalCost.ForeColor = Color.Red;
                return;
            }
        }

        private void ClearAllSelections()
        {
            rdoHamburger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkFried.Checked = false;
            chkCoke.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            rdoHamburger.TabStop = true;
            chkFried.TabStop = true;

            lstOrder.Items.Clear();
            lblTotalCost.ForeColor = Color.Black;
            lblTotalCost.Text = "총 금액 : 0원";
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            ClearAllSelections();
            this.ActiveControl = null;
        }

        private void bulgogi_CheckedChanged(object sender, EventArgs e) { }
        private void hamburger_CheckedChanged(object sender, EventArgs e) { }
    }
}