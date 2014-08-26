using System;
using System.Collections.Generic;

namespace UFData.Web
{

    public class ScheduleData
    {
        public IReadOnlyCollection<ScheduleItem> GetSchedule()
        {
            List<ScheduleItem> scheduleItems = new List<ScheduleItem>();

            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 9, 12, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 23"));
            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 9, 19, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 23"));
            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 9, 26, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 25"));
            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 10, 3, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 27"));
            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 10, 10, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 23"));
            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 10, 17, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 23"));
            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 10, 24, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 29"));
            scheduleItems.Add(new ScheduleItem("English 1", new DateTime(2014, 10, 31, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(2), new List<string> { "Sven Svensson" }, "1A", "ST 23"));

            scheduleItems.Add(new ScheduleItem("Programming C#", new DateTime(2014, 9, 12, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(1.5), new List<string> { "Kristin Nilsson" }, "2A", "ST 20"));
            scheduleItems.Add(new ScheduleItem("Programming C#", new DateTime(2014, 9, 19, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(1.5), new List<string> { "Kristin Nilsson" }, "2A", "ST 20"));
            scheduleItems.Add(new ScheduleItem("Programming C#", new DateTime(2014, 9, 26, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(1.5), new List<string> { "Kristin Nilsson" }, "2A", "ST 20"));
            scheduleItems.Add(new ScheduleItem("Programming C#", new DateTime(2014, 10, 3, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(1.5), new List<string> { "Kristin Nilsson" }, "2A", "ST 20"));

            scheduleItems.Add(new ScheduleItem("Physics B", new DateTime(2014, 9, 15, 10, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(3), new List<string> { "Anders Olofsson" }, "2B", "ST 21"));
            scheduleItems.Add(new ScheduleItem("Physics B", new DateTime(2014, 9, 22, 10, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(3), new List<string> { "Anders Olofsson" }, "2B", "ST 21"));
            scheduleItems.Add(new ScheduleItem("Physics B", new DateTime(2014, 9, 29, 10, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(3), new List<string> { "Anders Olofsson" }, "2B", "ST 21"));
            scheduleItems.Add(new ScheduleItem("Physics B", new DateTime(2014, 10, 6, 10, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(3), new List<string> { "Anders Olofsson" }, "2B", "ST 21"));

            scheduleItems.Add(new ScheduleItem("Math C", new DateTime(2014, 9, 15, 10, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(3), new List<string> { "Simone Ahmad" }, "2C", "ST 24"));
            scheduleItems.Add(new ScheduleItem("Math C", new DateTime(2014, 9, 17, 14, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(3), new List<string> { "Simone Ahmad", "Anna Johansson" }, "2C", "ST 24"));
            scheduleItems.Add(new ScheduleItem("Math C", new DateTime(2014, 9, 19, 8, 0, 0, DateTimeKind.Utc), TimeSpan.FromHours(3), new List<string> { "Simone Ahmad" }, "2C", "ST 15"));

            return scheduleItems;
        }
    }
}