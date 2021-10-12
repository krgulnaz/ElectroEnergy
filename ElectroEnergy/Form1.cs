using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroEnergy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void prevTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (prevTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13)){
                this.currentTextBox.Focus();
            }
        }

        private void currentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (currentTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
            {
                this.priceTextBox.Focus();
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (priceTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
            {
                this.countButton.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.prevTextBox.Focus();
            this.countButton.Enabled = false;
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            try
            {
                float prev = Convert.ToSingle(this.prevTextBox.Text);
                float curr = Convert.ToSingle(this.currentTextBox.Text);
                float price = Convert.ToSingle(this.priceTextBox.Text);
                if (prev =< curr)
                {
                    this.resultLabel.Text = "You have to pay: "+((curr - prev) * price).ToString();
                }
                else
                {
                    MessageBox.Show("Error in the filling the forms " + "current is less than prev ", "ElectroEnergy", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            catch
            {
                MessageBox.Show("Error", "ElectroEnergy", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void priceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.prevTextBox.Text.Length > 0 && this.currentTextBox.Text.Length > 0 && this.priceTextBox.Text.Length > 0)
            {
                this.countButton.Enabled = true;
            }
            else
            {
                this.countButton.Enabled = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.currentTextBox.Text = "";
            this.prevTextBox.Text = "";
            this.priceTextBox.Text = "";
        }
    }
}
