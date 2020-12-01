using System;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using Catel.Threading;
using Orc.ProjectManagement;
using Orc.FileSystem;
using WolvenKit.App.Model;

namespace WolvenKit.App.Model.ProjectManagement
{
    public class ProjectWriter : ProjectWriterBase<Project>
    {
        #region Fields
        private readonly IFileService _fileService;
        #endregion

        #region Constructors
        public ProjectWriter(IFileService fileService)
        {
            Argument.IsNotNull(() => fileService);

            _fileService = fileService;
        }
        #endregion

        #region Methods
        protected override Task<bool> WriteToLocationAsync(Project project, string location)
        {

            throw new NotImplementedException();
            // deserialization is done inside the project
            //_fileService.WriteAllText(location, project.ToString());

            return TaskHelper<bool>.FromResult(true);
        }
        #endregion
    }
}