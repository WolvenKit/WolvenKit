using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel;
using Orc.ProjectManagement;

namespace WolvenKit.MVVM.Model.ProjectManagement
{
	public class MyProjectRefresherSelector : IProjectRefresherSelector
    {
        private readonly IDictionary<string, IProjectRefresher> _projectRefreshers;

        public event AsyncEventHandler<ProjectEventArgs> ProjectRefresherUpdatedAsync;

        public MyProjectRefresherSelector()
        {
            _projectRefreshers = new ConcurrentDictionary<string, IProjectRefresher>(StringComparer.OrdinalIgnoreCase);
        }

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
    }
}
