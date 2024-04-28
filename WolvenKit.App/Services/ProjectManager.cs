using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.ProjectManagement;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common;
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
    private readonly IArchiveManager _archiveManager;

    public ProjectManager(
        IRecentlyUsedItemsService recentlyUsedItemsService,
        INotificationService notificationService,
        ILoggerService loggerService,
        IHashService hashService,
        IArchiveManager archiveManager
    )
    {
        _recentlyUsedItemsService = recentlyUsedItemsService;
        _notificationService = notificationService;
        _loggerService = loggerService;
        _hashService = hashService;
        _archiveManager = archiveManager;
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
                    _archiveManager.ProjectArchive = x.Result.AsArchive();
                    IsProjectLoaded = true;

                    var recentItem = _recentlyUsedItemsService.Items.Items.FirstOrDefault(item => item.Name == location);
                    if (recentItem == null)
                    {
                        recentItem = new RecentlyUsedItemModel(location, DateTime.Now, DateTime.Now);
                        _recentlyUsedItemsService.AddItem(recentItem);
                    }
                    else
                    {
                        recentItem.LastOpened = DateTime.Now;
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

            obj.ModName ??= obj.Name;

            Cp77Project project = new(path, obj.Name, obj.ModName)
            {
                Author = obj.Author,
                Email = obj.Email,
                Description = obj.Description,
                Version = obj.Version,
            };

            if (_hashService is HashServiceExt hashService)
            {
                hashService.LoadProjectCache(project);
            }

            // fix legacy folders
            MoveLegacyFolder(new DirectoryInfo(Path.Combine(project.FileDirectory, "tweaks")), project);
            MoveLegacyFolder(new DirectoryInfo(Path.Combine(project.FileDirectory, "scripts")), project);
            MoveLegacyFolder(new DirectoryInfo(Path.Combine(project.FileDirectory, "archiveXL")), project);

            // fix legacy yaml tweaks
            MoveLegacyYamlTweaks(project);

            return project;
        }
        catch (Exception e)
        {
            _loggerService.Error($"Failed to load project.");
            _loggerService.Error(e);
            return null;
        }
    }

    private void MoveLegacyYamlTweaks(Cp77Project project)
    {
        var yamlFiles = Directory.GetFiles(project.ResourcesDirectory, "*.yaml", SearchOption.TopDirectoryOnly);
        foreach (var file in yamlFiles)
        {
            var fileName = Path.GetFileName(file);
            var destPath = Path.Combine(project.ResourceTweakDirectory, fileName);
            try
            {
                File.Move(file, destPath);
                _loggerService.Info($"Yaml tweak file was moved to the new location: {fileName}");
            }
            catch (Exception e)
            {
                _loggerService.Error($"Could not move file. Error: {e}");
            }
            
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

            if (_hashService is HashServiceExt hashService)
            {
                hashService.SaveProjectCache(ActiveProject);
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

            if (_hashService is HashServiceExt hashService)
            {
                hashService.SaveProjectCache(ActiveProject);
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