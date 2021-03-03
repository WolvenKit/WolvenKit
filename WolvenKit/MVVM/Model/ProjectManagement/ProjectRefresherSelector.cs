using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Catel;
using Orc.ProjectManagement;

namespace WolvenKit.MVVM.Model.ProjectManagement
{
    public class MyProjectRefresherSelector : IProjectRefresherSelector
    {
        #region Fields

        private readonly IDictionary<string, IProjectRefresher> _projectRefreshers;

        #endregion Fields

        #region Constructors

        public MyProjectRefresherSelector()
        {
            _projectRefreshers = new ConcurrentDictionary<string, IProjectRefresher>(StringComparer.OrdinalIgnoreCase);
        }

        #endregion Constructors



        #region Events

        public event AsyncEventHandler<ProjectEventArgs> ProjectRefresherUpdatedAsync;

        #endregion Events



        #region Methods

        public IProjectRefresher GetProjectRefresher(string location)
        {
            if (!_projectRefreshers.TryGetValue(location, out var projectRefresher) || projectRefresher == null)
            {
                projectRefresher = new WolvenKitProjectRefresher(location);

                projectRefresher.Updated += ProjectRefresherOnUpdated;

                _projectRefreshers[location] = projectRefresher;
            }
            return _projectRefreshers[location];
        }

        private async void ProjectRefresherOnUpdated(object sender, ProjectEventArgs e) =>
            await ProjectRefresherUpdatedAsync
                .SafeInvokeAsync(this,
                    e)
                .ConfigureAwait(false);

        #endregion Methods
    }
}
