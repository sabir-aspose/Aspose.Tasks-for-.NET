using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.HandlingBasicProperties
{
    public class WriteWeekdayProperties
    {
        public static void Run()
        {
            // ExStart:WriteWeekdayProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_HandlingBasicProperties();
            // Create a project instance
            Project project = new Project(dataDir+ "WriteWeekdayProperties.mpp");

            // Set week days properties
            project.Set(Prj.WeekStartDay, DayType.Monday);
            project.Set(Prj.DaysPerMonth, 24);
            project.Set(Prj.MinutesPerDay, 540);
            project.Set(Prj.MinutesPerWeek, 3240);

            project.Save(dataDir+ "saved.xml", SaveFileFormat.XML);
            // ExEnd:WriteWeekdayProperties            
        }
    }
}