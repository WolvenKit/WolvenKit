
using Catel.IoC;
using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using WolvenKit.Services;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class UserPageView
    {
        public UserPageView()
        {
            InitializeComponent();
            CoverFlowMain.AddRange(new[]
{
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
    new Uri(@"pack://application:,,,/Resources/Images/RedEngine/detail.png"),
});
            CoverFlowMain.JumpTo(2);
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {



		}

		
	}
}
