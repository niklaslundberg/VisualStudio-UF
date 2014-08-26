using System;
using System.Collections.Generic;
using System.Linq;

namespace UFData.Web
{
    public class ScheduleItem
    {
        private DateTime startUtc;
        private List<string> teachers;
        private TimeSpan duration;
        private string title;
        private string _class;
        private string _room;

        public ScheduleItem(string title, DateTime startUtc, TimeSpan duration, IEnumerable<string> teachers, string @class, string room)
        {
            this.title = title;
            this.startUtc = startUtc;
            this.duration = duration;
            this.teachers = teachers.ToList();
            this._class = @class;
            this._room = room;
        }

        public IReadOnlyCollection<string> Teachers
        {
            get
            {
                return teachers;
            }
        }

        public DateTime StartTimeUtc
        {
            get
            {
                return startUtc;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return duration;
            }
        }

        public string Class
        {
            get
            {
                return _class;
            }
        }

        public string Room
        {
            get
            {
                return _room;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }
    }
}