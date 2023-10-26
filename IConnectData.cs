using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //Interface class to create methods to connect with the database
    public interface IConnectData
    { 
        /// <summary>
        /// Create a new database if there is the first use of the system
        /// </summary>
        void CreateDatabase();
        /// <summary>
        /// Save new user info to the database
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns>true if save succesful</returns>
        bool SaveNewUser(User newUser);
        /// <summary>
        /// Save new event info to the database
        /// </summary>
        /// <param name="newEvent"></param>
        /// <returns>true if save succesful</returns>
        bool SaveNewEvent(Event newEvent);

        /// <summary>
        /// Cancel event, set the status to "Deactive" in the database
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns>true if save succesful</returns>

        bool CancelEvent(Event eventName);

        /// <summary>
        /// Replace a modified event in the database
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns>true if save succesful</returns>
        bool ModifyEvent(Event eventName);

        /// <summary>
        /// Get all active envents info from the database
        /// </summary>
        /// <returns>list of events</returns>
        List<Event> GetAllActiveEventsInfo();

        /// <summary>
        /// Get user details by the ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>User object</returns>
        User GetUserInfoByID(int ID);

        /// <summary>
        /// Check account in the database
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="password"></param>
        /// <returns>true if exist</returns>
        bool CheckAccountLogin(int ID, string password);

        /// <summary>
        /// Get all active envents info by event name from the database
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns>List of events</returns>
        List<Event> GetActiveEventsByName(String eventName);

        /// <summary>
        /// Get all active envents info by event Date from the database
        /// </summary>
        /// <param name="eventDate"></param>
        /// <returns>List of events</returns>
        List<Event> GetActiveEventsByDate(String eventDate);

        /// <summary>
        /// Get all active envents info by event Time from the database
        /// </summary>
        /// <param name="eventTime"></param>
        /// <returns>List of events</returns>
        List<Event> GetActiveEventsByTime(String eventTime);

        /// <summary>
        /// Get all active envent names from the database
        /// </summary>
        /// <returns>list of event names</returns>
        List<String> GetAllActiveEventsName();
    }
}
