using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using WolvenKit.Red3.UI.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WolvenKit.Red3.UI.Pages;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class ProjectExplorerPage : Page
{
    public ProjectExplorerPage()
    {
        InitializeComponent();

        ViewModel = App.Current.Services.GetService<ProjectExplorerViewModel>();
    }

    internal ProjectExplorerViewModel ViewModel { get; set; }

    private async void TreeViewItem_DoubleTapped(object sender, Microsoft.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
    {
        if (sender is TreeViewItem item && item.DataContext is ExplorerItem vm)
        {
            var fullPath = vm.FullName;
            // open file
            await ViewModel.OpenFileAsync(fullPath);
        }
    }
}
