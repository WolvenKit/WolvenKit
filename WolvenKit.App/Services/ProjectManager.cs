using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using System.Xml.Serialization;
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

        [Reactive] public EditorProject ActiveProject { get; set; }

        #endregion

        #region commands

        public ReactiveCommand<string, Unit> OpenProjectCommand { get; set; }


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
            await ReadFromLocationAsync(location).ContinueWith(_ =>
            {
                if (_.IsCompletedSuccessfully)
                {
                    if (_.Result == null)
                    {
                    }
                    else
                    {
                        ActiveProject = _.Result;
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

        private async Task<EditorProject> ReadFromLocationAsync(string location)
        {
            try
            {
                FileInfo fi = new(location);
                if (!fi.Exists)
                {
                    return null;
                }

                EditorProject project = fi.Extension switch
                {
                    //".w3modproj" => await Load<Tw3Project>(location),
                    ".cpmodproj" => await Load<Cp77Project>(location),
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

        private async Task<EditorProject> Load<T>(string path) where T : EditorProject
        {
            try
            {
                await using FileStream lf = new(path, FileMode.Open, FileAccess.Read);
                XmlSerializer ser = new(typeof(CP77Mod));
                if (ser.Deserialize(lf) is not CP77Mod obj)
                {
                    return null;
                }

                if (typeof(T) != typeof(Cp77Project))
                {
                    return null;
                }

                Cp77Project result = new(path)
                {
                    Author = obj.Author,
                    Email = obj.Email,
                    Name = obj.Name,
                    Version = obj.Version,
                };

                string projectHashesFile = Path.Combine(result.ProjectDirectory, "project_hashes.txt");
                if (File.Exists(projectHashesFile) && _hashService is HashService hashService)
                {
                    string[] paths = await File.ReadAllLinesAsync(projectHashesFile);
                    foreach (string p in paths)
                    {
                        hashService.AddProjectPath(p);
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                _loggerService.Error($"Failed to load project.");
                _loggerService.Error(e);
                return null;
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
                    System.Collections.Generic.List<string> projectHashes = hashService.GetProjectHashes();
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

            public CP77Mod(EditorProject project)
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
