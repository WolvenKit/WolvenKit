using System;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Input;
using WolvenKit.Commands;
using Catel.IoC;
using MLib.Interfaces;
using WolvenKit.Functionality.Services;
using Catel;
using Catel.Data;
using System.ComponentModel;
using System.Threading.Tasks;
using WolvenKit.Common.Services;
using Catel.MVVM;

namespace WolvenKit.ViewModels.Dialogs
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


        #endregion

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

        #endregion
    }
}