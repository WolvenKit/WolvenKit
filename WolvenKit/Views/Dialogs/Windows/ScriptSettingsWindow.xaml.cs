using System.Windows;
using WolvenKit.App.Scripting;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class ScriptSettingsWindow : Window
{
    public ScriptSettingsWindow(ScriptSettingsDictionary scriptSettings)
    {
        InitializeComponent();

        ScriptSettingsPropertyGrid.SelectedObject = scriptSettings;
    }

    private void OkButton_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
    }

    private void CancelButton_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }
}
