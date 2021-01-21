using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int station = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (station == 0)
            {
                button2.Visible = false;
                textBox1.Visible = false;
                station = 1;
            }
            else
            {
                button2.Visible = true;
                textBox1.Visible = true;
                station = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            button2.Visible = false;
            textBox1.Visible = false;
            station = 1;
        }
    }
}
