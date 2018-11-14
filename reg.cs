using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStoreWF
{
    public partial class reg : Form
    {
        public Client Client { get; set; } = new Client();
        public Client2 Client2 { get; set; } = new Client2();
        public reg()
        {
            InitializeComponent();
            //dataGridView1.DataSource = Client;
            dataGridView1.DataSource = Client2;
        }

        public reg(string log, string pass)
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Client2.Add(new Client
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                Login = textBox3.Text,
                Password = textBox4.Text,
                User = "User"
            });


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Client2;
        }       
    }
}

