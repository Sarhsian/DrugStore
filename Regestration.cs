using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStoreWF
{
    public partial class Regestration : Form
    {
        public PeopleInfo Person { get; set; } = new PeopleInfo();

        public Regestration()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string pattern = @"^\p{Lu}[a-z]{1,9}$";
            if (Regex.IsMatch(metroTextBox1.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(metroTextBox1, "Name shoud contain 1 big letter and minimum 2 letters!");
            }

            if (Regex.IsMatch(metroTextBox2.Text, pattern))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(metroTextBox2, "Surname shoud contain 1 big letter and minimum 2 letters!");
            }

            string pattern1 = @"[a-z,0-9,A-Z]{6,15}$";
            if (Regex.IsMatch(metroTextBox3.Text, pattern1))
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(metroTextBox3, "Login should contain minimum 6 symbols, maximum 15!");
            }

            if (Regex.IsMatch(metroTextBox4.Text, pattern1))
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(metroTextBox4, "Password should contain minimum 6 symbol, maximum 15!");
            }

           
                Person.Name = metroTextBox1.Text;
                Person.Surname = metroTextBox2.Text;
                Person.Login = metroTextBox3.Text;
                Person.Password = metroTextBox4.Text;
            if (metroComboBox1.Text == "Admin")
            {
                Person.IsAdmin = true;
                this.Close();
            }
            else if(metroComboBox1.Text == "User")
            {
                Person.IsAdmin = false;
                this.Close();
            }


        }
    }
}
