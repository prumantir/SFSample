using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SFSample
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /Schedule/
        public ActionResult ScheduleFeatures()
        {
             List<DataSource> data = new List<DataSource>();
            data.Add(new DataSource(11, "Meeting", "", new DateTime(2014, 6, 2, 3, 0, 0), new DateTime(2014, 6, 2, 4, 0, 0), false, false));
            data.Add(new DataSource(12, "Meeting", "", new DateTime(2014, 6, 3, 1, 0, 0), new DateTime(2014, 6, 3, 2, 0, 0), false, false));
            data.Add(new DataSource(13, "Meeting", "", new DateTime(2014, 6, 4, 3, 0, 0), new DateTime(2014, 6, 4, 4, 0, 0), false, false));
            data.Add(new DataSource(14, "Meeting", "", new DateTime(2014, 6, 5, 5, 0, 0), new DateTime(2014, 6, 5, 6, 0, 0), false, false));
            data.Add(new DataSource(15, "Meeting", "", new DateTime(2014, 6, 6, 3, 0, 0), new DateTime(2014, 6, 6, 4, 0, 0), false, false));
            return View(data);
        }
    }
         public class DataSource
    {
        private int id;
        private string subject;
        private string description;
        private DateTime startTime;
        private DateTime endTime;
        private bool allDay;
        private bool recurrence;
        public DataSource(int id, string subject, string description, DateTime startTime, DateTime endTime, bool allDay, bool recurrence)
        {
            this.id = id;
            this.subject = subject;
            this.description = description;
            this.startTime = startTime;
            this.endTime = endTime;
            this.allDay = allDay;
            this.recurrence = recurrence;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public bool AllDay
        {
            get { return allDay; }
            set { allDay = value; }
        }
        public bool Recurrence
        {
            get { return recurrence; }
            set { recurrence = value; }
        }
    }
}
