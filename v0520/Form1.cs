using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0520
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Top = label3.Top - 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Left = label3.Left - 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Left = label3.Left + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Top = label3.Top + 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");

            MessageBox.Show(100.ToString());
            MessageBox.Show("" + 100);
            MessageBox.Show($"{100}");

            MessageBox.Show(3.14f.ToString());
            MessageBox.Show("" + 3.14f);
            MessageBox.Show($"{3.14f}");

            MessageBox.Show((1 + 1).ToString());
            MessageBox.Show("" + (1 + 1));
            MessageBox.Show($"{1 + 1}");

            MessageBox.Show((1.23f * 1.23).ToString());
            MessageBox.Show("" + (1.23f * 1.23f));
            MessageBox.Show($"{1.23f * 1.23f}");

            MessageBox.Show("1+1");
            MessageBox.Show("1" + "1");
        }
    }
}
