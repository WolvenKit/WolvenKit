using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Wolvenkit.Installer.Models;
using Wolvenkit.Installer.ViewModel;

namespace Wolvenkit.Installer.Services;

public interface ILibraryService
{
    ObservableCollection<PackageViewModel> InstalledPackages { get; }

    ObservableCollection<RemotePackageViewModel> RemotePackages { get; set; }

    Task CheckForUpdateAsync(string id);
    Task InstallAsync(string id);
    Task InitAsync();
}

public class LibraryService : ILibraryService
{
    public const string FileName = "library.json";

    public ObservableCollection<PackageViewModel> InstalledPackages { get; private set; } = new();
    public ObservableCollection<RemotePackageViewModel> RemotePackages { get; set; } = new();

    public static string GetAppData()
    {
        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit.Installer");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public async Task InitAsync()
    {
        // load installed packages
        await LoadAsync();

        // get remote info
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"Wolvenkit.Installer.Resources.AvailableApps.json");
        var apps = await JsonSerializer.DeserializeAsync<List<RemotePackageModel>>(stream,
            new JsonSerializerOptions()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });

        // viewmodels
        foreach (var item in apps)
        {
            // TODO get remote versions here

            // TODO check if installed

            RemotePackages.Add(new(item, "", EPackageStatus.NotInstalled));
        }
    }

    private async Task LoadAsync()
    {
        var file = Path.Combine(GetAppData(), FileName);

        if (File.Exists(file))
        {
            try
            {
                var json = await File.ReadAllTextAsync(file);
                var installed = System.Text.Json.JsonSerializer.Deserialize<List<PackageModel>>(json, new System.Text.Json.JsonSerializerOptions()
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                });
                //Apps = new(installed);

                foreach (var item in installed)
                {
                    InstalledPackages.Add(new PackageViewModel(item.IdStr, "ms-appx:///Assets/ControlImages/Acrylic.png", item.Version, false)
                    {
                    });
                }

            }
            catch (Exception ex)
            {
                // TODO logging
                throw;
            }
        }
        else
        {
            InstalledPackages = new();
        }

        // dng
        InstalledPackages.Add(new("TEST", "ms-appx:///Assets/ControlImages/Acrylic.png", "1.0", false));
        InstalledPackages.Add(new("TEST2", "ms-appx:///Assets/ControlImages/Acrylic.png", "2.0", false));
    }


    public async Task CheckForUpdateAsync(string id) => await Task.Delay(1000);

    public async Task InstallAsync(string id) => await Task.Delay(1000);
}

