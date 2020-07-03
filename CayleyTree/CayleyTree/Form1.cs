using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double th1 = 30 * Math.PI / 180;
        public static double th2 = 20 * Math.PI / 180;
        public static double per1 = 0.6;
        public static double per2 = 0.7;
        public static double k = 1.0;
        public static Pen pen = Pens.Blue;

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text))
                per1 = Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox2.Text))
                per2 = Convert.ToDouble(textBox2.Text); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox3.Text))
                th1 = Convert.ToDouble(textBox3.Text) * Math.PI / 180;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox4.Text))
                th2 = Convert.ToDouble(textBox4.Text) * Math.PI / 180;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            per1 = rnd.NextDouble();
            per2 = rnd.NextDouble();
            th1 = rnd.Next(10, 80) * Math.PI / 180;
            th2 = rnd.Next(10, 80) * Math.PI / 180;
            switch(rnd.Next(6))
            {
                case 0: pen = Pens.Red; break;
                case 1: pen = Pens.Green; break;
                case 2: pen = Pens.Blue; break;
                case 3: pen = Pens.Yellow; break;
                case 4: pen = Pens.Purple; break;
                default: pen = Pens.Gold; break;
            }
            new Form2().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            k = Convert.ToDouble(comboBox1.SelectedItem);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '.')
                e.Handled = false;
            else
            {
                MessageBox.Show("Only numbers allowed!");
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '.')
                e.Handled = false;
            else
            {
                MessageBox.Show("Only numbers allowed!");
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '.')
                e.Handled = false;
            else
            {
                MessageBox.Show("Only numbers allowed!");
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '.')
                e.Handled = false;
            else
            {
                MessageBox.Show("Only numbers allowed!");
                e.Handled = true;
            }
        }
    }
}
