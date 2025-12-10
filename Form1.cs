using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaliczeniowka
{
    public partial class Form1 : Form
    {
        private List<Class1> prezenty = new List<Class1>();

        public Form1()
        {
            InitializeComponent();
        }
        private void OdświeżWidok()
        {
            listBox1.Items.Clear();

            foreach (var p in prezenty)
            {
                listBox1.Items.Add(p.ToString());
            }

            label1.Text = "Ilość: " + prezenty.Count;
            label2.Text = "Łączny koszt: " + prezenty.Sum(p => p.Cena) + " zł";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwa = textBox2.Text;

            if (!decimal.TryParse(textBox3.Text, out decimal cena))
            {
                MessageBox.Show("Podaj poprawną cenę.");
                return;
            }
            prezenty.Add(new Class1(textBox1.Text, textBox2.Text, cena));
            OdświeżWidok();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
