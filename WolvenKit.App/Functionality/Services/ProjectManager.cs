using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel.IoC;
using Orchestra.Models;
using Orchestra.Services;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenManager.App.Services;
using ObservableObject = Catel.Data.ObservableObject;

namespace WolvenKit.Functionality.Services
{
    /// <summary>
    /// Singleton Service
    /// </summary>
    public class ProjectManager : ObservableObject, IProjectManager
    {
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly IGrowlNotificationService _notificationService;
        private readonly IWatcherService _watcherService;
        private readonly ILoggerService _loggerService;

        
        


        public ProjectManager(
            IRecentlyUsedItemsService recentlyUsedItemsService,
            IGrowlNotificationService notificationService,
            IWatcherService watcherService,
            ILoggerService loggerService
        )
        {
            _recentlyUsedItemsService = recentlyUsedItemsService;
            _notificationService = notificationService;
            _watcherService = watcherService;
            _loggerService = loggerService;

            this.WhenAnyValue(x => x.ActiveProject).Subscribe(async _ =>
            {
                if (IsProjectLoaded)
                {
                    await SaveAsync();
                }
            });
        }

        public bool IsProjectLoaded { get; set; }

        public EditorProject ActiveProject { get; private set; }

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

                        if (_recentlyUsedItemsService.Items.All(item => item.Name != location))
                        {
                            _recentlyUsedItemsService.AddItem(new RecentlyUsedItem(location, DateTime.Now));
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

                EditorProject project = null;
                switch (fi.Extension)
                {
                    case ".w3modproj":
                    {
                        project = new Tw3Project(location);
                        ServiceLocator.Default.RegisterType<IGameController, Tw3Controller>();

                        await ServiceLocator.Default.ResolveType<IGameController>().HandleStartup()
                            .ContinueWith(t =>
                            {
                                _notificationService.Success(
                                    "Project " + Path.GetFileNameWithoutExtension(location) +
                                    " loaded!");

                            }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    }
                    case ".cpmodproj":
                    {
                        project = new Cp77Project(location);
                        ServiceLocator.Default.RegisterType<IGameController, Cp77Controller>();
                        await ServiceLocator.Default.ResolveType<IGameController>().HandleStartup()
                            .ContinueWith(
                                t =>
                                {
                                    _notificationService.Success("Project " +
                                                                 Path.GetFileNameWithoutExtension(location) +
                                                                 " loaded!");

                                },
                                TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    }
                }

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
                var ser = new XmlSerializer(typeof(T));
                var obj = (T)ser.Deserialize(lf);
                return obj;
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
                await using var sf = new FileStream(ActiveProject.Location, FileMode.Create, FileAccess.Write);
                var ser = new XmlSerializer(typeof(EditorProject));
                ser.Serialize(sf, ActiveProject);
            }
            catch (Exception e)
            {
                _loggerService.Error($"Failed to save project. Exception: {e.Message}");
                return false;
            }

            return true;
        }
    }
}
