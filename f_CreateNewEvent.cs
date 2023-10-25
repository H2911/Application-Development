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
    public partial class CreateNewEventForm : Form
    {
        public CreateNewEventForm()
        {
            InitializeComponent();
        }

        private void bnt_Cancel_Click(object sender, EventArgs e)
        {
            if (!tb_EventName.Text.Trim().Equals("") || !tb_EventPrice.Text.Trim().Equals(""))
            {
                DialogResult cancelMessageBox = MessageBox.Show("You want to cancel create new event?", "Cancel create new event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cancelMessageBox == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void bnt_CreateEvent_Click(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            connectData.CreateDatabase();
            if (tb_EventName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("You need to fill in name of your event!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_EventPrice.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("You need to fill in price of your event!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_Capacity.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("You need to fill in capacity of your event!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (timePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("You need to fill in date and time in the future!", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string eventName = tb_EventName.Text.Trim();
                int eventPrice = int.Parse(tb_EventPrice.Text.Trim());
                int eventCapacity = int.Parse(tb_Capacity.Text.Trim());
                string eventDate = datePicker.Value.ToShortDateString();
                string eventTime = timePicker.Value.ToShortTimeString().Trim();
                Event newEvent = new Event(eventName, eventPrice, eventCapacity, eventDate, eventTime);
                if (connectData.SaveNewEvent(newEvent))
                {
                    MessageBox.Show("New event has been added:\n\n" + newEvent.Information, "Add new event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } 
            }
        }

        private void CreateNewEventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminManagementForm adminManagementForm = new AdminManagementForm();
            adminManagementForm.Show();
        }

        private void lb_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            timePicker.Value = datePicker.Value.Date;
        }
    }
}
