using System.Threading.Tasks;
using Catel.MVVM;

namespace WolvenKit.MVVM.ViewModels.Components.Dialogs
{
    /// <summary>
    /// Implements the viewmodel that drives the log view.
    /// </summary>
    public class InputDialogViewModel : ViewModelBase
    {
        #region constructors

        public InputDialogViewModel()
        {
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// The application log.
        /// Bound to the logview, implements OnPropertyRaised through Fody
        /// </summary>
        public string Text { get; set; }

        #endregion properties

        #region methods

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: Write initialization code here and subscribe to events
        }

        protected override Task CloseAsync()
        {
            // TODO: Unsubscribe from events

            return base.CloseAsync();
        }

        #endregion methods
    }
}
