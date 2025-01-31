﻿Imports System
Imports System.Collections.Generic
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
    Partial Public Class HyperlinkButton_Demo
        Inherits UserControl
        Public Sub New()
            Me.InitializeComponent()

#If OPENSILVER Then
            Me.HyperlinkButtonDemo.NavigateUri = New Uri("http://www.opensilver.net")
#End If

        End Sub

        Private Sub ButtonViewSource_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call ViewSource(New List(Of ViewSourceButtonInfo)() From {
                    New ViewSourceButtonInfo() With {
        .TabHeader = "HyperlinkButton.xaml",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/HyperlinkButton/HyperlinkButton.xaml"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "HyperlinkButton.xaml.cs",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/HyperlinkButton/HyperlinkButton.xaml.cs"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "HyperlinkButton.xaml.vb",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/HyperlinkButton/HyperlinkButton.xaml.vb"
    }
})
        End Sub

    End Class
End Namespace
