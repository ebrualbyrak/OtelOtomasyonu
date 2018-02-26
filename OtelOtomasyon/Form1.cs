using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sagKaymaHizi = 10;//hızını ayarlayabilirsin
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (pb5.Left == 156)
            {
                pb4.Left = 0;
            }
            if (pb4.Left == 156)
            {
                pb3.Left = 0;
            }
            if (pb3.Left == 156)
            {
                pb2.Left = 0;
            }
            if (pb2.Left == 156)
            {
                pb1.Left = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb5.Left += 6;
            pb4.Left += 6;
            pb3.Left += 6;
            pb2.Left += 6;
            pb1.Left += 6;


            if (pb5.Left > 564)
            {
                pb5.Left = 0;
            }
            if (pb4.Left > 564)
            {
                pb4.Left = 0;
            }
            if (pb3.Left > 564)
            {
                pb3.Left = 0;
            }
            if (pb2.Left > 564)
            {
                pb2.Left = 0;
            }
            if (pb1.Left > 564)
            {
                pb1.Left = 0;
            }
        }
    }
}
