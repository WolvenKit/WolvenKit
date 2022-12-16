using System;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;

namespace WolvenKit.Red3.UI.Services;
public interface IDialogService
{
    Task DisplayAlert(string title, string message, string cancel);
}

public class DialogService : IDialogService
{
    public async Task DisplayAlert(string title, string message, string cancel)
    {
        ContentDialog dlg = new()
        {
            Title = title,
            Content = message,
            CloseButtonText = cancel,

            XamlRoot = App.MainRoot.XamlRoot,
        };

        await dlg.ShowAsync();
    }
}
