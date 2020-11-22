using Catel.MVVM;

namespace WolvenKitUI.ViewModels
{
    public class StatusBarViewModel : ViewModelBase
    {
        #region Properties
        public override string Title
        {
            get { return "Status bar title binding"; }
        }
        #endregion

        public bool EnableAutomaticUpdates { get; set; }
    }
}