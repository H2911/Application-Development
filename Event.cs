using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment2
{
    public class Event
    {
        private int eventID;
        private string eventName;
        private int eventPrice;
        private int eventCapacity;
        private string eventDate;
        private string eventTime;
        private int participants = 0;
        private string status = "Active";
        public Event(string eventName, int eventPrice, int eventCapacity, string eventDate, string eventTime)
        {
            this.eventName = eventName;
            this.eventPrice = eventPrice;
            this.eventCapacity = eventCapacity;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
        }
        public Event(int eventID, string eventName, int eventPrice, int eventCapacity, string eventDate, string eventTime, string status)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.eventPrice = eventPrice;
            this.eventCapacity = eventCapacity;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
            this.status = status;
        }
        public string Name {  get { return this.eventName; } }
        public int Price { get { return this.eventPrice; } }
        public int Capacity { get { return this.eventCapacity; } }

        public string Date { get { return this.eventDate; } }
        public string Time { get { return this.eventTime;} }
        public int EventID { get { return this.eventID;} set { this.eventID = value; } }
        public string Status { get { return this.status; } set  { this.status = value; } }
        public int AvailableSpace { get { return (this.eventCapacity - this.participants); } }

        public bool AddParticipants(int newParticipants)
        {
            int newCapacity = participants + newParticipants;
            if(newCapacity > eventCapacity) {
                MessageBox.Show(String.Format("Sorry the event just have {0} slots left!", eventCapacity - participants), "Not enough tickets!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            participants += newParticipants;
            return true;
        }
        public override string ToString()
        {
            return eventID.ToString() +"," + eventName + "," +eventPrice.ToString() + "," + eventCapacity.ToString() + "," + eventDate.ToString() + "," + eventTime + "," + status;
        }
        public string Information { get { return "Event Name: " + eventName + "\n" + "Event Price: " + eventPrice.ToString() + "\n" + "Event Capacity: " + eventCapacity.ToString() + "\n" + "Event Date: " + eventDate.ToString() + "\n" + "Event Time: " + eventTime; } }
    }

}
