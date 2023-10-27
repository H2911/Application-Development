using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
    public class ConnectData:IConnectData
    {
        //Path to save events information
        protected string EVENTS_PATH = "Events.txt";

        //Path to save users information
        protected string USERS_PATH = "Users.txt";

        public void CheckAccountLogin()
        {
            throw new NotImplementedException();
        }

        public void CreateDatabase()
        {
            //Check users file
            if (!File.Exists(USERS_PATH))
            {
                var accountFile = File.Create(USERS_PATH);
                accountFile.Close();
            }
            ////Check events file
            if (!File.Exists(EVENTS_PATH))
            {
                var appointmentFile = File.Create(EVENTS_PATH);
                appointmentFile.Close();
            }
        }

        public bool SaveNewEvent(Event newEvent)
        {
            try
            {
                var f = new FileInfo(EVENTS_PATH);
                //First input
                if (f.Length == 0)
                {
                    int lines = File.ReadAllLines(EVENTS_PATH).Length;
                    newEvent.EventID = lines + 1;
                    File.AppendAllText(EVENTS_PATH, String.Format("{0}", newEvent.ToString()));
                    return true;
                }
                //Second input
                else
                {
                    int lines = File.ReadAllLines(EVENTS_PATH).Length;
                    newEvent.EventID = lines + 1;
                    File.AppendAllText(EVENTS_PATH, String.Format("\n{0}", newEvent.ToString()));
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool SaveNewUser(User newUser)
        {
            try
            {
                var f = new FileInfo(USERS_PATH);
                //First input
                if (f.Length == 0)
                {
                    File.AppendAllText(USERS_PATH, String.Format("{0}", newUser.ToString()));
                    return true;
                }
                //Second input
                else
                {
                    File.AppendAllText(USERS_PATH, String.Format("\n{0}", newUser.ToString()));
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public User GetUserInfoByID(int ID)
        {
            User user = null;
            String name;
            String password;
            String roll;
            //get data from account file
            String[] usersData = File.ReadAllLines(USERS_PATH);

            //Get data user from the database to save as user object
            foreach (string userData in usersData)
            {
                if (int.Parse(userData.Split(',')[0].Trim()) == ID)
                {
                    name = userData.Split(',')[1].Trim();
                    password = userData.Split(',')[2].Trim();
                    roll = userData.Split(',')[3].Trim();
                    user = new User(ID,name, password, roll);
                    break;
                }
            }
            return user;
        }

        public List<Event> GetAllActiveEventsInfo()
        {
            List<Event> events = new List<Event>();
            //Get all data from events database
            string[] eventsData = File.ReadAllLines(EVENTS_PATH);
            int eventID = 0;
            string eventName = "";
            int eventPrice = 0;
            int eventCapacity = 0;
            string eventDate = "";
            string eventTime = "";
            int participants = 0;
            string eventStatus = "";

            //Load all info from the file
            foreach (string eventData in eventsData)
            {
                eventStatus = eventData.Split(',')[7].Trim();
                //Fill the active events to use
                if(eventStatus == "Active")
                {
                    eventID = int.Parse(eventData.Split(',')[0].Trim());
                    eventName = eventData.Split(',')[1].Trim();
                    eventPrice = int.Parse(eventData.Split(',')[2].Trim());
                    eventCapacity = int.Parse(eventData.Split(',')[3].Trim());
                    eventDate = eventData.Split(',')[4].Trim();
                    eventTime = eventData.Split(',')[5].Trim();
                    participants = int.Parse(eventData.Split(',')[6].Trim());
                    events.Add(new Event(eventID, eventName, eventPrice, eventCapacity, eventDate, eventTime,participants, eventStatus));
                }
                
            }
            return events;
        }
        public List<Event> GetActiveEventsByName(string EventName)
        {
            List<Event> eventsData = GetAllActiveEventsInfo();
            var events = from Event eventData in eventsData
                     where eventData.Name == EventName
                     select eventData;
            return events.ToList<Event>();
        }

        public List<Event> GetActiveEventsByTime(string eventTime)
        {
            List<Event> eventsData = GetAllActiveEventsInfo();
            var events = from Event eventData in eventsData
                         where eventData.Time == eventTime
                         select eventData;
            return events.ToList<Event>();
        }

        public bool CheckAccountLogin(int ID, string password)
        {
            //get data from account file
            String[] usersData = File.ReadAllLines(USERS_PATH);
            foreach (string userData in usersData)
            {
                //Check ID
                if (int.Parse(userData.Split(',')[0].Trim()) == ID)
                {
                    //Check password
                    if (userData.Split(',')[2].Trim() == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<String> GetAllActiveEventsName()
        {
            List<Event> eventsData = GetAllActiveEventsInfo();
            var events = from Event eventData in eventsData
                         select eventData.Name;
            return events.ToList<String>();
        }

        public List<Event> GetActiveEventsByDate(string eventDate)
        {
            List<Event> eventsData = GetAllActiveEventsInfo();
            var events = from Event eventData in eventsData
                         where eventData.Date == eventDate
                         select eventData;
            return events.ToList<Event>();
        }

        public bool CancelEvent(Event cancelEvent)
        {
            cancelEvent.Status = "Inactive";
            // Read the old file.
            string[] lines = File.ReadAllLines(EVENTS_PATH);

            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter(EVENTS_PATH))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    //Replace the target line
                    if (currentLine == cancelEvent.EventID)
                    {
                        if (currentLine == lines.Length)
                        {
                            writer.Write(cancelEvent.ToString());
                        }
                        else
                        {
                            writer.WriteLine(cancelEvent.ToString());
                        }
                    }
                    //Rewrite the old line
                    else
                    {
                        if(currentLine == lines.Length)
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                        }
                        else
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                        }
                    }
                }
            }
            return true;
        }

        public bool ModifyEvent(Event eventName)
        {
            // Read the old file.
            string[] lines = File.ReadAllLines(EVENTS_PATH);

            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter(EVENTS_PATH))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    //Replace the target line
                    if (currentLine == eventName.EventID)
                    {
                        if (currentLine == lines.Length)
                        {
                            writer.Write(eventName.ToString());
                        }
                        else
                        {
                            writer.WriteLine(eventName.ToString());
                        }
                    }
                    //Rewrite the old line
                    else
                    {
                        if (currentLine == lines.Length)
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                        }
                        else
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                        }
                    }
                }
            }
            return true;
        }

        public void UpdateEventStatusInFile(Event currentEvent)
        {
            throw new NotImplementedException();
        }
    }
}
