
using System.Windows.Input;
using AdonisUI.Controls;

namespace WolvenKit.ViewModels;

public class KeyboardEnabledMessageBoxWindow : MessageBoxWindow
{
    public KeyboardEnabledMessageBoxWindow() => KeyDown += OnKeyDown;

    private void OnKeyDown(object sender, KeyEventArgs e) =>
        DialogResult = e.Key switch
        {
            Key.Enter => true,
            Key.Escape => false,
            _ => DialogResult
        };
}