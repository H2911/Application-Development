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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminManagementForm adminManagementForm = new AdminManagementForm();
            adminManagementForm.Show();
        }

        private void bnt_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbb_EventName_SelectedValueChanged(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            List<Event> events = connectData.GetEventsByName(cbb_EventName.GetItemText(cbb_EventName.SelectedItem));
            lv_events.Items.Clear();
            foreach (var eventData in events)
            {
                var row = new string[] {eventData.EventID.ToString(), eventData.Name,eventData.Price.ToString()
                    ,eventData.Capacity.ToString(),eventData.Date,eventData.Time };
                var lvi = new ListViewItem(row);
                lvi.Tag = eventData;
                lv_events.Items.Add(lvi);
            }
        }

        private void Events_Load(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            cbb_EventName.DataSource = connectData.GetAllEventsName();
            cbb_EventName.SelectedItem = null;
            cbb_EventName.SelectedText = "";
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            List<Event> events = connectData.GetEventsByDate(datePicker.Value.ToShortDateString());
            lv_events.Items.Clear();
            foreach (var eventData in events)
            {
                var row = new string[] {eventData.EventID.ToString(), eventData.Name,eventData.Price.ToString()
                    ,eventData.Capacity.ToString(),eventData.Date,eventData.Time  };
                var lvi = new ListViewItem(row);
                lvi.Tag = eventData;
                lv_events.Items.Add(lvi);
            }
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            List<Event> events = connectData.GetEventsByTime(timePicker.Text.Trim());
            lv_events.Items.Clear();
            foreach (var eventData in events)
            {
                var row = new string[] {eventData.EventID.ToString(),eventData.Name,eventData.Price.ToString()
                    ,eventData.Capacity.ToString(),eventData.Date,eventData.Time  };
                var lvi = new ListViewItem(row);
                lvi.Tag = eventData;
                lv_events.Items.Add(lvi);
            }
        }

        private void lv_events_DoubleClick(object sender, EventArgs e)
        {
            ModifyEvents modifyEvents = new ModifyEvents();
            string eventName = lv_events.SelectedItems[0].SubItems[1].Text;
            int eventPrice = int.Parse(lv_events.SelectedItems[0].SubItems[2].Text);
            int eventCapacity = int.Parse(lv_events.SelectedItems[0].SubItems[3].Text);
            string eventDate = lv_events.SelectedItems[0].SubItems[4].Text;
            string eventTime = lv_events.SelectedItems[0].SubItems[5].Text;
            modifyEvents.tb_EventName.Text = eventName;
            modifyEvents.tb_EventPrice.Text = eventPrice.ToString();
            modifyEvents.tb_Capacity.Text = eventCapacity.ToString();
            modifyEvents.datePicker.Value = DateTime.Parse(eventDate);
            modifyEvents.timePicker.Value = DateTime.Parse(eventTime);
            modifyEvents.Show();
            this.Hide();
        }
    }
}
