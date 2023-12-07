using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Report report2 = new Report();
            report2.Show();
            this.Hide();
        }
    }
}
