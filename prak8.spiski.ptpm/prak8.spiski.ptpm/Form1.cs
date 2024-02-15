using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prak8.spiski.ptpm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.ForeColor = Color.Green;
                    break;
                case 1:
                    textBox1.ForeColor = Color.Gold;
                    break;
                case 2:
                    textBox1.ForeColor = Color.DarkSalmon;
                    break;



            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    textBox1.BackColor = Color.BlanchedAlmond;
                    break;
                case 1: textBox1.BackColor = Color.Black; break;
                case 2: textBox1.BackColor = Color.BlueViolet; break;
            }
        }

        public enum Светофор {Красный, желтый, зеленый }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"C:\\Users\\st325l02\\Desktop\\redkin pr-23\\prak8.spiski.ptpm\zima.jpeg");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\st325l02\Desktop\redkin pr-23\prak8.spiski.ptpm\vesna.jfif");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\st325l02\Desktop\redkin pr-23\prak8.spiski.ptpm\leto.jpeg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\st325l02\Desktop\redkin pr-23\prak8.spiski.ptpm\osen.jpg");
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Светофор signal = (Светофор)comboBox3.SelectedIndex;

            switch (signal)
            {
                case Светофор.Красный:
                    label3.Text = "Красный! Стойте!";
                    label3.BackColor = Color.Red;
                    break;
                case Светофор.желтый:
                    label3.Text = "Ожидайте! Желтый!";
                    label3.BackColor = Color.Yellow;
                    break;
                case Светофор.зеленый:
                    label3.Text = "Можешь идти! Зеленый!";
                    label3.BackColor = Color.Green;
                    break;
                default:
                    MessageBox.Show ("Светофор поломан пока");
                    break;


            }
        }

        public enum Радуга { красный, оранжевый, жёлтый, зелёный, голубой, синий, фиолетовый }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Радуга radyga = (Радуга)comboBox4.SelectedIndex;

            switch (radyga)
            {
                case Радуга.красный:
                    label4.Text = "Красный";
                    label4.BackColor = Color.Red;
                    break;
                case Радуга.оранжевый:
                    label4.Text = "Оранжевый";
                    label4.BackColor = Color.Orange;
                    break;
                case Радуга.жёлтый:
                    label4.Text = "Желтый";
                    label4.BackColor = Color.Yellow;
                    break;
                case Радуга.зелёный:
                    label4.Text = "Зеленый";
                    label4.BackColor = Color.Green;
                    break;
                case Радуга.голубой:
                    label4.Text = "Голубой";
                    label4.BackColor = Color.LightBlue;
                    break;
                case Радуга.синий:
                    label4.Text = "Синий";
                    label4.BackColor = Color.Blue;
                    break;
                case Радуга.фиолетовый:
                    label4.Text = "Фиолетовый";
                    label4.BackColor = Color.Purple;
                    break;
                default:
                    MessageBox.Show("Пока пока");
                    break;
                
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox2.Text);
            int d = Convert.ToInt32(textBox3.Text);

            try
            {
                if (d > 31 || m <= 0)
                {
                    MessageBox.Show("Неверное значение");

                }
                else 
                {
                    if (m > 12)
                }
            
            
            }
            catch 
            { 
            
            }
        }
    }

    
}


    
