using Food_Mood.Classes;
using System;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Food_Mood
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            UserManager.CurrentUser = myUser;
            if (myUser != null)
            {
                return myUser.Password == password;
            }
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount formAccount = new NewAccount();
            formAccount.Show();
            this.Hide();
        }
    }
}
