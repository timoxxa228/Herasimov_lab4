using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            if (string.IsNullOrEmpty(textBox1.Text))
                richTextBox1.AppendText("Element1: Porozhno\n");
            else
                richTextBox1.AppendText("Element1: " + textBox1.Text + '\n');
            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Element2: Porozhno\n");
            else
                richTextBox1.AppendText("Element2: " + textBox2.Text + '\n');
            if (string.IsNullOrEmpty(textBox3.Text))
                richTextBox1.AppendText("Element3: Porozhno\n");
            else
                richTextBox1.AppendText("Element3: " + textBox3.Text + '\n');
            if (string.IsNullOrEmpty(textBox4.Text))
                richTextBox1.AppendText("Element4: Porozhno\n");
            else
                richTextBox1.AppendText("Element4: " + textBox4.Text + '\n');
            if (string.IsNullOrEmpty(textBox5.Text))
                richTextBox1.AppendText("Element5: Porozhno\n");
            else
                richTextBox1.AppendText("Element5: " + textBox5.Text + '\n');
        }
    }
}
