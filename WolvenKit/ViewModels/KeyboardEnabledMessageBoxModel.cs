using System.Windows.Input;
using AdonisUI.Controls;

namespace WolvenKit.ViewModels;

public class KeyboardEnabledMessageBoxWindow : MessageBoxWindow
{
    public KeyboardEnabledMessageBoxWindow()
    {
        this.KeyDown += OnKeyDown;
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            // Simulate OK button click
            this.DialogResult = true;
        }
        else if (e.Key == Key.Escape)
        {
            // Simulate Cancel button click
            this.DialogResult = false;
        }
    }
}