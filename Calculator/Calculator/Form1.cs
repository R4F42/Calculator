using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string n;
        public double a1 = 8, b;
        public Form1()
        {
            
            InitializeComponent();
        }
        private void saveN()
        {
            n = lblOut.Text;
            lblOut.Text = "";
            lblBef.Text = n;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                b = 0;
            }
            lblOut.Text += '0';
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            double a = double.Parse(lblBef.Text);
            double c = double.Parse(lblOut.Text);
           
            if (a1 == 0){
                
                lblOut.Text = (a + c).ToString();
                lblBef.Text = "";
            }
            else if(a1 == 1)
            {
                
                lblOut.Text = (a - c).ToString();
                lblBef.Text = "";
            }
            else if (a1 == 2)
            {
               
                lblOut.Text = (a / c).ToString();
                lblBef.Text = "";
            }
            else if (a1 == 3)
            {
                
                lblOut.Text = (a * c).ToString();
                lblBef.Text = "";
            }
            else if (a1 == 4)
            {
                
                lblOut.Text = (a % c).ToString();
                lblBef.Text = "";
            }
            else
            {
                lblBef.Text = lblOut.Text;
                lblOut.Text = "";
                
            }
            b = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            saveN();
            a1 = 0;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            saveN();
            a1 = 1;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            saveN();
            a1 = 2;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            saveN();
            a1 = 4;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double a = double.Parse(lblOut.Text);
            lblOut.Text = (a / 100).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            saveN();
            a1 = 3;
        }
    }
}
