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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int days = 31;

            int y = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);

            bool leap = false;

            if (y % 4 == 0)
                leap = true;
            
            if(m == 2)
                days = (leap == true) ? 29 : 28;

            if (m == 4 || m == 6 || m == 9 || m == 11)
                days = 30;

            MessageBox.Show(String.Format("Godinata {0}, a mesec {1} ima {2} dni", (leap ? "e Visokosna" : "NE e Visokosna"), m, days));
        }
    }
}
