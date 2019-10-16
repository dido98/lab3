using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
              1  (a+b)2 
              2  (a-b)2
              3  (a+b)*(a-b)
              4  (a+b)3 
              5  (a-b)3 
              6  a3-b3 
              7  a3+b3 
            */

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            string strRes = "0";

            if (radioButton1.Checked == true)
            {
                strRes = String.Format("{0}", Math.Pow((a + b), 2));
            }

            if (radioButton2.Checked == true)
            {
                strRes = String.Format("{0}", Math.Pow((a - b), 2));
            }

            if (radioButton3.Checked == true)
            {
                strRes = String.Format("{0}", (a + b) * (a - b));
            }

            if (radioButton4.Checked == true)
            {
                strRes = String.Format("{0}", Math.Pow((a + b), 3));
            }

            if (radioButton5.Checked == true)
            {
                strRes = String.Format("{0}", Math.Pow((a - b), 3));
            }

            if (radioButton6.Checked == true)
            {
                strRes = String.Format("{0}", a * a * a + b * b * b);
            }
            if (radioButton7.Checked == true)
            {
                strRes = String.Format("{0}", a * a * a - b * b * b);
            }

            textBox3.Text = strRes;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "1";
            textBox3.Text = "0";
        }
    }
}
