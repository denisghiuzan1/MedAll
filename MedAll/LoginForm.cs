using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAll.Model;

namespace MedAll
{
    public partial class LoginForm : Form
    {
        private DBController dbController;
        public LoginForm()
        {
            this.dbController = new DBController();
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
    }
}
