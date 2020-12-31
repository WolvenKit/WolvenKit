using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel;
using Catel.IoC;
using Catel.Threading;
using Orc.ProjectManagement;
using Orc.FileSystem;
using WolvenKit.App.Model;
using WolvenKit.Common;

namespace WolvenKit.App.Model.ProjectManagement
{
    public class ProjectWriter : ProjectWriterBase<EditorProject>
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
        protected override Task<bool> WriteToLocationAsync(EditorProject project, string location)
        {
            project.Save(location);
            return TaskHelper<bool>.FromResult(true);
        }
        #endregion
    }
}