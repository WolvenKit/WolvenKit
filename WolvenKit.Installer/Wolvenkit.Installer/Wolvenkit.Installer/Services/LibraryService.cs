using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wolvenkit.Installer.Models;

namespace Wolvenkit.Installer.Services;
internal class LibraryService : ILibraryService
{
    public const string FileName = "library.json";

    public List<AppModel> Apps { get; private set; }

    public static string GetAppData()
    {
        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit.Installer");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public async Task LoadAsync()
    {
        var file = Path.Combine(GetAppData(), FileName);

        if (File.Exists(file))
        {
            try
            {
                var json = await File.ReadAllTextAsync(file);
                var installed = System.Text.Json.JsonSerializer.Deserialize<List<AppModel>>(json, new System.Text.Json.JsonSerializerOptions()
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                });
                Apps = installed;
            }
            catch (Exception ex)
            {
                // TODO logging
                throw;
            }
        }
        else
        {
            Apps = new List<AppModel>();
        }

        // dng
        Apps.Add(new("TEST", "1.0"));
        Apps.Add(new("TEST2", "2.0"));
    }
}

internal interface ILibraryService
{
    List<AppModel> Apps { get; }

    Task LoadAsync();



}