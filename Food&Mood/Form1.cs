using Food_Mood.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MessageBox = System.Windows.MessageBox;

namespace Food_Mood
{
    public partial class Form1 : Form
    {
        string User = "1";
        string Password = "1234";

        
        public Form1()
        {
            InitializeComponent();
            UserManager.loadUsers();
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
            var user = textBoxUser.Text;
            var password = textBoxPassword.Text;
            var myUser = UserManager.Users.Find(x => x.Name == user);
            if (myUser != null)
            {
                return myUser.Password == password;
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
