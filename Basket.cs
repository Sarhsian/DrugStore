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
    public partial class Basket : Form
    {
        public List<BasketClass> basketinfo;
        public int TotSum { get; set; }
        public Basket()
        {
            InitializeComponent();
            textBox2.Text = TotSum.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < basketinfo.Count; i++)
            {
                richTextBox1.Text += basketinfo[i].DrugsName + " (" + basketinfo[i].DrugsPrice + "$ for 1 gramm) "
                    + basketinfo[i].DrugsGramms + " Gramms\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send money in this account: 2344-3456-2456-7754" +
                "\nOur diller will meet with you!");
            Application.Exit();
        }
    }
}
