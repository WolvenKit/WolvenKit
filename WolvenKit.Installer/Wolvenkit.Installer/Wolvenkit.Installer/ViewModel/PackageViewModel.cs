using CommunityToolkit.Mvvm.ComponentModel;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class PackageViewModel
{
    public PackageViewModel(string title, string imagePath, string version, EPackageStatus installed)
    {
        Title = title;
        ImagePath = imagePath;
        Version = version;
        Installed = installed;
    }

    public string Title { get; set; }
    public string ImagePath { get; set; }


    public string Version { get; set; }
    public EPackageStatus Installed { get; set; }
}

public enum EPackageStatus
{
    NotInstalled,
    Installed,
    UpdateAvailable,
}