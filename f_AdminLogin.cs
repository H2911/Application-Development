using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
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
            
        }
    }
}
