﻿using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    class ReadWorkWeeksInformation
    {
        public static void Run()
        {
            // ExStart:ReadWorkWeeksInformation
            // This example demonstrates how to read calendar work weeks infomraiton from a Project file

            string dataDir = RunExamples.GetDataDir_WorkingWithCalendars();
            Project project = new Project(dataDir + "project.mpp");

            Calendar calendar = project.Calendars.GetByUid(3);

            WorkWeekCollection collection = calendar.WorkWeeks;

            foreach (WorkWeek workWeek in collection)
            {
                string Name = workWeek.Name;  // Name
                DateTime fromDate = workWeek.FromDate;  // Start
                DateTime toDate = workWeek.ToDate;      // Finish

                // This data is all about "Details." button you can set special working times for special WeekDay or even make nonworking
                WeekDayCollection weekDays = workWeek.WeekDays;   // Aspose.Tasks.WeekDayCollection
                foreach (WeekDay day in weekDays)   // Aspose.Tasks.WeekDay
                {
                    WorkingTimeCollection workingTimes = day.WorkingTimes;  // Aspose.Tasks.WorkingTimeCollection

                    // You can further traverse through working times and display these
                }
            }
            // ExEnd:ReadWorkWeeksInformation
        }
    }
}
