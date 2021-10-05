using ChilliSoftDLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChilliSoftDLL.DataAccess.Interfaces
{
    public interface IChilliDB
    {
        #region Employee
        Employee AddEmployee(Employee entity);
        Employee UpdateEmployee(Employee entity);
        Employee DeleteEmployee(Employee entity);
        List<Employee> GetAllEmployees();
        #endregion

        #region Meeting
        Meeting AddMeeting(Meeting entity);
        Meeting UpdateMeeting(Meeting entity);
        Meeting GetMeeting(Meeting entity);
        Meeting GetMeeting(string entity);
        List<Meeting> GetAllMeetings();
        List<Meeting> FilterMeetings(string query);
        #endregion

        #region Item
        Item AddItem(Item entity);
        Item UpdateItem(Item entity);
        Item GetItem(Item entity);
        Item GetItem(string entity);
        Item DeleteItem(Item entity);
        List<Item> GetAllItems();
        List<Item> FilterItems(string query);
        #endregion

        #region Minutes
        MinutesEntry AddMinutes(MinutesEntry entity);
        MinutesEntry UpdateMinutes(MinutesEntry entity);
        MinutesEntry GetMinutes(MinutesEntry entity);
        MinutesEntry GetMinutes(string entity);
        MinutesEntry DeleteMinutes(MinutesEntry entity);
        List<MinutesEntry> GetAllMinutes();
        List<MinutesEntry> FilterMinutes(string query);
        #endregion

        #region Messages
        Message AddMessage(Message entity);
        Message UpdateMessage(Message entity);
        Message GetMessage(Message entity);
        Message GetMessage(string entity);
        Message DeleteMessage(Message entity);
        List<Message> GetAllMessages();
        List<Message> FilterMessages(string query);
        #endregion

        #region Report
        Report AddReport(Report entity);
        Report UpdateReport(Report entity);
        Report GetReport(Report entity);
        Report GetReport(string entity);
        Report DeleteReport(Report entity);
        List<Report> GetAllReport();
        List<Report> FilterRepoer(string query); 
        #endregion
    }
}
