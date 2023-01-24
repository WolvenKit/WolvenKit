using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs
{
    /// <summary>
    /// Implements the viewmodel that drives the log view.
    /// </summary>
    public partial class InputDialogViewModel : ObservableObject
    {
        public InputDialogViewModel()
        {
        }

        /// <summary>
        /// The application log.
        /// Bound to the logview, implements OnPropertyRaised through Fody
        /// </summary>
        [ObservableProperty] private string? _text;
    }
}
