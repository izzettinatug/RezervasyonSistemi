using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçuş_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rotation: " + comboBox1.Text + " - " + comboBox2.Text );
            listBox1.Items.Add("Date: " + dateTimePicker1.Text + " - " + maskedTextBox1.Text);
            listBox1.Items.Add("Passenger Informations: " + textBox1 + " - ");
            listBox1.Items.Add("Identity Number: " + maskedTextBox2.Text);
            listBox1.Items.Add("Telephone Number: " + maskedTextBox3.Text);
            MessageBox.Show("Informations Saved ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
