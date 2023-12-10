using Food_Mood.Classes;
using System;
using System.Windows.Forms;

namespace Food_Mood
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var name = textBoxNAName.Text;
            var pass = textBoxNAPassword.Text;
            var email = textBoxNAEmail.Text;
            UserManager.addUser(new User(name, pass, email));
            UserManager.saveUsers();
            Report report2 = new Report();
            report2.Show();
            this.Hide();
        }
    }
}
