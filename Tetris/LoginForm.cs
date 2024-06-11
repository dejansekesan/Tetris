using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = textBox1.Text.Trim();
                string prezime = textBox2.Text.Trim();
                if (ime.Any(char.IsDigit) || prezime.Any(char.IsDigit) || ime == "" || prezime == "")
                {
                    MessageBox.Show("Unesite podatke kako treba");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    
                    string personal = ime + " " + prezime;
                    textBox1.Clear();
                    textBox2.Clear();
                    MainWindow aboutForm = new MainWindow(personal);
                    aboutForm.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Unesite podatke kako treba");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                          Char.IsSeparator(e.KeyChar) ||
                          Char.IsSymbol(e.KeyChar) ||
                          Char.IsDigit(e.KeyChar) ||
                          Char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                          Char.IsSeparator(e.KeyChar) ||
                          Char.IsSymbol(e.KeyChar) ||
                          Char.IsDigit(e.KeyChar) ||
                          Char.IsWhiteSpace(e.KeyChar);

        }
    }
}
