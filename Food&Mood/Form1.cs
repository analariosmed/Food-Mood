using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Food_Mood
{
    public partial class Form1 : Form
    {
       string User = "1";
       string Password = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (isValidMember())
            {
                Report ReportForm = new Report();
                ReportForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is not correct");
            }
        }

        private bool isValidMember()
        {
            if (User == textBoxUser.Text && Password == textBoxPassword.Text)
            {
                return true;
            }
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount  formAccount= new NewAccount();
            formAccount.Show();
            this.Hide();

           
        }
    }
}
