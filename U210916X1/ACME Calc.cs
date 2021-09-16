using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace U210916X1
{
    public partial class ACME_Calc : Form
    {
        public ACME_Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{double.Parse(textBox1.Text)} + {double.Parse(textBox2.Text)} = {double.Parse(textBox1.Text) + double.Parse(textBox2.Text)}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{double.Parse(textBox1.Text)} - {double.Parse(textBox2.Text)} = {double.Parse(textBox1.Text) - double.Parse(textBox2.Text)}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{double.Parse(textBox1.Text)} * {double.Parse(textBox2.Text)} = {double.Parse(textBox1.Text) * double.Parse(textBox2.Text)}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{double.Parse(textBox1.Text)} / {double.Parse(textBox2.Text)} = {double.Parse(textBox1.Text) / double.Parse(textBox2.Text)}");
        }
    }
}
