// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SaveProjectChangesService.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using WolvenKit.Model;
using WolvenKit.Model.Project;

namespace WolvenKit.Model.ProjectManagement
{
    using System.Threading.Tasks;
    using Catel;
    using Catel.Reflection;
    using Catel.Services;
    using Orc.ProjectManagement;

    public class SaveProjectChangesService : ISaveProjectChangesService
    {
        #region Fields
        private readonly IMessageService _messageService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IProjectManager _projectManager;
        #endregion

        #region Constructors
        public SaveProjectChangesService(IProjectManager projectManager, IPleaseWaitService pleaseWaitService,
            IMessageService messageService)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => pleaseWaitService);
            Argument.IsNotNull(() => messageService);

            _projectManager = projectManager;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;
        }
        #endregion

        #region Methods
        public Task<bool> EnsureChangesSavedAsync(EditorProject project, SaveChangesReason reason)
        {
            Argument.IsNotNull(() => project);

            var message = GetPromptText(project, reason);

            return EnsureChangesSavedAsync(project, message);
        }

        protected virtual string GetPromptText(EditorProject project, SaveChangesReason reason)
        {
            Argument.IsNotNull(() => project);

            var location = project.Location;

            string message;
            switch (reason)
            {
                case SaveChangesReason.Closing:
                    message = $"The file '{location}' has to be closed, but is was changed\n\nDo you want to save changes?";
                    break;

                case SaveChangesReason.Refreshing:
                    message = $"The file '{location}' has to be refreshed, but is was changed\n\nDo you want to save changes?";
                    break;

                default:
                    message = $"The file '{location}' has been changed\n\nDo you want to save changes?";
                    break;
            }

            return message;
        }

        private async Task<bool> EnsureChangesSavedAsync(EditorProject project, string message)
        {
            Argument.IsNotNull(() => project);
            Argument.IsNotNullOrEmpty(() => message);

            if (project == null || !project.IsDirty)
                return true;

            var caption = AssemblyHelper.GetEntryAssembly().Title();

            MessageResult messageBoxResult;

            using (_pleaseWaitService.HideTemporarily())
            {
                messageBoxResult = await _messageService.ShowAsync(message, caption, MessageButton.YesNoCancel).ConfigureAwait(false);
            }

            switch (messageBoxResult)
            {
                case MessageResult.Cancel:
                    return false;

                case MessageResult.No:
                    return true;

                case MessageResult.Yes:
                    return await _projectManager.SaveAsync(project.Location).ConfigureAwait(false);
            }

            return false;
        }
        #endregion
    }
}