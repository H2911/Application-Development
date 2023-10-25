using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IConnectData
    { 
        void CreateDatabase();
        bool SaveNewUser(User newUser);
        bool SaveNewEvent(Event newEvent);

        bool CancelEvent(Event eventName);

        bool ModifyEvent(Event eventName);
        List<Event> GetAllActiveEventsInfo();
        User GetUserInfoByID(int ID);
        bool CheckAccountLogin(int ID, string password);
        List<Event> GetActiveEventsByName(String eventName);
        List<Event> GetActiveEventsByDate(String eventDate);

        List<Event> GetActiveEventsByTime(String eventTime);

        List<String> GetAllActiveEventsName();
    }
}
