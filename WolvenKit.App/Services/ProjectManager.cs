using System;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.ProjectManagement.Project;

namespace WolvenKit.Functionality.Services
{
    /// <summary>
    /// Singleton Service
    /// </summary>
    public class ProjectManager : ReactiveObject, IProjectManager
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

            this.WhenAnyValue(x => x.ActiveProject).Subscribe(async _ =>
            {
                if (IsProjectLoaded)
                {
                    await SaveAsync();
                }
            });
        }

        #region properties

        [Reactive] public bool IsProjectLoaded { get; set; }

        [Reactive] public Cp77Project? ActiveProject { get; set; }

        #endregion

        #region commands

        public ReactiveCommand<string, Unit>? OpenProjectCommand { get; set; }

        #endregion

        #region methods

        public async Task<bool> SaveAsync() => await Save();

        public async Task<bool> LoadAsync(string location)
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


            return true;
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

                Cp77Project result = new(path, obj.Name)
                {
                    Author = obj.Author,
                    Email = obj.Email,
                    Version = obj.Version,
                };

                var projectHashesFile = Path.Combine(result.ProjectDirectory, "project_hashes.txt");
                if (File.Exists(projectHashesFile) && _hashService is HashService hashService)
                {
                    var paths = await File.ReadAllLinesAsync(projectHashesFile);
                    foreach (var p in paths)
                    {
                        hashService.AddProjectPath(p);
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

        private async Task<bool> Save()
        {
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


        public class CP77Mod
        {
            public CP77Mod()
            {

            }

            public CP77Mod(Cp77Project project)
            {
                Author = project.Author;
                Email = project.Email;
                Name = project.Name;
                Version = project.Version;
            }

            public string Author { get; set; }

            public string Email { get; set; }

            public string Name { get; set; }

            public string Version { get; set; }
            public bool IsRedMod { get; set; }
            public bool ExecuteDeploy { get; set; }
        }
    }
}
