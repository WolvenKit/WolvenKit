using Catel.IoC;
using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.ViewModels.Wizards.WizardPages.ProjectWizard
{
    /// <summary>
    /// The FinalizeSetupViewModel implements the project's finalize setup wizard's window viewmodel.
    /// </summary>
    class FinalizeSetupViewModel : ViewModelBase
    {
        #region fields
        private SelectProjectTypeViewModel _sptvm;
        private ProjectConfigurationViewModel _pcvm;
        #endregion fields

        #region constructors
        public FinalizeSetupViewModel()
        {
            _sptvm = ServiceLocator.Default.ResolveType<SelectProjectTypeViewModel>();
            _pcvm = ServiceLocator.Default.ResolveType<ProjectConfigurationViewModel>();
        }
        #endregion constructors

        #region properties
        /// <summary>
        /// Gets/Sets the project's type.
        /// </summary>
        public string ProjectType
        {
            get => _sptvm.CyberpunkChecked ? _sptvm.CyberpunkGameName : (_sptvm.WitcherChecked ? _sptvm.WitcherGameName : "");
        }

        /// <summary>
        /// Gets/Sets the project's name.
        /// </summary>
        public string ProjectName
        {
            get => _pcvm.ProjectName;
        }

        /// <summary>
        /// Gets/Sets the project's path.
        /// </summary>
        public string ProjectPath
        {
            get => _pcvm.ProjectPath;
        }
        #endregion properties
    }
}
