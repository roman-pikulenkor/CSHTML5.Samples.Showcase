﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#if SLMIGRATION
using System.Windows;
using System.Windows.Controls;
#else
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#endif

namespace OpenSilver.Samples.Showcase
{
    public partial class WebView_Demo : UserControl
    {
        public WebView_Demo()
        {
            this.InitializeComponent();
        }

        private void ButtonNavigate_Click(object sender, RoutedEventArgs e)
        {
            WebView1.Navigate(new Uri(TextBoxWithURL.Text));
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "WebBrowser_Demo.xaml",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/OpenSilver.Samples.Showcase/Samples/Interop_Samples/WebView/WebBrowser_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "WebBrowser_Demo.xaml.cs",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/OpenSilver.Samples.Showcase/Samples/Interop_Samples/WebView/WebBrowser_Demo.xaml.cs"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "WebBrowser_Demo.xaml.vb",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/OpenSilver.Samples.Showcase/Samples/Interop_Samples/WebView/WebBrowser_Demo.xaml.vb"
                }
            });
        }
    }
}
