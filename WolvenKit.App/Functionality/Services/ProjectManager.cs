using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using Orchestra.Models;
using Orchestra.Services;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Functionality.Controllers;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenManager.App.Services;
using ObservableObject = Catel.Data.ObservableObject;

namespace WolvenKit.Functionality.Services
{
    public class ProjectManager : ObservableObject, IProjectManager
    {
        public ProjectManager()
        {
            this.WhenAnyValue(x => x.ActiveProject.Data).Subscribe(async _ =>
            {
                if (IsProjectLoaded)
                {
                    await SaveAsync();
                }
            });
        }

        public bool IsProjectLoaded { get; set; }

        public EditorProject ActiveProject { get; private set; }



        public async Task<bool> SaveAsync() => await ActiveProject.Save();

        public async Task<bool> LoadAsync(string location)
        {
            var recentlyUsedItemsService = WolvenServiceLocator.Default.ResolveType<IRecentlyUsedItemsService>();

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

                        if (recentlyUsedItemsService.Items.All(item => item.Name != location))
                        {
                            recentlyUsedItemsService.AddItem(new RecentlyUsedItem(location, DateTime.Now));
                        }
                    }
                }
                else
                {
                    
                }
            });


            return true;
        }

        private static async Task<EditorProject> ReadFromLocationAsync(string location)
        {
            var notificationService = ServiceLocator.Default.ResolveType<IGrowlNotificationService>();
            var watcherService = ServiceLocator.Default.ResolveType<IWatcherService>();

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
                        MainController.Get().ActiveMod = project.Data;
                        await MainController.SetGame(new Tw3Controller())
                            .ContinueWith(t =>
                            {
                                notificationService.Success(
                                    "Project " + Path.GetFileNameWithoutExtension(location) +
                                    " loaded!");

                            }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    }
                    case ".cpmodproj":
                    {
                        project = new Cp77Project(location);
                        MainController.Get().ActiveMod = project.Data;
                        await MainController.SetGame(new Cp77Controller())
                            .ContinueWith(
                                t =>
                                {
                                    notificationService.Success("Project " +
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
                notificationService.Error(ex.Message);
            }

            return null;
        }
    }
}
