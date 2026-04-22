using System.Collections.Specialized;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Form2Burger burger = new Form2Burger();
        Form2Drink drink = new Form2Drink();
        Form2Side side = new Form2Side();
        private void btnBuger_Click(object sender, EventArgs e)
        {
            // burger.Show();
            Form2Burger burgerForm = new Form2Burger();
            burgerForm.Owner = this;
            burgerForm.ShowDialog();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            //drink.Show();
            Form2Drink drinkForm = new Form2Drink();
            drinkForm.Owner = this;
            drinkForm.ShowDialog();
        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            // side.Show();
            Form2Side sideForm = new Form2Side();
            sideForm.Owner = this;
            sideForm.ShowDialog();
        }
        int total = 0;
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int cur = 0;
            cur += burger.getBurgerprice();
            cur += side.getSideprice();
            string dirnkstr = drink.getDrinkprice();
            if (int.TryParse(dirnkstr, out int dPrice))
            {
                cur += dPrice;
            }
            textMain.Text = cur.ToString() + "원";


            //total += burger.getBurgerprice();
            //total += side.getSideprice();
            //total += int.Parse(drink.getDrinkprice());
            //textMain.Text = total.ToString();

            //int bur = burger.getBurgerprice();
            //textMain.Text += bur.ToString();
            //int si = side.getSideprice();
            //textMain.Text += si.ToString();
            //string dr = drink.getDrinkprice();
            //textMain.Text += dr.ToString();
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("K은행");
                lbPayInfo.Items.Add("N은행");
                lbPayInfo.Items.Add("S은행");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("N포인트");
                lbPayInfo.Items.Add("해피포인트");
                lbPayInfo.Items.Add("주유포인트");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cbPay.Text == "" || lbPayInfo.Text == "")
            {
                MessageBox.Show("결제방법 및 정보를 다시 확인해 주세요");
                return;
            }
            string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + "결제방법을 " + "\n선택하셧습니다.";
            MessageBox.Show(str);

            if (lbCart.Items.Count == 0)
            {
                MessageBox.Show("결제할 메뉴가 없습니다. 메뉴를 먼저 선택해 주세요.");
                return;
            }
            DialogResult result = MessageBox.Show($"총 {totalAmount:N0}원을 결제하시겠습니까?", "결제 확인", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("결제가 완료되었습니다!\n맛있게 준비해 드릴게요. 😊");
                lbCart.Items.Clear();
                totalAmount = 0;
                textMain.Text = "0원";
            }

            
            //    string str1 = "총 " + textMain.Text + "이 결제됩니다.";
            //MessageBox.Show(str1);
        }

        private void btnChked_Click(object sender, EventArgs e)
        {

        }
        int totalAmount = 0;

        public void AddToOrder(string name, int price)
        {
            lbCart.Items.Add($"{name} ({price}원)");

            totalAmount += price;

            textMain.Text = totalAmount.ToString("N0") + "원";
        }

        private void lbCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCart.SelectedItem != null)
            {
                string selectedItem = lbCart.SelectedItem.ToString();

                string priceString = System.Text.RegularExpressions.Regex.Replace(selectedItem, @"[^0-9]", "");

                if (int.TryParse(priceString, out int priceToSubtract))
                {
                    totalAmount -= priceToSubtract;
                    textMain.Text = totalAmount.ToString("N0") + "원";
                }

                lbCart.Items.Remove(lbCart.SelectedItem);

                MessageBox.Show("선택하신 메뉴가 삭제되었습니다.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("장바구니를 모두 비우시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbCart.Items.Clear();      // 리스트박스 비우기
                totalAmount = 0;           // 합계 0원
                textMain.Text = "0원";      // 텍스트박스 초기화
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Show();
            //this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
