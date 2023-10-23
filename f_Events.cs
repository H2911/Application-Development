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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbb_EventName_SelectedValueChanged(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            List<Event> events = connectData.GetEventsByName(cbb_EventName.GetItemText(cbb_EventName.SelectedItem));
            lv_events.Items.Clear();
            foreach(var eventData in events)
            {
                var row = new string[] {eventData.Name,eventData.Price.ToString()
                    ,eventData.Capacity.ToString(),eventData.Date,eventData.Time  };
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
    }
}
