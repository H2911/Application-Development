using System;
using System.Windows.Forms;

namespace Assignment2
{
    //Class to create event object to store information of event
    public class Event
    {
        private int eventID;
        private string eventName;
        private int eventPrice;
        private int eventCapacity;
        private string eventDate;
        private string eventTime;
        //Set default participants event to 0 when it is init
        private int participants = 0;
        //Set default status event to active when it is init
        private string status = "Active";
        //Event object to create new event, short form
        public Event(string eventName, int eventPrice, int eventCapacity, string eventDate, string eventTime)
        {
            this.eventName = eventName;
            this.eventPrice = eventPrice;
            this.eventCapacity = eventCapacity;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
        }
        //Event object when loading the data from the database, full info
        public Event(int eventID, string eventName, int eventPrice, int eventCapacity, string eventDate, string eventTime,int participants, string status)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.eventPrice = eventPrice;
            this.eventCapacity = eventCapacity;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
            this.participants = participants;
            this.status = status;
        }
        public string Name {  get { return this.eventName; } }
        public int Price { get { return this.eventPrice; } }
        public int Capacity { get { return this.eventCapacity; } }

        public int Participants { get { return this.participants; } }
        public string Date { get { return this.eventDate; } }
        public string Time { get { return this.eventTime;} }
        public int EventID { get { return this.eventID;} set { this.eventID = value; } }
        public string Status { get { return this.status; } set  { this.status = value; } }
        
        /// <summary>
        /// Method return available spaces of the event
        /// </summary>
        public int AvailableSpace { get { return (this.eventCapacity - this.participants); } }

        /// <summary>
        /// Method to add number of participants in the event when register in the event
        /// </summary>
        /// <param name="newParticipants"></param>
        /// <returns></returns>
        public bool AddParticipants(int newParticipants)
        {
            int newCapacity = participants + newParticipants;
            if(newCapacity > eventCapacity) {
                MessageBox.Show(String.Format("Sorry the event just have {0} slots left!", eventCapacity - participants), "Not enough tickets!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            participants += newParticipants;
            if(newCapacity == eventCapacity)
            {
                status = "Full";
            }
            return true;
        }
        public override string ToString()
        {
            return eventID.ToString() +"," + eventName + "," +eventPrice.ToString() + "," + eventCapacity.ToString() + "," + eventDate.ToString() + "," + eventTime + "," + participants + "," + status;
        }
        /// <summary>
        /// Return string to present the data
        /// </summary>
        public string Information { get { return "Event Name: " + eventName + "\n" + "Event Price: " + eventPrice.ToString() + "\n" + "Event Capacity: " + eventCapacity.ToString() + "\n" + "Event Date: " + eventDate.ToString() + "\n" + "Event Time: " + eventTime; } }
    }

}
