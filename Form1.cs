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
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            if (!hamburger.Checked && !bulgogi.Checked && !chicken.Checked)
            {
                total.Text = "메뉴를 선택하세요.";
                total.ForeColor = Color.Red;
                return;
            }

            int totalCost = 0;
            list.Items.Clear();
            total.ForeColor = Color.Black; 

            if (hamburger.Checked)
            {
                totalCost += 5000;
                list.Items.Add("햄버거 5,000원");
            }
            else if (bulgogi.Checked)
            {
                totalCost += 4000;
                list.Items.Add("불고기버거 4,000원");
            }
            else if (chicken.Checked)
            {
                totalCost += 3000;
                list.Items.Add("치킨버거 3,000원");
            }

            if (fried.Checked) { totalCost += 3500; list.Items.Add("감자튀김 3,500원"); }
            if (coke.Checked) { totalCost += 2500; list.Items.Add("콜라 2,500원"); }
            if (cheese.Checked) { totalCost += 1500; list.Items.Add("치즈 추가 1,500원"); }
            if (source.Checked) { totalCost += 500; list.Items.Add("소스 추가 500원"); }

            total.Text = "총 금액 : " + totalCost.ToString("N0") + "원";

            MessageBox.Show(total.Text + " 주문이 완료되었습니다.");
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            hamburger.Checked = false;
            bulgogi.Checked = false;
            chicken.Checked = false;
            fried.Checked = false;
            coke.Checked = false;
            cheese.Checked = false;
            source.Checked = false;

            list.Items.Clear();
            total.ForeColor = Color.Black;
            total.Text = "총 금액 : 0원";
        }
        
        private void bulgogi_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void hamburger_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}