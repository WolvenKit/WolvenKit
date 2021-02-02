using Catel.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Model.Wizards
{
    public class ProjectWizardModel : ModelBase
    {
        #region fields
        private bool _witcherGameChecked = false;
        private bool _cyberpunkGameChecked = true;
        private string _projectName = "";
        private string _projectPath = "";
        #endregion fields

        #region properties
        public string WitcherGameName { get; } = "The Witcher 3";
        public string CyberpunkGameName { get; } = "Cyberpunk 2077";

        /// <summary>
        /// Gets/Sets the project's name.
        /// </summary>
        public bool WitcherChecked
        {
            get => _witcherGameChecked;
            set
            {
                _witcherGameChecked = value;
                RaisePropertyChanged(nameof(WitcherChecked));
            }
        }

        /// <summary>
        /// Gets/Sets the project's path.
        /// </summary>
        public bool CyberpunkChecked
        {
            get => _cyberpunkGameChecked;
            set
            {
                _cyberpunkGameChecked = value;
                RaisePropertyChanged(nameof(CyberpunkChecked));
            }
        }

        /// <summary>
		/// Gets/Sets the project name.
		/// </summary>
		public string ProjectName
        {
            get => _projectName;
            set             // This can also be set by the user via the view
            {
                _projectName = value;
                RaisePropertyChanged(nameof(ProjectName));
            }
        }

        /// <summary>
        /// Gets/Sets the project path.
        /// </summary>
        public string ProjectPath
        {
            get => _projectPath;
            set             // This can also be set by the user via the view
            {
                _projectPath = value;
                RaisePropertyChanged(nameof(ProjectPath));
            }
        }

        /// <summary>
        /// Gets/Sets the project's type.
        /// </summary>
        public string ProjectType
        {
            get => CyberpunkChecked ? CyberpunkGameName : (WitcherChecked ? WitcherGameName : "");
        }
        #endregion properties
    }
}
