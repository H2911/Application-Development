using System;
using System.Windows.Forms;

namespace Assignment2
{
    //Form for admin interact when login as admin roll
    public partial class AdminManagementForm : Form
    {
        public AdminManagementForm()
        {
            InitializeComponent();
        }

        private void bntCreateNewEvent_Click(object sender, EventArgs e)
        {
            CreateNewEventForm createNewEventForm = new CreateNewEventForm();
            createNewEventForm.Show();
            this.Hide();
        }

        private void bntModifyEvent_Click(object sender, EventArgs e)
        {
            Events newEventsForm = new Events();
            newEventsForm.Show();
            this.Hide();
        }

        private void AdminManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bnt_Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You want to logout?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                UserLoginForm loginForm = new UserLoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
