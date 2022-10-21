using CommunityToolkit.Mvvm.ComponentModel;
using Wolvenkit.Installer.Models;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
internal partial class RemotePackageViewModel
{
    private readonly RemotePackageModel _model;

    public RemotePackageViewModel(RemotePackageModel model, string version)
    {
        _model = model;

        Name = model.Name;
        Description = model.Description;

        Version = version;
    }

    public string Name { get; }

    public string Description { get; }

    public string Version { get; }
}
