using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikdortgensiniftanimlama
{

    public partial class Form1 : Form
    {
        class Dikdortgen
        {
            private int a, b;
            public Dikdortgen(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public int AlanHesapla()
            {
                return a * b;
            }
            public int CevreHesapla()
            {
                return 2 * (a + b);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
