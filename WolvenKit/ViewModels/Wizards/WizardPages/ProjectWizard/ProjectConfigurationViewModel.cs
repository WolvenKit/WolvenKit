using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.ViewModels.Wizards.WizardPages.ProjectWizard
{
    /// <summary>
	/// The ProjectConfigurationViewModel implements project wizard configuration window's viewmodel.
	/// </summary>
    class ProjectConfigurationViewModel : ViewModelBase
    {
        #region fields
        private string _projectName = "";
        private string _projectPath = "";
        #endregion fields

        #region properties
        /// <summary>
        /// Gets/Sets the project's name.
        /// </summary>
        public string ProjectName
        {
            get => _projectName;
            set
            {
                _projectName = value;
                RaisePropertyChanged(nameof(ProjectName));
            }
        }

        /// <summary>
        /// Gets/Sets the project's path.
        /// </summary>
        public string ProjectPath
        {
            get => _projectPath;
            set
            {
                _projectPath = value;
                RaisePropertyChanged(nameof(ProjectPath));
            }
        }
        #endregion properties
    }
}
