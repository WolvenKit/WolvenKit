using System;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Catel.IoC;
using ControlzEx.Theming;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class SelectThemeView
    {
        #region Fields

        private bool c_ColorsLoaded = false;

        private Brush c_LastAccentBrush;

        #endregion Fields

        #region Constructors

        public SelectThemeView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void Circle_MouseEnter(object sender, MouseEventArgs e)
        {
            var m_Sender = (Ellipse)sender;
            c_LastAccentBrush = m_Sender.Fill;
            m_Sender.Fill = new SolidColorBrush(Colors.AliceBlue);
        }

        private void Circle_MouseLeave(object sender, MouseEventArgs e)
        {
            var m_Sender = (Ellipse)sender;
            m_Sender.Fill = c_LastAccentBrush;
        }

        private void Circle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           var m_Sender = (Ellipse)sender;
           var m_color = ((SolidColorBrush)m_Sender.Fill).Color;
           var m_settings = ServiceLocator.Default.ResolveType<ISettingsManager>();

           m_settings.ThemeAccent = m_color;
           m_settings.Save();

        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            // #RemoveThis
        }

        private void ThemeColorsHoney_Loaded(object sender, RoutedEventArgs e)
        {
            // #RemoveThis

        }

        private void UserControl_Initialized_1(object sender, EventArgs e)
        {
            if (!c_ColorsLoaded)
            {
                new Thread(() =>
                {
                    foreach (var Theme in ThemeManager.Current.Themes)
                    {
                        Thread.Sleep(15);
                        if (Theme.BaseColorScheme == "Dark")
                        {
                            if (!Theme.DisplayName.Contains("Colorful"))
                            {
                                if (!Theme.DisplayName.Contains('#'))
                                {
                                    Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                                    {
                                        var circle = new Ellipse
                                        {
                                            Height = 25,
                                            Width = 25,
                                            Margin = new Thickness(5)
                                        };
                                        circle.MouseEnter += Circle_MouseEnter;
                                        circle.MouseLeave += Circle_MouseLeave;
                                        circle.MouseLeftButtonDown += Circle_MouseLeftButtonDown;
                                        circle.Name = Theme.DisplayName.Split('(')[0].ToString().Trim();
                                        circle.Fill = Theme.ShowcaseBrush;

                                        CircleTest.Children.Add(circle);
                                    }));
                                }
                            }
                        }
                    }
                }).Start();
            }
            c_ColorsLoaded = true;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) => ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>().AllFieldIsValid = true;

        #endregion Methods
    }
}
