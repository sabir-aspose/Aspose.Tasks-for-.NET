﻿Imports Aspose.Tasks
Imports VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Examples.VisualBasic

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendars
    Class MakeAStandardCalendar
        Public Shared Sub Run()
            'ExStart: MakeAStandardCalendar
            'The static method of Calendar class, MakeStandardCalendar can be used to make a calendar as Standard after it has been added ot the project

            'Create a project instance
            Dim project As New Project()

            'Define Calendar and make it standard
            Dim cal1 As Aspose.Tasks.Calendar = project.Calendars.Add("My Cal")

            'Now make this calendar as a standard calendar
            Aspose.Tasks.Calendar.MakeStandardCalendar(cal1)

            'Save the Project
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            project.Save("Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
            'ExEnd: MakeAStandardCalendar
        End Sub
    End Class
End Namespace