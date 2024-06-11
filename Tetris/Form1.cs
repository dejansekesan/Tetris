using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            DisplayData();
        }
        public List<Person> people = new List<Person>();
        public List<PersonNames> peoplenames = new List<PersonNames>();
        int i = 0, j = 214746890;
        private void constants()
        {
            int i = 0, j = 214746890;
            textBoxvise.Text = "";
            textBoxmanje.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            listBox1.Items.Clear();
            people.Clear();
            string[] lines = File.ReadAllLines("database.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                string firstname = parts[0];
                string lastname = parts[1];
                string name = parts[0] + " " + parts[1];
                int points = int.Parse(parts[2]);
                people.Add(new Person { Name = name, Points = points });
                peoplenames.Add(new PersonNames { Firstname = firstname, Lastname = lastname, Points = points });
            }
        }
        private void DisplayData()
        {
            listBox1.Items.Clear();
            // Sort by name in alphabetical order
            var sortedByName = people.OrderBy(p => p.Name).ToList();
            foreach (var person in sortedByName)
            {
                listBox1.Items.Add($"{person.Name} {person.Points}");
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public int Points { get; set; }
        }

        private void buttonshowall_Click(object sender, EventArgs e)
        {
            LoadData();
            constants();
            comboBox1.SelectedIndex = -1;
            textBoxsearch.Text = "";
            DisplayData();
            textBoxime.Clear();
            textBoxprezime.Clear();
            textBoxpoeni.Clear();
        }

        private void textBoxmanje_TextChanged(object sender, EventArgs e)
        {
            if (textBoxmanje.Text != "")
            {
                try
                {
                    j = Convert.ToInt32(textBoxmanje.Text);
                    comboBox1_SelectedIndexChanged(sender, e);
                }
                catch
                {
                    MessageBox.Show("Molim unesite broj");
                }
            }
            else
            {
                j = 214746890;
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }
        private void textBoxvise_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                      Char.IsSeparator(e.KeyChar) ||
                      Char.IsSymbol(e.KeyChar) ||
                          Char.IsWhiteSpace(e.KeyChar);
        }
        private void textBoxvise_TextChanged(object sender, EventArgs e)
        {

            if (textBoxvise.Text != "")
            {
                try
                {
                    i = Convert.ToInt32(textBoxvise.Text);
                    comboBox1_SelectedIndexChanged(sender, e);
                }

                catch
                {
                    MessageBox.Show("Molim unesite broj");
                }
            }
            else
            {
                i = 0;
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            string x = textBoxsearch.Text.ToUpper();
            var Person = peoplenames.ToList();
            foreach (var personname in Person)
            {
                if (personname.Firstname.ToUpper().StartsWith(x))
                {
                    listBox1.Items.Add($"{personname.Firstname} {personname.Lastname} {personname.Points}");
                }
                else if (personname.Lastname.ToUpper().StartsWith(x))
                {
                    listBox1.Items.Add($"{personname.Firstname} {personname.Lastname} {personname.Points}");
                }
                else if (Convert.ToString(personname.Points).StartsWith(x))
                {
                    listBox1.Items.Add($"{personname.Firstname} {personname.Lastname} {personname.Points}");
                }
            }
            if (textBoxsearch.Text == "")
            {
                DisplayData();
            }
        }

        private void textBoxime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxprezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpoeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonunesi_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = textBoxime.Text.Trim();
                string prezime = textBoxprezime.Text.Trim();
                string poeni = textBoxpoeni.Text.Trim();
                if (ime.Any(char.IsDigit) || prezime.Any(char.IsDigit) || ime == "" || prezime == "")
                {
                    MessageBox.Show("Unesite podatke kako treba");
                    textBoxime.Clear();
                    textBoxprezime.Clear();
                    textBoxpoeni.Clear();
                }
                else
                {
                    listBox1.Items.Clear();
                    string Person = ime + " " + prezime + " " + Convert.ToString(Convert.ToInt32(poeni));
                    StreamWriter PersonWriter = new StreamWriter("database.txt", true);
                    PersonWriter.WriteLine(Person);
                    PersonWriter.Close();
                    textBoxime.Clear();
                    textBoxprezime.Clear();
                    textBoxpoeni.Clear();

                    LoadData();
                    comboBox1_SelectedIndexChanged(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Unesite podatke kako treba");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                PointsMinMax();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                // Sort by name in alphabetical order
                var sortedByName = people.OrderBy(p => p.Name).ToList();
                listBox1.Items.Add("Sortirani po Imenu:");
                listBox1.Items.Add("");
                foreach (var person in sortedByName)
                {
                    if (person.Points >= i && person.Points < j)
                    {
                        listBox1.Items.Add($"{person.Name} {person.Points}");
                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                // Sort by points in descending order
                var sortedByPoints = people.OrderByDescending(p => p.Points).ToList();
                listBox1.Items.Add("Sortirani po Poenima:");
                listBox1.Items.Add("");
                foreach (var person in sortedByPoints)
                {
                    if (person.Points >= i && person.Points < j)
                    {
                        listBox1.Items.Add($"{person.Name} {person.Points}");
                    }
                }
            }
        }
        private void PointsMinMax()
        {
            listBox1.Items.Clear();
            var People = people.ToList();
            foreach (var person in People)
            {
                if (person.Points >= i && person.Points < j)
                {
                    listBox1.Items.Add($"{person.Name} {person.Points}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm aboutForm = new LoginForm();
            aboutForm.ShowDialog();
        }

        private void textBoxmanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                          Char.IsSeparator(e.KeyChar) ||
                          Char.IsSymbol(e.KeyChar) ||
                          Char.IsWhiteSpace(e.KeyChar);
        }

        private void textBoxsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                      Char.IsSeparator(e.KeyChar) ||
                      Char.IsSymbol(e.KeyChar) ||
                      Char.IsWhiteSpace(e.KeyChar);
        }

        private void textBoxime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                          Char.IsSeparator(e.KeyChar) ||
                          Char.IsSymbol(e.KeyChar) ||
                          Char.IsDigit(e.KeyChar) ||
                          Char.IsWhiteSpace(e.KeyChar);
        }

        private void textBoxprezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                          Char.IsSeparator(e.KeyChar) ||
                          Char.IsSymbol(e.KeyChar) ||
                          Char.IsDigit(e.KeyChar) ||
                          Char.IsWhiteSpace(e.KeyChar);
        }

        private void textBoxpoeni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                          Char.IsSeparator(e.KeyChar) ||
                          Char.IsSymbol(e.KeyChar) ||
                          Char.IsWhiteSpace(e.KeyChar);
        }

        public class PersonNames
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Points { get; set; }
        }
    }
}
