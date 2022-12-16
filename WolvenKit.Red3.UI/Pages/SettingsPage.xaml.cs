using System.Linq;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using WolvenKit.Red3.UI.Helpers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WolvenKit.Red3.UI.Pages;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class SettingsPage : Page
{
    public SettingsPage()
    {
        InitializeComponent();
        Loaded += OnSettingsPageLoaded;
    }

    private void OnSettingsPageLoaded(object sender, RoutedEventArgs e)
    {
        var currentTheme = ThemeHelper.RootTheme.ToString();
        ThemePanel.Children.Cast<RadioButton>().FirstOrDefault(c => c?.Tag?.ToString() == currentTheme).IsChecked = true;


    }

    private void OnThemeRadioButtonChecked(object sender, RoutedEventArgs e)
    {
        var selectedTheme = ((RadioButton)sender)?.Tag?.ToString();

        var res = Microsoft.UI.Xaml.Application.Current.Resources;
        void SetTitleBarButtonForegroundColor(Windows.UI.Color color) => res["WindowCaptionForeground"] = color;

        if (selectedTheme != null)
        {
            ThemeHelper.RootTheme = App.GetEnum<ElementTheme>(selectedTheme);
            if (selectedTheme == "Dark")
            {
                SetTitleBarButtonForegroundColor(Colors.White);
            }
            else if (selectedTheme == "Light")
            {
                SetTitleBarButtonForegroundColor(Colors.Black);
            }
            else
            {
                if (Application.Current.RequestedTheme == ApplicationTheme.Dark)
                {
                    SetTitleBarButtonForegroundColor(Colors.White);
                }
                else
                {
                    SetTitleBarButtonForegroundColor(Colors.Black);
                }
            }
        }
        var window = WindowHelper.GetWindowForElement(this);
        //TitleBarHelper.triggerTitleBarRepaint(window);

    }

    private void OnThemeRadioButtonKeyDown(object sender, KeyRoutedEventArgs e)
    {

    }
}
