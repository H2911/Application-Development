using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment2
{
    //Form to show, search the events of the system
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
            AdminManagementForm adminManagementForm = new AdminManagementForm();
            adminManagementForm.Show();
        }

        private void bnt_Back_Click(object sender, EventArgs e)
        {
            //Back to the admin manager form
            this.Close();
        }


        private void cbb_EventName_SelectedValueChanged(object sender, EventArgs e)
        {
            //connect to the database
            ConnectData connectData = new ConnectData();

            //get all the events according to the selected name
            List<Event> events = connectData.GetActiveEventsByName(cbb_EventName.GetItemText(cbb_EventName.SelectedItem));
            lv_events.Items.Clear();

            //Load the info into the list view
            foreach (var eventData in events)
            {
                var row = new string[] {eventData.EventID.ToString(), eventData.Name,eventData.Price.ToString()
                    ,eventData.Capacity.ToString(),eventData.Date,eventData.Time, eventData.Participants.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = eventData;
                lv_events.Items.Add(lvi);
            }
        }

        private void Events_Load(object sender, EventArgs e)
        {
            //connect to the database
            ConnectData connectData = new ConnectData();

            //Set default form with no information
            cbb_EventName.DataSource = connectData.GetAllActiveEventsName();
            cbb_EventName.SelectedItem = null;
            cbb_EventName.SelectedText = "";
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            //connect to the database
            ConnectData connectData = new ConnectData();

            //get all the events according to the selected date
            List<Event> events = connectData.GetActiveEventsByDate(datePicker.Value.ToShortDateString());
            lv_events.Items.Clear();

            //Load the info into the list view
            foreach (var eventData in events)
            {
                var row = new string[] {eventData.EventID.ToString(), eventData.Name,eventData.Price.ToString()
                    ,eventData.Capacity.ToString(),eventData.Date,eventData.Time, eventData.Participants.ToString()};
                var lvi = new ListViewItem(row);
                lvi.Tag = eventData;
                lv_events.Items.Add(lvi);
            }
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            //connect to the database
            ConnectData connectData = new ConnectData();

            //get all the events according to the selected time
            List<Event> events = connectData.GetActiveEventsByTime(timePicker.Text.Trim());
            lv_events.Items.Clear();

            //Load the info into the list view
            foreach (var eventData in events)
            {
                var row = new string[] {eventData.EventID.ToString(),eventData.Name,eventData.Price.ToString()
                    ,eventData.Capacity.ToString(),eventData.Date,eventData.Time, eventData.Participants.ToString()};
                var lvi = new ListViewItem(row);
                lvi.Tag = eventData;
                lv_events.Items.Add(lvi);
            }
        }

        private void lv_events_DoubleClick(object sender, EventArgs e)
        {
            //Create new modify form of the target event
            f_ModifyEvent modifyEvents = new f_ModifyEvent();

            //Get info from selected item in list view
            int eventID = int.Parse(lv_events.SelectedItems[0].Text);
            string eventName = lv_events.SelectedItems[0].SubItems[1].Text;
            int eventPrice = int.Parse(lv_events.SelectedItems[0].SubItems[2].Text);
            int eventCapacity = int.Parse(lv_events.SelectedItems[0].SubItems[3].Text);
            string eventDate = lv_events.SelectedItems[0].SubItems[4].Text;
            string eventTime = lv_events.SelectedItems[0].SubItems[5].Text;
            int participants = int.Parse(lv_events.SelectedItems[0].SubItems[6].Text);

            //Load the info into the modify page
            modifyEvents.lbID.Text = "ID: " + eventID.ToString();
            modifyEvents.lb_participants.Text = "Participants: " + participants.ToString();
            modifyEvents.tb_EventName.Text = eventName;
            modifyEvents.tb_EventPrice.Text = eventPrice.ToString();
            modifyEvents.tb_Capacity.Text = eventCapacity.ToString();
            modifyEvents.datePicker.Value = DateTime.Parse(eventDate);
            modifyEvents.timePicker.Value = DateTime.Parse(eventTime);

            //Show the modify form
            modifyEvents.Show();
            
            //Close show all events form
            this.Hide();
        }
    }
}
