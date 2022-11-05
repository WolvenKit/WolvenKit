using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Wolvenkit.Installer.Models;
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class RemotePackageViewModel
{
    private readonly ILibraryService _libraryService;
    private readonly RemotePackageModel _model;

    public RemotePackageViewModel(
        RemotePackageModel model,
        //string version,
        string remoteVersion
        //bool isInstalled
        )
    {
        _libraryService = App.Current.Services.GetService<ILibraryService>();
        _model = model;

        //Version = version;
        RemoteVersion = remoteVersion;
        //IsInstalled = isInstalled;

    }

    public string Name => _model.Name;

    public string Description => _model.Description;

    public string ImagePath => _model.ImagePath;

    // Local
    //public string Version { get; }
    public string RemoteVersion { get; }
    //public bool IsInstalled { get; }

    [RelayCommand]
    private async Task Install()
    {
        await _libraryService.InstallAsync(_model);



    }
}

