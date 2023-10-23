using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Event
    {
        private string eventName;
        private int eventPrice;
        private int eventCapacity;
        private string eventDate;
        private string eventTime;
        public Event(string eventName, int eventPrice, int eventCapacity, string eventDate, string eventTime)
        {
            this.eventName = eventName;
            this.eventPrice = eventPrice;
            this.eventCapacity = eventCapacity;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
        }
        public string Name {  get { return this.eventName; } }
        public int Price { get { return this.eventPrice; } }
        public int Capacity { get { return this.eventCapacity; } }

        public string Date { get { return this.eventDate; } }
        public string Time { get { return this.eventTime;} }
        public override string ToString()
        {
            return eventName + "," +eventPrice.ToString() + "," + eventCapacity.ToString() + "," + eventDate.ToString() + "," + eventTime;
        }
        public string Information { get { return "Event Name: " + eventName + "\n" + "Event Price: " + eventPrice.ToString() + "\n" + "Event Capacity: " + eventCapacity.ToString() + "\n" + "Event Date: " + eventDate.ToString() + "\n" + "Event Time: " + eventTime; } }
    }

}
