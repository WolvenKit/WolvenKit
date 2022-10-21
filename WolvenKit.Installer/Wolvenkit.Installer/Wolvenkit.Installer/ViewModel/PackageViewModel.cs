using CommunityToolkit.Mvvm.ComponentModel;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class PackageViewModel
{
    public PackageViewModel(string title, string imagePath, string version, bool installed)
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
