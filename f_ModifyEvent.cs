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
    //Form for modifing the event
    public partial class f_ModifyEvent : Form
    {
        public f_ModifyEvent()
        {
            InitializeComponent();
        }

        private void bnt_Discard_Click(object sender, EventArgs e)
        {
            if (!tb_EventName.Text.Trim().Equals("") || !tb_EventPrice.Text.Trim().Equals(""))
            {
                DialogResult cancelMessageBox = MessageBox.Show("You want to discard modify this event?", "Cancel modify the event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cancelMessageBox == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void bnt_ConfirmChange_Click(object sender, EventArgs e)
        {
            DialogResult cancelMessageBox = MessageBox.Show("You want to modify this event?", "Cancel the event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cancelMessageBox == DialogResult.Yes)
            {
                //get info from the form
                string eventName = tb_EventName.Text.Trim();
                int eventPrice = int.Parse(tb_EventPrice.Text.Trim());
                int eventCapacity = int.Parse(tb_Capacity.Text.Trim());
                string eventDate = datePicker.Value.ToShortDateString();
                string eventTime = timePicker.Value.ToShortTimeString().Trim();
                Event currentEvent = new Event(eventName, eventPrice, eventCapacity, eventDate, eventTime);
                currentEvent.EventID = int.Parse(lbID.Text.Split(':')[1].Trim());
                
                //Connect to the database
                ConnectData connectData = new ConnectData();

                //Save modified event
                if (connectData.ModifyEvent(currentEvent))
                {
                    MessageBox.Show("Your event datails has been change to:\n\n" + currentEvent.Information, "Add new event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void bnt_CancelEvent_Click(object sender, EventArgs e)
        {
            DialogResult cancelMessageBox = MessageBox.Show("You want to cancel this event?", "Cancel the event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cancelMessageBox == DialogResult.Yes)
            {
                //get data from the form
                string eventName = tb_EventName.Text.Trim();
                int eventPrice = int.Parse(tb_EventPrice.Text.Trim());
                int eventCapacity = int.Parse(tb_Capacity.Text.Trim());
                string eventDate = datePicker.Value.ToShortDateString();
                string eventTime = timePicker.Value.ToShortTimeString().Trim();
                Event currentEvent = new Event(eventName, eventPrice, eventCapacity, eventDate, eventTime);
                currentEvent.EventID = int.Parse(lbID.Text.Split(':')[1].Trim());
                
                //Connect to the database
                ConnectData connectData = new ConnectData();
                
                //Save new status for the target event
                if (connectData.CancelEvent(currentEvent))
                {
                    MessageBox.Show("Your event has been canceled:\n\n" + currentEvent.Information, "Cancel Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void ModifyEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            Events eventForm = new Events();
            eventForm.Show();
        }
    }
}
