using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2Burger : Form
    {
        public Form2Burger()
        {
            InitializeComponent();
        }
        public int burgerprice = 0;

        private void chbBig_CheckedChanged(object sender, EventArgs e)
        {
            int big = int.Parse(chbBig.Text);
            if (chbBig.Checked)
            {
                burgerprice += big;
            }
            else
                burgerprice -= big;
        }

        private void chbSang_CheckedChanged(object sender, EventArgs e)
        {
            int sang = int.Parse(chbSang.Text);
            if (chbSang.Checked)
            {
                burgerprice += sang;
            }
            else
                burgerprice -= sang;
        }

        private void chb1955_CheckedChanged(object sender, EventArgs e)
        {
            int s1955 = int.Parse(chb1955.Text);
            if (chb1955.Checked)
            {
                burgerprice += s1955;
            }
            else
                burgerprice -= s1955;
        }

        private void btnpriceburger_Click(object sender, EventArgs e)
        {
            textBurger.Text = burgerprice.ToString();
        }

        public void setBurgerprice(int burgerprice)
        {
            this.textBurger.Text = burgerprice.ToString();
        }

        public int getBurgerprice()
        {
            return burgerprice;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string menuName = "";
            int menuPrice = 0;

            if (chbBig.Checked) { menuName = "빅맥"; menuPrice = 5000; }
            else if (chbSang.Checked) { menuName = "상하이스파이스 버거"; menuPrice = 5500; }
            else if (chb1955.Checked) { menuName = "1955버거"; menuPrice = 6000; }

            // 2. 메인 폼(Owner)이 살아있는지 확인하고 딱 한 번만 보냅니다.
            if (this.Owner is Form1 mainForm)
            {
                // 아까 Form1에 만든 AddToOrder 함수를 호출합니다.
                mainForm.AddToOrder(menuName, menuPrice);
            }

            setBurgerprice(burgerprice);
            this.Hide();
        }
    }
}
