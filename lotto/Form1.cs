using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 5-ös lottó: 5 db nyerőszám, számok 1-90ig
             */
            listBox1.Items.Clear();

            int[] nyeroszamok = new int[5];
            Random veletlen = new Random();

            for (int i = 0; i < nyeroszamok.Length; i++)
            {
                int ujSzam = veletlen.Next(1, 91);
                if (nyeroszamok.Contains(ujSzam))
                {
                    i--;
                }
                else
                {
                    nyeroszamok[i] = ujSzam;
                }
            }

            listBox1.Items.Add("Az ötös lottó nyerőszámai:");
            for (int i = 0; i < nyeroszamok.Length; i++)
            {
                listBox1.Items.Add(nyeroszamok[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
