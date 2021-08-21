using System;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

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

        public ProjectManager(
            IRecentlyUsedItemsService recentlyUsedItemsService,
            INotificationService notificationService,
            ILoggerService loggerService
        )
        {
            _recentlyUsedItemsService = recentlyUsedItemsService;
            _notificationService = notificationService;
            _loggerService = loggerService;

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
                            _recentlyUsedItemsService.AddItem(new RecentlyUsedItemModel(location, DateTime.Now));
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
                var fi = new FileInfo(location);
                if (!fi.Exists)
                {
                    return null;
                }

                var project = fi.Extension switch
                {
                    //".w3modproj" => await Load<Tw3Project>(location),
                    ".cpmodproj" => await Load<Cp77Project>(location),
                    _ => null
                };

                return await Task.FromResult(project);
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
                await using var lf = new FileStream(path, FileMode.Open, FileAccess.Read);
                var ser = new XmlSerializer(typeof(CP77Mod));
                if (ser.Deserialize(lf) is not CP77Mod obj)
                {
                    return null;
                }

                //if (typeof(T) == typeof(Tw3Project))
                //{
                //    return new Tw3Project(path)
                //    {
                //        Author = obj.Author,
                //        Email = obj.Email,
                //        Name = obj.Name,
                //        Version = obj.Version,
                //    };
                //}
                /*else*/ if (typeof(T) == typeof(Cp77Project))
                {
                    return new Cp77Project(path)
                    {
                        Author = obj.Author,
                        Email = obj.Email,
                        Name = obj.Name,
                        Version = obj.Version,
                    };
                }
                return null;
            }
            catch (Exception e)
            {
                _loggerService.Error($"Failed to load project. Exception: {e.Message}");
                return null;
            }
        }

        private async Task<bool> Save()
        {
            try
            {
                await using var fs = new FileStream(ActiveProject.Location, FileMode.Create, FileAccess.Write);
                var ser = new XmlSerializer(typeof(CP77Mod));
                ser.Serialize(fs, new CP77Mod(ActiveProject));

            }
            catch (Exception e)
            {
                _loggerService.Error($"Failed to save project. Exception: {e.Message}");
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
        }
    }
}
