using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Navigation;
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
internal partial class InstalledViewModel
{
    private readonly IDialogService _dialogService;
    private readonly ILibraryService _libraryService;

    public InstalledViewModel(IDialogService dialogService, ILibraryService libraryService)
    {
        _dialogService = dialogService;
        _libraryService = libraryService;

        foreach (var item in _libraryService.Apps)
        {
            InstalledApps.Add(new AppViewModel(item.IdStr, "", item.Version, false)
            {
                ImagePath = "ms-appx:///Assets/ControlImages/Acrylic.png"
            });
        }
    }

    public ObservableCollection<AppViewModel> InstalledApps { get; set; } = new();


}

[ObservableObject]
internal partial class AppViewModel
{
    public AppViewModel(string title, string imagePath, string version, bool installed)
    {
        Title = title;
        ImagePath = imagePath;
        Version = version;
        Installed = installed;
    }

    public string Title { get; set; }
    public string ImagePath { get; set; }
    public string Version { get; set; }
    public bool Installed { get; set; }
    //public string BadgeString { get; set; }
}
