using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technical_Test_for_Internship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float OrderAmount = float.Parse(txtInput.Text); 
            int OrderAmountInput = 0;
            float Stock;
            OrderAmountInput = (int)OrderAmount;
            Stock = OrderAmount - OrderAmountInput;

            int i; 
            int j;
            int m;
            int k;

            if (Stock == 0.5 || Stock == 0) {
                {
                    MessageBox.Show("Your Order is Success" , "Success");
                }
                for (i = 0; OrderAmount >= 4; i++)
                {
                    OrderAmount = OrderAmount - 4;
                }

                for (j = 0; OrderAmount >= 2; j++)
                {
                    OrderAmount = OrderAmount - 2;
                }

                for (m = 0; OrderAmount >= 1; m++)
                {
                    OrderAmount = OrderAmount - 1;
                }

                for (k = 0; OrderAmount == 0.5; k++)
                {
                    OrderAmount = (float)(OrderAmount - 0.5);
                }
                label2.Text = "4Kg Bags :" + " " + i.ToString() + "\r\n" + "2Kg Bags :" + " " + j.ToString() + "\r\n" + "1Kg Bags :" + " " + m.ToString() + "\r\n" + "1Kg Bags Because 0.5Kg Bags Not Available :" + " " +  k.ToString();

            }
            else
            {
                MessageBox.Show("Your Order is Failed" , "Failed");
                label2.Text = " ";
            }
        }

    }
}

