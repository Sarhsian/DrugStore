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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private StoreWindow storeWindow;
        private Regestration regestration;
        private List<PeopleInfo> peopleInfos;
        public Form1()
        {
            InitializeComponent();
            storeWindow = new StoreWindow();
            regestration = new Regestration();
            peopleInfos = new List<PeopleInfo>();
            if(regestration.Person != null)
            {
                peopleInfos.Add(regestration.Person);
            }
            
        }
        private void ClearTextBoxes()
        {
            metroTextBox1.Text = String.Empty;
            metroTextBox2.Text = String.Empty;            
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            regestration.ShowDialog();
            ClearTextBoxes();
        }
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            var login = metroTextBox1.Text;
            var password = metroTextBox2.Text;
            if (login == "Admin" && password == "qwerty")
            {
                reg regWindow = new reg();
                regWindow.ShowDialog();
            }
            for (int i = 0; i < peopleInfos.Count; i++)
            {
                if (login == peopleInfos[i].Login && password == peopleInfos[i].Password)
                {
                    storeWindow.ShowDialog();
                    this.Close();
                }
            }
            if (metroTextBox1.Text != String.Empty && metroTextBox2.Text != String.Empty)
            {
                errorProvider1.SetError(metroTextBox1, "Wrong login or password!");
            }else
            {
                errorProvider1.SetError(metroTextBox1, "Text box is empty!");

            }

        }
    }
}
