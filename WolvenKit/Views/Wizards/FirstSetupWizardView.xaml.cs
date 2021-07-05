using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Catel.IoC;
using Catel.Services;
using ControlzEx.Theming;
using WolvenKit.Core;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Wizards;
using Path = System.IO.Path;

namespace WolvenKit.Views.Wizards
{
    public partial class FirstSetupWizardView
    {
        #region Fields

        //private bool _filled = false;

        //private Brush _lastaccent;

        #endregion Fields

        #region Constructors

        public FirstSetupWizardView()
        {
            InitializeComponent();
        }

        #endregion Constructors
        //private void Circle_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    var a = (Ellipse)sender;
        //    _lastaccent = a.Fill;
        //    //a.Fill = new SolidColorBrush(Colors.AliceBlue);
        //}

        //private void Circle_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    var a = (Ellipse)sender;
        //    a.Fill = _lastaccent;
        //}

        //private void Circle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var a = (Ellipse)sender;
        //    //a.Fill = new SolidColorBrush(Colors.Black);
        //    //ThemeManager.Current.ChangeTheme(Application.Current, "Dark." + a.Name);

        //    try
        //    {
        //        var color = ((SolidColorBrush)a.Fill).Color;
        //        var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
        //        settings.SetThemeAccent(color);
        //    }
        //    catch
        //    {
        //        // swallow
        //    }
        //}

        #region Methods

        private void UserControl_Initialized_1(object sender, EventArgs e)
        {
            //if (!_filled)
            //{
            //    new Thread(() =>
            //    {
            //        foreach (var Theme in ThemeManager.Current.Themes)
            //        {
            //            Thread.Sleep(15);
            //            if (Theme.BaseColorScheme == "Dark")
            //            {
            //                if (!Theme.DisplayName.Contains("Colorful"))
            //                {
            //                    if (!Theme.DisplayName.Contains('#'))
            //                    {
            //                        Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            //                        {
            //                            var circle = new Ellipse
            //                            {
            //                                Height = 25,
            //                                Width = 25,
            //                                Margin = new Thickness(5)
            //                            };
            //                            circle.MouseEnter += Circle_MouseEnter;
            //                            circle.MouseLeave += Circle_MouseLeave;
            //                            circle.MouseLeftButtonDown += Circle_MouseLeftButtonDown;
            //                            circle.Name = Theme.DisplayName.Split('(')[0].ToString().Trim();
            //                            circle.Fill = Theme.ShowcaseBrush;

            //                            CircleTest.Children.Add(circle);
            //                        }));
            //                    }
            //                }
            //            }
            //        }
            //    }).Start();
            //}
            //_filled = true;
        }


        #region Validation

       private void Field_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => validateAllFields();

        private void validateAllFields()
        {
            if (ViewModel is FirstSetupWizardViewModel vm)
            {
                vm.AllFieldsValid = /*projectNameTxtbx.VerifyData() &&*/ cp77ExeTxtb.VerifyData();
            }
        }

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            if (File.Exists(str) && System.IO.Path.GetFileName(str).Equals(Core.Constants.Red4Exe))
            {
                var oodle = Path.Combine(new FileInfo(str).Directory.FullName, Constants.Oodle);
                if (!File.Exists(oodle))
                {
                    ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    ValidationText.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty,
                        $"Oodle dll was not found with the game. Please make sure you have {Constants.Oodle} next to your game executable.");
                    return HandyControl.Data.OperationResult.Failed();
                }
                ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                return HandyControl.Data.OperationResult.Success();
            }

            ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            ValidationText.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty,
                "Game exe location was not found.");
            return HandyControl.Data.OperationResult.Failed();
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str) => System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed();

        #endregion Methods


        #endregion Methods

    }
}
