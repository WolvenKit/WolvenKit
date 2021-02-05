
using Catel.IoC;
using MLib.Interfaces;
using SettingsModel.Interfaces;
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
            var appearance = ServiceLocator.Default.ResolveType<IAppearanceManager>();
			var set = ServiceLocator.Default.ResolveType<ISettingsManager>();


			CreateDefaultsSettings(set, appearance);


		}

		public static void CreateAppearanceSettings(IEngine options, ISettingsManager settings)
		{
			const string groupName = "Appearance";

			options.AddOption(groupName, "ThemeDisplayName", typeof(string), false, "VS 2013 Dark");
			options.AddOption(groupName, "ApplyWindowsDefaultAccent", typeof(bool), false, true);
			options.AddOption(groupName, "AccentColor", typeof(Color), false, Color.FromRgb(0x33, 0x99, 0xff));
		}

		private void CreateDefaultsSettings(ISettingsManager settings
										  , IAppearanceManager appearance)
		{
			//settings.Themes.RemoveAllThemeInfos();
			settings.Themes.AddThemeInfo("Generic", new List<Uri> { });
			settings.Themes.AddThemeInfo("VS 2013 Blue", new List<Uri> { });
			settings.Themes.AddThemeInfo("VS 2013 Dark", new List<Uri> { });
			settings.Themes.AddThemeInfo("VS 2013 Light", new List<Uri> { });



			try
			{
				// Adding Generic theme (which is really based on Light theme in MLib)
				// but other components may have another theme definition for Generic
				// so this is how it can be tested ...
				appearance.AddThemeResources("Generic", new List<Uri>
				{
					 new Uri("/MWindowLib;component/Themes/Generic.xaml", UriKind.RelativeOrAbsolute)
					,new Uri("/AvalonDock;component/Themes/generic.xaml", UriKind.RelativeOrAbsolute)

					,new Uri("/MLib;component/Themes/Generic.xaml", UriKind.RelativeOrAbsolute)
					,new Uri("/MLibTest;component/BindToMLib/MWindowLib_DarkLightBrushs.xaml", UriKind.RelativeOrAbsolute)

				}, settings.Themes);
			}
			catch (Exception)
			{
			}

			try
			{
				// Adding Generic theme (which is really based on Light theme in MLib)
				// but other components may have another theme definition for Generic
				// so this is how it can be tested ...
				appearance.AddThemeResources("VS 2013 Blue", new List<Uri>
				{
				   new Uri("/AvalonDock.Themes.VS2013;component/Themes/generic.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/AvalonDock.Themes.VS2013;component/BlueBrushs.xaml", UriKind.RelativeOrAbsolute)

				  ,new Uri("/MLib;component/Themes/Generic.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/MWindowLib;component/Themes/Generic.xaml", UriKind.RelativeOrAbsolute)

				  ,new Uri("/MLibTest;component/BindToMLib/MWindowLib_DarkLightBrushs.xaml", UriKind.RelativeOrAbsolute)
////				  ,new Uri("/MLibTest;component/BindToMLib/AvalonDock_Dark_LightBrushs.xaml", UriKind.RelativeOrAbsolute)

				}, settings.Themes);
			}
			catch (Exception)
			{
			}

			try
			{
				// Add additional Dark and Light resources to those theme resources added above
				appearance.AddThemeResources("VS 2013 Dark", new List<Uri>
				{
				   new Uri("/AvalonDock.Themes.VS2013;component/Themes/generic.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/AvalonDock.Themes.VS2013;component/DarkBrushs.xaml", UriKind.RelativeOrAbsolute)

				  ,new Uri("/MLib;component/Themes/DarkTheme.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/MWindowLib;component/Themes/DarkBrushs.xaml", UriKind.RelativeOrAbsolute)

				  ,new Uri("/MLibTest;component/BindToMLib/MWindowLib_DarkLightBrushs.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/MLibTest;component/BindToMLib/AvalonDock_Dark_LightBrushs.xaml", UriKind.RelativeOrAbsolute)

				}, settings.Themes);
			}
			catch (Exception)
			{
			}

			try
			{
				appearance.AddThemeResources("VS 2013 Light", new List<Uri>
				{
				   new Uri("/AvalonDock.Themes.VS2013;component/Themes/generic.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/AvalonDock.Themes.VS2013;component/LightBrushs.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/ColorPickerLib;component/Themes/LightBrushs.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/NumericUpDownLib;component/Themes/LightBrushs.xaml", UriKind.RelativeOrAbsolute)

				  ,new Uri("/MLib;component/Themes/LightTheme.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/MWindowLib;component/Themes/LightBrushs.xaml", UriKind.RelativeOrAbsolute)

				  ,new Uri("/MLibTest;component/BindToMLib/MWindowLib_DarkLightBrushs.xaml", UriKind.RelativeOrAbsolute)
				  ,new Uri("/MLibTest;component/BindToMLib/AvalonDock_Dark_LightBrushs.xaml", UriKind.RelativeOrAbsolute)

				}, settings.Themes);
			}
			catch (Exception)
            {
			}




			appearance.SetDefaultTheme(settings.Themes, "VS 2013 Light");


		}
	}
}
