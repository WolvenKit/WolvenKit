using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.ProjectManagement;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Services;

/// <summary>
/// Singleton Service
/// </summary>
public partial class ProjectManager : ObservableObject, IProjectManager
{
    private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
    private readonly INotificationService _notificationService;
    private readonly ILoggerService _loggerService;
    private readonly IHashService _hashService;

    public ProjectManager(
        IRecentlyUsedItemsService recentlyUsedItemsService,
        INotificationService notificationService,
        ILoggerService loggerService,
        IHashService hashService
    )
    {
        _recentlyUsedItemsService = recentlyUsedItemsService;
        _notificationService = notificationService;
        _loggerService = loggerService;
        _hashService = hashService;
    }

    #region properties

    public event EventHandler<ActiveProjectChangedEventArgs>? ActiveProjectChanged;

    [ObservableProperty]
    private bool _isProjectLoaded;

    [ObservableProperty]
    private Cp77Project? _activeProject;

    partial void OnActiveProjectChanged(Cp77Project? value)
    {
        if (value is not null)
        {
            if (IsProjectLoaded)
            {
                Save();
            }

            ActiveProjectChangedEventArgs args = new(value);
            ActiveProjectChanged?.Invoke(this, args);
        }
       
    }

    #endregion

    #region commands

    public AsyncRelayCommand<string>? OpenProjectCommand { get; set; }

    #endregion

    #region methods

    public async Task<Cp77Project?> LoadAsync(string location)
    {
        if (IsProjectLoaded)
        {
            await SaveAsync();
        }

        IsProjectLoaded = false;
        await ReadFromLocationAsync(location).ContinueWith(x =>
        {
            if (x.IsCompletedSuccessfully)
            {
                if (x.Result == null)
                {

                }
                else
                {
                    ActiveProject = x.Result;
                    IsProjectLoaded = true;

                    if (_recentlyUsedItemsService.Items.Items.All(item => item.Name != location))
                    {
                        _recentlyUsedItemsService.AddItem(new RecentlyUsedItemModel(location, DateTime.Now, DateTime.Now));
                    }
                }
            }
            else
            {

            }
        });


        return ActiveProject;
    }

    private async Task<Cp77Project?> ReadFromLocationAsync(string location)
    {
        try
        {
            FileInfo fi = new(location);
            if (!fi.Exists)
            {
                return null;
            }

            var project = fi.Extension switch
            {
                ".cpmodproj" => await Load(location),
                _ => null
            };

            return project;
        }
        catch (IOException ex)
        {
            _notificationService.Error(ex.Message);
        }

        return null;
    }

    private async Task<Cp77Project?> Load(string path)
    {
        try
        {
            await using FileStream lf = new(path, FileMode.Open, FileAccess.Read);
            XmlSerializer ser = new(typeof(CP77Mod));
            if (ser.Deserialize(lf) is not CP77Mod obj)
            {
                return null;
            }

            if (obj.Name is null)
            {
                _loggerService.Error($"Failed to load project: project has no name");
                return null;
            }

            Cp77Project result = new(path, obj.Name, _hashService)
            {
                Author = obj.Author,
                Email = obj.Email,
                Version = obj.Version,
            };

            if (_hashService is HashService hashService)
            {
                hashService.ClearProjectHashes();

                var projectHashesFile = Path.Combine(result.ProjectDirectory, "project_hashes.txt");
                if (File.Exists(projectHashesFile))
                {
                    var paths = await File.ReadAllLinesAsync(projectHashesFile);
                    foreach (var p in paths)
                    {
                        hashService.AddProjectPath(p);
                    }
                }
            }


            // fix legacy folders
            MoveLegacyFolder(new DirectoryInfo(Path.Combine(result.FileDirectory, "tweaks")), result);
            MoveLegacyFolder(new DirectoryInfo(Path.Combine(result.FileDirectory, "scripts")), result);
            MoveLegacyFolder(new DirectoryInfo(Path.Combine(result.FileDirectory, "archiveXL")), result);

            return result;
        }
        catch (Exception e)
        {
            _loggerService.Error($"Failed to load project.");
            _loggerService.Error(e);
            return null;
        }
    }

    private void MoveLegacyFolder(DirectoryInfo dir, Cp77Project result)
    {
        if (dir.Exists)
        {
            var files = dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (var f in files)
            {
                try
                {
                    var relPath = Path.GetRelativePath(dir.FullName, f.FullName);
                    f.MoveTo(Path.Combine(result.ResourcesDirectory, relPath));
                }
                catch (Exception)
                {
                    _loggerService.Error($"Could not move {f.FullName}");
                }
            }

            try
            {
                dir.Delete();
            }
            catch (Exception)
            {
                _loggerService.Error($"Could not delete {dir.FullName}");
            }

        }
    }

    public async Task<bool> SaveAsync()
    {
        if (ActiveProject is null)
        {
            return false;
        }

        try
        {
            if (!Directory.Exists(ActiveProject.ProjectDirectory))
            {
                Directory.CreateDirectory(ActiveProject.ProjectDirectory);
            }

            await using FileStream fs = new(ActiveProject.Location, FileMode.Create, FileAccess.Write);
            XmlSerializer ser = new(typeof(CP77Mod));
            ser.Serialize(fs, new CP77Mod(ActiveProject));

            if (_hashService is HashService hashService)
            {
                var projectHashes = hashService.GetProjectHashes();
                if (projectHashes.Count > 0)
                {
                    await File.WriteAllLinesAsync(Path.Combine(ActiveProject.ProjectDirectory, "project_hashes.txt"), projectHashes);
                }
            }

            await fs.FlushAsync();
        }
        catch (Exception e)
        {
            _loggerService.Error($"Failed to save project");
            _loggerService.Error(e);
            return false;
        }

        return true;
    }

    public bool Save()
    {
        if (ActiveProject is null)
        {
            return false;
        }

        try
        {
            if (!Directory.Exists(ActiveProject.ProjectDirectory))
            {
                Directory.CreateDirectory(ActiveProject.ProjectDirectory);
            }

            using FileStream fs = new(ActiveProject.Location, FileMode.Create, FileAccess.Write);
            XmlSerializer ser = new(typeof(CP77Mod));
            ser.Serialize(fs, new CP77Mod(ActiveProject));

            if (_hashService is HashService hashService)
            {
                var projectHashes = hashService.GetProjectHashes();
                if (projectHashes.Count > 0)
                {
                    File.WriteAllLines(Path.Combine(ActiveProject.ProjectDirectory, "project_hashes.txt"), projectHashes);
                }
            }

            fs.Flush();
        }
        catch (Exception e)
        {
            _loggerService.Error($"Failed to save project");
            _loggerService.Error(e);
            return false;
        }

        return true;
    }

    #endregion
}

public class ActiveProjectChangedEventArgs : EventArgs
{
    public Cp77Project Project { get; set; }

    public ActiveProjectChangedEventArgs(Cp77Project project) => Project = project;
}