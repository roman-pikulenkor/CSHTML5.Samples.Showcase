﻿Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Threading.Tasks
#If SLMIGRATION
Imports System.Windows
Imports System.Windows.Controls
#Else
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#End If

Namespace Global.OpenSilver.Samples.Showcase
    Public Partial Class GetRessourceStream_Demo
        Inherits UserControl
        Private currentUri As Uri


        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Async Sub ViewFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            currentUri = New Uri("ms-appx:/Other/SampleText.txt")
            Dim GetFileContent = RetrieveFileContent(currentUri)

            Dim currentFileContent = Await GetFileContent
            MessageBox.Show("Contains: " & currentFileContent)

        End Sub

        Private Async Function RetrieveFileContent(ByVal uri As Uri) As Task(Of String)
            Dim resourceStream = Await Application.GetResourceStream(uri)
            Dim currentReader As StreamReader = New StreamReader(resourceStream.Stream)

            Using currentReader
                MessageBox.Show("Opening : " & uri.AbsoluteUri)
                Dim result As String = Await currentReader.ReadToEndAsync()
                Return result
            End Using

        End Function

        Private Sub ButtonViewSource_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call ViewSource(New List(Of ViewSourceButtonInfo)() From {
                    New ViewSourceButtonInfo() With {
        .TabHeader = "GetRessourceStream_Demo.xaml",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Net_Framework/GetRessourceStream/GetRessourceStream_Demo.xaml"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "GetRessourceStream_Demo.xaml.cs",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Net_Framework/GetRessourceStream/GetRessourceStream_Demo.xaml.cs"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "GetRessourceStream_Demo.xaml.vb",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Net_Framework/GetRessourceStream/GetRessourceStream_Demo.xaml.vb"
    }
})
        End Sub
    End Class
End Namespace
