using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orc.ProjectManagement;

namespace WolvenKit.Model.ProjectManagement
{
	public class MyProjectRefresherSelector : IProjectRefresherSelector
    {
        public IProjectRefresher GetProjectRefresher(string location) => new WolvenKitProjectRefresher(location);
    }
}
