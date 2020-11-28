using System.ComponentModel;
using System.Threading.Tasks;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels
{
    using System;
    using System.Windows.Media.Imaging;
    using System.Windows.Media;
    using System.Windows.Input;
    using WolvenKit.App.Commands;
    using Catel.IoC;
    using MLib.Interfaces;
    using WolvenKit.App.Services;
    using Catel;
    using Catel.Data;


    /// <summary>
    /// Implements the viewmodel that drives the log view.
    /// </summary>
    public class LogViewModel : ToolViewModel
    {
        
        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "Log_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Log";


        #region constructors
        public LogViewModel(): base(ToolTitle)
        {

        }
        #endregion constructors

        #region properties

        /// <summary>
        /// The application log.
        /// Bound to the logview, implements OnPropertyRaised through Fody
        /// </summary>
        public string Log { get; set; }


        #endregion

        #region init
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