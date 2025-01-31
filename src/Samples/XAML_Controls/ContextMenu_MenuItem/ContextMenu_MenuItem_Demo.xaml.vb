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
    Partial Public Class ContextMenu_MenuItem_Demo
        Inherits UserControl
        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub MenuItem1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            MessageBox.Show("Menu Item 1")
        End Sub

        Private Sub MenuItem2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            MessageBox.Show("Menu Item 2")
        End Sub

        Private Sub MenuItem3_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            MessageBox.Show("Menu Item 3")
        End Sub

        Private Sub ButtonViewSource_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call ViewSource(New List(Of ViewSourceButtonInfo)() From {
                    New ViewSourceButtonInfo() With {
        .TabHeader = "ContextMenu_MenuItem_Demo.xaml",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ContextMenu_MenuItem/ContextMenu_MenuItem_Demo.xaml"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "ContextMenu_MenuItem_Demo.xaml.cs",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ContextMenu_MenuItem/ContextMenu_MenuItem_Demo.xaml.cs"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "ContextMenu_MenuItem_Demo.xaml.vb",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ContextMenu_MenuItem/ContextMenu_MenuItem_Demo.xaml.vb"
    },
                    New ViewSourceButtonInfo() With {
        .TabHeader = "DefaultMenuItemStyle.xaml",
        .FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ContextMenu_MenuItem/Styles/DefaultMenuItemStyle.xaml"
    }
})
        End Sub

    End Class
End Namespace
