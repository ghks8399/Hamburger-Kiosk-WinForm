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
    public partial class Form2Side : Form
    {
        public Form2Side()
        {
            InitializeComponent();
        }
        public int priceSide = 0;

        private void chbMacwing_CheckedChanged(object sender, EventArgs e)
        {
            int macw = int.Parse(chbMacwing.Text);
            if (chbMacwing.Checked)
            {
                priceSide += macw;
            }
            else
            {
                priceSide -= macw;
            }
        }

        private void chbTotato_CheckedChanged(object sender, EventArgs e)
        {
            int to = int.Parse(chbTotato.Text);
            if (chbTotato.Checked)
            {
                priceSide += to;
            }
            else
            {
                priceSide -= to;
            }
        }

        private void chbSnack_CheckedChanged(object sender, EventArgs e)
        {
            int snab = int.Parse(chbSnack.Text);
            if (chbSnack.Checked)
            {
                priceSide += snab;
            }
            else
            {
                priceSide -= snab;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textSide.Text = priceSide.ToString();
        }

        public void setSideprice(int priceSide)
        {
            this.textSide.Text = priceSide.ToString();
        }

        public int getSideprice()
        {
            return priceSide;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string menuName = "";
            int menuPrice = 0;

            if (chbMacwing.Checked) { menuName = "맥윙"; menuPrice = 4000; }
            else if (chbTotato.Checked) { menuName = "감자튀김"; menuPrice = 1400; }
            else if (chbSnack.Checked) { menuName = "스낵랩"; menuPrice = 3000; }

            if (this.Owner is Form1 mainForm)
            {
                mainForm.AddToOrder(menuName, menuPrice);
            }

            setSideprice(priceSide);
            this.Hide();
        }
    }
}
