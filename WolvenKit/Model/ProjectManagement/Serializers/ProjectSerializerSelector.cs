using System;
using Catel;
using Catel.IoC;
using Orc.ProjectManagement;

namespace WolvenKit.Model.ProjectManagement
{
    public class ProjectSerializerSelector : IProjectSerializerSelector
    {
        #region Fields
        private readonly ITypeFactory _typeFactory;
        #endregion

        #region Constructors
        public ProjectSerializerSelector(ITypeFactory typeFactory)
        {
            Argument.IsNotNull(() => typeFactory);

            _typeFactory = typeFactory;
        }
        #endregion

        #region Methods
        public IProjectReader GetReader(string location) => _typeFactory.CreateInstance<ProjectReader>();

        public IProjectWriter GetWriter(string location) => _typeFactory.CreateInstance<ProjectWriter>();

        #endregion
    }
}
