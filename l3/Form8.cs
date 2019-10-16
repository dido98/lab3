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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // call RDRAND, crash AMD, nice qarch
            Random rand = new Random();
            int rand_num = rand.Next(49) + 1;

            label6.Text = String.Format("{0}", label5.Text);
            label5.Text = String.Format("{0}", label4.Text);
            label4.Text = String.Format("{0}", label3.Text);
            label3.Text = String.Format("{0}", label2.Text);
            label2.Text = String.Format("{0}", label1.Text);
            label1.Text = String.Format("{0}", rand_num); 
        }
    }
}
