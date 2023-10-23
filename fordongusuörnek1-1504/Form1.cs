using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fordongusuörnek1_1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            +
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string ad = txtad.Text;

            for (int i = 0; i<10; i++)
            {
                string metin = i.ToString() +"-" + ad;
        }
            { 
    }
}
