using Catel;
using Catel.IoC;
using Orc.ProjectManagement;

namespace WolvenKit.MVVM.Model.ProjectManagement.Serializers
{
    public class ProjectSerializerSelector : IProjectSerializerSelector
    {
        #region Fields

        private readonly ITypeFactory _typeFactory;

        #endregion Fields

        #region Constructors

        public ProjectSerializerSelector(ITypeFactory typeFactory)
        {
            Argument.IsNotNull(() => typeFactory);

            _typeFactory = typeFactory;
        }

        #endregion Constructors

        #region Methods

        public IProjectReader GetReader(string location) => _typeFactory.CreateInstance<ProjectReader>();

        public IProjectWriter GetWriter(string location) => _typeFactory.CreateInstance<ProjectWriter>();

        #endregion Methods
    }
}
