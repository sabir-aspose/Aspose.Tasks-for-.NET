Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.CreatingAndSaving
    Public Class ReadPasswordProtectedProjectFile
        Public Shared Sub Run()

            ' ExStart:ReadingPasswordProtectedProjectFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreatingAndSaving()
            Dim project As New Project(dataDir & Convert.ToString("Project5.mpp"), "password")
            ' ExEnd:ReadingPasswordProtectedProjectFile
        End Sub
    End Class
End Namespace
