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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int curr_year = DateTime.Today.Year;
            int curr_month = DateTime.Today.Month;
            int curr_day = DateTime.Today.Day;

            int day = int.Parse(textBox1.Text);
            int month = int.Parse(textBox2.Text);
            int year = int.Parse(textBox3.Text);

            DateTime dt = new DateTime(year, month, day);
            TimeSpan span = DateTime.Today.Subtract(dt);
            DateTime diff = new DateTime(0) + span;

            MessageBox.Show(String.Format("{0} days, {1} months, {2} years", diff.Day, diff.Month, diff.Year));
        }
    }
}
