﻿namespace OpenSilver.Samples.Showcase

open System
open System.Collections.Generic
open System.IO
open System.Linq
#if SLMIGRATION
open System.Windows
open System.Windows.Controls
#else
open Windows.Foundation
open Windows.UI.Xaml
open Windows.UI.Xaml.Controls
open Windows.UI.Xaml.Controls.Primitives
open Windows.UI.Xaml.Data
open Windows.UI.Xaml.Input
open Windows.UI.Xaml.Media
open Windows.UI.Xaml.Navigation
#endif

type ToolTip_Demo() as this =
    inherit ToolTip_DemoXaml()
    
    do
        this.InitializeComponent()

    member private this.ButtonViewSource_Click(sender : obj, e : RoutedEventArgs) =
        ViewSourceButtonHelper.ViewSource([
            ViewSourceButtonInfo(TabHeader = "ToolTip_Demo.xaml", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ToolTip/ToolTip_Demo.xaml");
            ViewSourceButtonInfo(TabHeader = "ToolTip_Demo.xaml.cs", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ToolTip/ToolTip_Demo.xaml.cs");
            ViewSourceButtonInfo(TabHeader = "ToolTip_Demo.xaml.vb", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ToolTip/ToolTip_Demo.xaml.vb");
            ViewSourceButtonInfo(TabHeader = "ToolTip_Demo.xaml.fs", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ToolTip/ToolTip_Demo.xaml.fs");
            ViewSourceButtonInfo(TabHeader = "DefaultToolTipStyle.xaml", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ToolTip/Styles/DefaultToolTipStyle.xaml")
        ])
