using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.PrintingAndExporting
{
    public class ExportProjectDataToXMLFormat
    {
        public static void Run()
        {
            // ExStart:ExportProjectDataToXMLFormat
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PrintingAndExporting();
            Project project = new Project(dataDir + "Project1.mpp");
            project.Save(dataDir + "ExportProjectDataToXMLFormat_out.xml", SaveFileFormat.PrimaveraP6XML);             
            // ExEnd:ExportProjectDataToXMLFormat
        }
    }
}