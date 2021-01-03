using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orc.ProjectManagement;

namespace WolvenKit.Model.ProjectManagement
{
	public class MyProjectRefresherSelector : Orc.ProjectManagement.IProjectRefresherSelector
    {
        public IProjectRefresher GetProjectRefresher(string location)
        {
            // TODO: Determine what refresher to use, in this case a file refresher
            // all wkit projects have a folder with the same name 
            var projectInfo = new FileInfo(location);
            var projectName = Path.GetFileNameWithoutExtension(location);
            var projectDirInfo = Path.Combine(projectInfo.Directory.FullName, projectName);
            return new DirectoryProjectRefresher(location, projectDirInfo);
        }
    }
}
