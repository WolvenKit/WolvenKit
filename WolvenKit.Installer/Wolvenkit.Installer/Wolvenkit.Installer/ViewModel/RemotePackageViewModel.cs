using CommunityToolkit.Mvvm.ComponentModel;
using Wolvenkit.Installer.Models;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class RemotePackageViewModel
{
    private readonly RemotePackageModel _model;

    public RemotePackageViewModel(RemotePackageModel model, string version, EPackageStatus status)
    {
        _model = model;

        Name = model.Name;
        Description = model.Description;

        Version = version;
        Status = status;
    }

    public string Name { get; }

    public string Description { get; }


    // Local
    public string Version { get; }
    public EPackageStatus Status { get; }
}

public enum EPackageStatus
{
    NotInstalled,
    UpdateAvailable,
    Installed,
}