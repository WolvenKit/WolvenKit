// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectManagementCloseApplicationWatcher.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using Catel;
using Catel.Services;
using Orc.ProjectManagement;
using Orchestra;
using WolvenKit.Model;
using WolvenKit.Model.ProjectManagement;
using WolvenKit.Services;

namespace WolvenKit
{

    public class ProjectManagementCloseApplicationWatcher : CloseApplicationWatcherBase
    {
        private readonly IProjectManager _projectManager;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly ISaveProjectChangesService _saveProjectChangesService;

        public ProjectManagementCloseApplicationWatcher(IProjectManager projectManager, IPleaseWaitService pleaseWaitService,
            ISaveProjectChangesService saveProjectChangesService)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => pleaseWaitService);
            Argument.IsNotNull(() => saveProjectChangesService);

            _projectManager = projectManager;
            _pleaseWaitService = pleaseWaitService;
            _saveProjectChangesService = saveProjectChangesService;
        }

        protected override async Task<bool> ClosingAsync()
        {
            using (_pleaseWaitService.PushInScope())
            {
                var projects = _projectManager.Projects.OfType<EditorProject>().OrderByDescending(x => x.IsDirty).ToArray();

                for (var i = 0; i < projects.Length; i++)
                {
                    var project = projects[i];
                    project.ClearIsDirty();
                    var closed = await _projectManager.CloseAsync(project);
                    if (!closed)
                    {
                        return false;
                    }

                    _pleaseWaitService.UpdateStatus(i, projects.Length);
                }
            }

            return await base.ClosingAsync();
        }

        protected override async Task<bool> PrepareClosingAsync()
        {
            foreach (var project in _projectManager.Projects.OfType<EditorProject>())
            {
                if (!await _saveProjectChangesService.EnsureChangesSavedAsync(project, SaveChangesReason.Closing))
                {
                    return false;
                }
            }

            return await base.PrepareClosingAsync();
        }
    }
}