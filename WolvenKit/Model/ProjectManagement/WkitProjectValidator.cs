using System.IO;
using System.Threading.Tasks;
using Orc.ProjectManagement;

namespace WolvenKit.Model.ProjectManagement
{
    public class WkitProjectValidator : ProjectValidatorBase
    {
        #region IProjectValidator 
        public override Task<bool> CanStartLoadingProjectAsync(string location)
        {
            // first check if w3modproj or cpmodproj exist
            if (!File.Exists(location))
                return Task.FromResult(false);

            // redundant check
            var projectInfo = new FileInfo(location);
            if (projectInfo.Directory == null)
                return Task.FromResult(false);

            // all wkit projects have a folder with the same name 
            var projectName = Path.GetFileNameWithoutExtension(location);
            var projectDirInfo = Path.Combine(projectInfo.Directory.FullName, projectName);
            return Task.FromResult(Directory.Exists(projectDirInfo));
        }
        #endregion
    }
}