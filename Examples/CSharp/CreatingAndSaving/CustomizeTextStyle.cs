using System.Collections.Generic;
using System.Drawing;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.CreatingAndSaving
{
    public class CustomizeTextStyle
    {
        public static void Run()
        {
            // ExStart:CustomizeTextStyle

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreatingAndSaving();

            // Create a project instance and Set default properties
            Project project = new Project(dataDir + "Project2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.ResourceSheet;

            TextStyle style = new TextStyle();
            style.Color = Color.OrangeRed;
            style.FontStyle = FontStyle.Bold;
            style.FontStyle |= FontStyle.Italic;
            style.ItemType = TextItemType.OverallocatedResources;

            options.TextStyles = new List<TextStyle>();
            options.TextStyles.Add(style);
            project.Save(dataDir + "CustomizeTextStyle_out.pdf", options);
            // ExEnd:CustomizeTextStyle
        }
    }
}