using ReactiveUI;
using WolvenKit.Models.Wizards;

namespace WolvenKit.ViewModels.Wizards.PublishWizard
{
    public class OptionalSettingsViewModel : ReactiveObject
    {
        #region constructors

        public OptionalSettingsViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            PublishWizardModel = serviceLocator.ResolveType<PublishWizardModel>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Gets or sets the PublishWizardModel.
        /// </summary>
        [Model]
        [Expose("YoutubeLink")]
        [Expose("TwitchLink")]
        [Expose("TwitterLink")]
        [Expose("FacebookLink")]
        [Expose("DiscordLink")]
        [Expose("WebsiteLink")]
        [Expose("DonateLink")]
        [Expose("License")]
        [Expose("LargeDescription")]
        [Expose("HeaderBackground")]
        [Expose("IconBackground")]
        [Expose("UseBlackText")]
        public PublishWizardModel PublishWizardModel { get; set; }

        #endregion properties
    }
}
