using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace WolvenKit.App.Models.Wizards
{
    /// <summary>
    /// Keeps track of which game was selected by the user during setting up a project.
    /// </summary>
    public class PublishWizardModel : ReactiveObject
    {


        #region properties

        /// <summary>
        /// Gets/Sets the youtube link.
        /// </summary>
        [Reactive] public string YoutubeLink { get; set; }

        /// <summary>
        /// Gets/Sets the twitch link.
        /// </summary>
        [Reactive] public string TwitchLink { get; set; }

        /// <summary>
        /// Gets/Sets the twitter link.
        /// </summary>
        [Reactive] public string TwitterLink { get; set; }

        /// <summary>
        /// Gets/Sets the facebook link.
        /// </summary>
        [Reactive] public string FacebookLink { get; set; }

        /// <summary>
        /// Gets/Sets the discord link.
        /// </summary>
        [Reactive] public string DiscordLink { get; set; }

        /// <summary>
        /// Gets/Sets the website link.
        /// </summary>
        [Reactive] public string WebsiteLink { get; set; }

        /// <summary>
        /// Gets/Sets the donate link.
        /// </summary>
        [Reactive] public string DonateLink { get; set; }

        /// <summary>
        /// Gets/Sets the license.
        /// </summary>
        [Reactive] public string License { get; set; }

        /// <summary>
        /// Gets/Sets the description.
        /// </summary>
        [Reactive] public string Description { get; set; }

        /// <summary>
        /// Gets/Sets the large description.
        /// </summary>
        [Reactive] public string LargeDescription { get; set; }

        /// <summary>
        /// Gets/Sets the author's profile image brush.
        /// </summary>
        [Reactive] public ImageBrush ProfileImageBrush { get; set; } = default;

        /// <summary>
        /// Gets/Sets the author's profile image path.
        /// </summary>
        [Reactive] public string ProfileImageBrushPath { get; set; }

        /// <summary>
        /// Gets/Sets the header background color.
        /// </summary>
        [Reactive] public Color HeaderBackground { get; set; }

        /// <summary>
        /// Gets/Sets the icon background color.
        /// </summary>
        [Reactive] public Color IconBackground { get; set; }

        /// <summary>
        /// Gets/Sets the use black text property.
        /// </summary>
        [Reactive] public bool UseBlackText { get; set; }

        #endregion properties
    }
}
