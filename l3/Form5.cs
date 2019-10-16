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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            /*
                Преди 1960 година:  pDDO = 0.089 и pDZPO = 0
                След 1960 година:  pDDO = 0.067 и pDZPO = 0.022

                ДОО = pDDO * Заплата
                ДЗПО = pDZPO * Заплата
                Здравни осигуровки = 0.032 * Заплата
                Общо = ДОО + ДЗПО + Здравни осигуровки
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int zaplata = int.Parse(textBox1.Text);

                double pdoo = 0.089;
                double pdzpo = 0;

                if(radioButton2.Checked == true)
                {
                    pdoo = 0.067;
                    pdzpo = 0.022;
                }

                label3.Text = String.Format("DOO: {0:0.00} lv.", (zaplata * pdoo));
                label4.Text = String.Format("DZPO: {0:0.00} lv.", (zaplata * pdzpo));
                label5.Text = String.Format("ZDRAVNO: {0:0.00} lv.", (zaplata * 0.032));
                label6.Text = String.Format("OBSHTO: {0:0.00} lv.", zaplata * pdoo + zaplata * pdzpo + zaplata * 0.032);
            }
            catch(Exception)
            {
                ;
            }
        }
    }
}
