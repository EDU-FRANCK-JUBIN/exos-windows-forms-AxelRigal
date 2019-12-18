using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculatrice : Form
    {
        DataTable dt = new DataTable();

        public Calculatrice()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            tb1.Text += "+";
        }


        private void btLess_Click(object sender, EventArgs e)
        {
            tb1.Text += "-";
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            tb1.Text += "*";
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            tb1.Text += "/";
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text.Remove(tb1.Text.Length - 1);
        }

        private void btC_Click(object sender, EventArgs e)
        {

        }

        private void btCE_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            tb1.Text += "0";
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            tb1.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tb1.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tb1.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tb1.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tb1.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tb1.Text += "6";

        }
        private void bt7_Click(object sender, EventArgs e)
        {
            tb1.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tb1.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tb1.Text += "9";
        }

        private void btDot_Click(object sender, EventArgs e)
        {
           
            if (getLastNumber(tb1.Text).Contains(","))
                MessageBox.Show("Number got already a dot");
            else
                tb1.Text += ",";
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
         try
            {
                var v = dt.Compute(tb1.Text, "");
                tb1.Text += "=";
                tb2.Text = v.ToString();
            }
            catch(System.DivideByZeroException)
            {
                MessageBox.Show("Erreur divisé par zéro ");
            }

        }

        private string getLastNumber(string chaine)
        {
            Char[] separator = { '+' , '*', '-', '/'};
            String[] strlist = chaine.Split(separator);
            return strlist[strlist.Length-1];
        }
    }
}
