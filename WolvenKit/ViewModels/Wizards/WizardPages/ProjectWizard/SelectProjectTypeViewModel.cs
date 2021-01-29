using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.ViewModels.Wizards.WizardPages.ProjectWizard
{
    /// <summary>
    /// The SelectProjectTypeViewModel implements project selection wizard's window viewmodel.
    /// </summary>
    class SelectProjectTypeViewModel : ViewModelBase
    {
        #region fields
        private bool _witcherGameChecked = false;
        private bool _cyberpunkGameChecked = true;
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
        #endregion properties
    }
}
