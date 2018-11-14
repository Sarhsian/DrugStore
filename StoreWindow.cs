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
    public partial class StoreWindow : Form
    {
        private List<BasketClass> basketinfo;
        private Basket basketWindow;
        int TotalSum;
     
        public StoreWindow()
        {
            InitializeComponent();
            basketinfo = new List<BasketClass>();
            basketWindow = new Basket();
        }

        private void CheckerIsNum(TextBox text)
        {
            string pattern1 = @"[0-9]{1,5}$";
            if (Regex.IsMatch(text.Text, pattern1) || text.Text == String.Empty)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(text, "1-9, max = 99999");
            }
        }

        private void ClearAll()
        {
           
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox1);   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox5);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox6);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox7);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox8);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox9);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox10);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox11);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox12);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox13);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckerIsNum(textBox2);
        }

        private void AddProductToBasket(Label DrugsName1, Label DrugsPrice1, TextBox DrugsGramms1)
        {
            if (DrugsGramms1.Text != String.Empty)
            {
                BasketClass basketTemp = new BasketClass();
                basketTemp.DrugsName = DrugsName1.Text;
                basketTemp.DrugsPrice = DrugsPrice1.Text;
                basketTemp.DrugsGramms = DrugsGramms1.Text;
                basketinfo.Add(basketTemp);
                basketTemp = null;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (basketinfo == null)
            {
                basketinfo = new List<BasketClass>();
            }
            else
            {
                AddProductToBasket(metroLabel1, metroLabel3, textBox1);
                AddProductToBasket(metroLabel5, metroLabel8, textBox2);
                AddProductToBasket(metroLabel18, metroLabel17, textBox3);
                AddProductToBasket(metroLabel24, metroLabel23, textBox4);
                AddProductToBasket(metroLabel60, metroLabel59, textBox10);
                AddProductToBasket(metroLabel66, metroLabel65, textBox11);
                AddProductToBasket(metroLabel72, metroLabel71, textBox12);
                AddProductToBasket(metroLabel78, metroLabel77, textBox13);
                AddProductToBasket(metroLabel30, metroLabel29, textBox5);
                AddProductToBasket(metroLabel36, metroLabel35, textBox6);
                AddProductToBasket(metroLabel42, metroLabel41, textBox7);
                AddProductToBasket(metroLabel48, metroLabel47, textBox8);
                AddProductToBasket(metroLabel54, metroLabel53, textBox9);
                AddProductToBasket(metroLabel84, metroLabel83, textBox14);
                AddProductToBasket(metroLabel90, metroLabel89, textBox15);
                AddProductToBasket(metroLabel96, metroLabel95, textBox16);

                for (int i = 0; i < basketinfo.Count; i++)
                {
                    TotalSum += Int32.Parse(basketinfo[i].DrugsPrice) * Int32.Parse(basketinfo[i].DrugsGramms);
                }
            }
            ClearAll();
            MessageBox.Show("Products added to basket!");
        }

        private void ClearBasket()
        {
            basketWindow.richTextBox1.Clear();
            basketWindow.textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearBasket();
            basketWindow.textBox2.Text = TotalSum.ToString();

            for (int i = 0; i < basketinfo.Count; i++)
            {
                basketWindow.richTextBox1.Text += basketinfo[i].DrugsName + " (" + basketinfo[i].DrugsPrice + "$ for 1 gramm) "
                    + basketinfo[i].DrugsGramms + " Gramms\n";
            }
            basketinfo.Clear();
            basketWindow.ShowDialog();
        }
           
        

       
    }
}
