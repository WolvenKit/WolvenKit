using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.IoC;
using Orchestra.Services;
using ReactiveUI;
using WolvenKit.Functionality.Controllers;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenManager.App.Services;

namespace WolvenKit.Functionality.Services
{
    public class ProjectManager : ObservableObject, IProjectManager
    {


        public IObservable<bool> IsLoadedObservable =>
            this.WhenAnyValue(
                x => x.IsLoaded);



        public IObservable<bool> IsUnloadedObservable =>
            this.WhenAnyValue(
                x => x.IsLoaded,
                (x) => x != true);


        public bool IsLoaded { get; set; }


        public EditorProject ActiveProject { get; private set; }


        public async Task<bool> SaveAsync() => await ActiveProject.Save();

        public async Task<bool> LoadAsync(string location)
        {
            IsLoaded = false;
            await ReadFromLocationAsync(location).ContinueWith(_ =>
            {
                if (_.IsCompletedSuccessfully)
                {
                    ActiveProject = _.Result;
                    IsLoaded = true;
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
