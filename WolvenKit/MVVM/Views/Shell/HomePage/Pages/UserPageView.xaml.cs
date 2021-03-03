
using Catel.IoC;
using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages
{
    public partial class UserPageView
    {
        public UserPageView()
        {
            InitializeComponent();
            CoverFlowMain.AddRange(new[]
{
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
});
            asd3423.AddRange(new[]
{
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
});

            dsfdsf.AddRange(new[]
{
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Media/Images/RedEngine/detail.png"),
});
            CoverFlowMain.JumpTo(2);
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {



		}


        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("User Page");
            }

        }


    }
}
