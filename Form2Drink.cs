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
    public partial class Form2Drink : Form
    {
        public Form2Drink()
        {
            InitializeComponent();
        }
        string strOrder = "";
        private void btnchoicedrink_Click(object sender, EventArgs e)
        {
            if (RBcoke.Checked == true)
                strOrder += RBcoke.Text + "\n";
            else if (RBicetea.Checked == true)
                strOrder += RBicetea.Text + "\n";
            else if (RBcider.Checked == true)
                strOrder += RBcider.Text + "\n";
            else
                MessageBox.Show("음료를 선택해주세요.");
            textDrink.Text = strOrder.ToString();
        }
        public void setDrinkprice(string strOrder)
        {
            this.textDrink.Text = strOrder.ToString();
        }

        public string getDrinkprice()
        {
            return strOrder;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string menuName = "";
            int menuPrice = 0;

            if (RBcoke.Checked) { menuName = "코카콜라"; menuPrice = 2000; }
            else if (RBicetea.Checked) { menuName = "아이스티"; menuPrice = 3000; }
            else if (RBcider.Checked) { menuName = "사이다"; menuPrice = 2000; }

            if (this.Owner is Form1 mainForm)
            {
                mainForm.AddToOrder(menuName, menuPrice);
            }
            setDrinkprice(strOrder);
            this.Hide();
        }
    }
}
