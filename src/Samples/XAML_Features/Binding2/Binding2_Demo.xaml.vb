﻿Imports System.Collections.Generic
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
    Partial Public Class Binding2_Demo
        Inherits UserControl
        Public Sub New()
            Me.InitializeComponent()
            Me.Title.Content = "Binding (2 of 3)"
        End Sub

        Private Sub ButtonViewSource_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call ViewSource(New List(Of ViewSourceButtonInfo)() From {
                    New ViewSourceButtonInfo() With {
        .TabHeader = "Binding2_Demo.xaml",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Features/Binding2/Binding2_Demo.xaml"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "Binding2_Demo.xaml.cs",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Features/Binding2/Binding2_Demo.xaml.cs"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "KilometersToMilesConverter.cs",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Features/Binding2/KilometersToMilesConverter.cs"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "Binding2_Demo.xaml.vb",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Features/Binding2/Binding2_Demo.xaml.vb"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "KilometersToMilesConverter.vb",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Features/Binding2/KilometersToMilesConverter.vb"
    }
})
        End Sub

    End Class
End Namespace
