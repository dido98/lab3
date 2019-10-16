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
    public partial class Form9 : Form
    {
        Random ran = new Random();
        int num = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            num = ran.Next(99) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int g = int.Parse(textBox1.Text);

            if (g < num)
                MessageBox.Show("Chisloto trqbva da e po-golqmo");

            if (g > num)
                MessageBox.Show("Chisloto trqbva da e po-malko");
            
            if (g == num)
                MessageBox.Show("BRAVO! Poznahte chisloto!");
        }
    }
}
