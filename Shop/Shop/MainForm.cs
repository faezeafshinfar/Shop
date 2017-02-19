using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEngilishTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersianTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtProducter_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFullExpalin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShortExplain_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuyer_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Calculator_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Squere")
            {
                Squere sqr = new Shop.Squere(Int32.Parse(this.InputWidth.Text), Int32.Parse(this.InputHeight.Text));
                this.CalDisplay.Items.Add(sqr.Area().ToString());
            }
            else if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                Rectangle rec = new Shop.Rectangle(Int32.Parse(this.InputWidth.Text), Int32.Parse(this.InputHeight.Text));
                this.CalDisplay.Items.Add(rec.Area().ToString());
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inputmohit_Click(object sender, EventArgs e)
        {
             if (comboBox1.SelectedItem.ToString() == "Squere")
            {
                Squere sqr = new Shop.Squere(Int32.Parse(this.InputWidth.Text), Int32.Parse(this.InputHeight.Text));
                this.CalDisplay.Items.Add(sqr.Mohit().ToString());
            }
            else if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                Rectangle rec = new Shop.Rectangle(Int32.Parse(this.InputWidth.Text), Int32.Parse(this.InputHeight.Text));
                this.CalDisplay.Items.Add(rec.Mohit().ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

          

            if (comboBox1.SelectedItem.ToString() == "Squere")
            {
                Squere sqr = new Shop.Squere(Int32.Parse(this.InputWidth.Text), Int32.Parse(this.InputHeight.Text));
                this.CalDisplay.Items.Add(sqr.Ghotr().ToString());
            }
            else if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                Rectangle rec = new Shop.Rectangle(Int32.Parse(this.InputWidth.Text), Int32.Parse(this.InputHeight.Text));
                this.CalDisplay.Items.Add(rec.Ghotr().ToString());
            }
        }
    }
}
