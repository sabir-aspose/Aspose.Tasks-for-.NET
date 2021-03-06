using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class UpdateProjectAndRescheduleUncompletedWork
    {
        public static void Run()
        {
            // ExStart:UpdateProjectAndRescheduleUncompletedWork
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithProjects();
            Project project = new Project();
            project.Set(Prj.StartDate, new DateTime(2014, 1, 27, 8, 0, 0));
            Task task1 = project.RootTask.Children.Add("Task 1");
            Task task2 = project.RootTask.Children.Add("Task 2");
            task2.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            Task task3 = project.RootTask.Children.Add("Task 3");
            task3.Set(Tsk.Duration, task2.ParentProject.GetDuration(24, TimeUnitType.Hour));
            Task task4 = project.RootTask.Children.Add("Task 4");
            task4.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            Task task5 = project.RootTask.Children.Add("Task 5");
            task5.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            TaskLink link12 = project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);
            TaskLink link23 = project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart);
            link23.LinkLag = 4800; // one day lag
            TaskLink link34 = project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart);
            TaskLink link45 = project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart);
            Task task6 = project.RootTask.Children.Add("Task 6");
            Task task7 = project.RootTask.Children.Add("Task 7");
            task7.Set(Tsk.Duration, task7.ParentProject.GetDuration(24, TimeUnitType.Hour));
            Task task8 = project.RootTask.Children.Add("Task 8");
            task8.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            Task task9 = project.RootTask.Children.Add("Task 9");
            task9.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            Task task10 = project.RootTask.Children.Add("Task 10");
            TaskLink link67 = project.TaskLinks.Add(task6, task7, TaskLinkType.FinishToStart);
            TaskLink link78 = project.TaskLinks.Add(task7, task8, TaskLinkType.FinishToStart);
            TaskLink link89 = project.TaskLinks.Add(task8, task9, TaskLinkType.FinishToStart);
            TaskLink link910 = project.TaskLinks.Add(task9, task10, TaskLinkType.FinishToStart);
            task6.Set(Tsk.IsManual, true);
            task7.Set(Tsk.IsManual, true);
            task8.Set(Tsk.IsManual, true);
            task9.Set(Tsk.IsManual, true);
            task10.Set(Tsk.IsManual, true);
            project.Save(dataDir + "not updated.xml", SaveFileFormat.XML);
            project.UpdateProjectWorkAsComplete(new DateTime(2014, 1, 28, 17, 0, 0), false);
            project.Save(dataDir + "updated_out.xml", SaveFileFormat.XML);
            project.RescheduleUncompletedWorkToStartAfter(new DateTime(2014, 2, 7, 8, 0, 0));
            project.Save(dataDir + "rescheduled_out.xml", SaveFileFormat.XML);
            // ExEnd:UpdateProjectAndRescheduleUncompletedWork
        }
    }
}