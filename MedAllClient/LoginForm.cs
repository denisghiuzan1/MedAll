using System;
using System.Windows.Forms;
using MedAll;

namespace MedAllClient
{
    public partial class LoginForm : Form
    {
        private MedAllControllerClient medAllControllerClient;
        public LoginForm()
        {
            this.medAllControllerClient = new MedAllControllerClient();
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm();
            adminForm.Show();
            this.Visible = false;
            //var userDetails = dbController.GetUser(usernameTextBox.Text, passwordTextBox.Text);
            //if (userDetails != null)
            //{
            //    var userRole = dbController.GetUserRole(usernameTextBox.Text, passwordTextBox.Text);
            //    if (userRole.Name.Equals("admin"))
            //    {
            //        var adminForm = new AdminForm();
            //        adminForm.Show();
            //        this.Visible = false;
            //    }
            //}
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
