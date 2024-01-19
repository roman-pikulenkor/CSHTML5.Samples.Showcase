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

type MediaElement_Demo() as this =
    inherit MediaElement_DemoXaml()
    
    do
        this.InitializeComponent()

    member private this.ButtonViewSource_Click(sender : obj, e : RoutedEventArgs) =
        ViewSourceButtonHelper.ViewSource([
            ViewSourceButtonInfo(TabHeader = "MediaElement_Demo.xaml", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/MediaElement/MediaElement_Demo.xaml");
            ViewSourceButtonInfo(TabHeader = "MediaElement_Demo.xaml.cs", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/MediaElement/MediaElement_Demo.xaml.cs");
            ViewSourceButtonInfo(TabHeader = "MediaElement_Demo.xaml.vb", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/MediaElement/MediaElement_Demo.xaml.vb");
            ViewSourceButtonInfo(TabHeader = "MediaElement_Demo.xaml.fs", FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/MediaElement/MediaElement_Demo.xaml.fs")
        ])

    member this.ButtonToPlayAudio_Click(sender : obj, e : RoutedEventArgs) =
        this.MediaElementForAudio.Play()

    member this.ButtonToPauseAudio_Click(sender : obj, e : RoutedEventArgs) =
        this.MediaElementForAudio.Pause()

    member this.ButtonToPlayVideo_Click(sender : obj, e : RoutedEventArgs) =
        this.MediaElementForVideo.Play()

    member this.ButtonToPauseVideo_Click(sender : obj, e : RoutedEventArgs) =
        this.MediaElementForVideo.Pause()
