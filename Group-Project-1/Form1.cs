//Stephanie Hamilton
//Michael McDonough
//Seth Vassey
//Robert Zheng


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkCreateAcct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAcct AcctForm = new CreateAcct();
            AcctForm.ShowDialog();
            
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword ForgotForm = new ForgotPassword();
            ForgotForm.ShowDialog();
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataForm SportsData = new DataForm();
            SportsData.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //List<Form> formstoClose = new List<Form>();
            //foreach (Form forms in Application.OpenForms)
            //{
            //    if (forms.Name != "Form1")
            //    {
            //        formstoClose.Add(forms);
            //    }
            //}

            //foreach (Form forms in formstoClose)
            //{ 
            //    forms.Close();
            //}

            this.Close();

        }
    }
}
