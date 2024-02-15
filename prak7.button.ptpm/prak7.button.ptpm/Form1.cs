using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prak7.button.ptpm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 1";
            textBox1.ForeColor = System.Drawing.Color.Red;
            button3.BackColor = Color.PowderBlue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 2";
            textBox1.ForeColor = System.Drawing.Color.Aqua;
            button6.BackColor = Color.SeaGreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Gold;
            button5.BackColor = Color.Salmon;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 4";
            textBox1.ForeColor = System.Drawing.Color.Purple;
            button4.BackColor = Color.Sienna;
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "Текст выведен на кнопку";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button11.Visible = true;
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            button13.Top = rnd.Next(0, 200);
            button13.Left = rnd.Next(0,200);
            
        }
    }
}
