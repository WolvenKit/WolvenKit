using System.Windows.Media;
using Catel.Data;

namespace WolvenKit.Models.Wizards
{
    /// <summary>
    /// Keeps track of which game was selected by the user during setting up a project.
    /// </summary>
    public class PublishWizardModel : ModelBase
    {
        #region fields

        private string _youtubeLink = "";
        private string _twitchLink = "";
        private string _twitterLink = "";
        private string _facebookLink = "";
        private string _discordLink = "";
        private string _websiteLink = "";
        private string _donateLink = "";
        private string _license = "";
        private string _description = "";
        private string _largeDescription = "";
        private ImageBrush _profileImageBrush = default(ImageBrush);
        private string _profileImagePath = "";
        private Color _headerBackground;
        private Color _iconBackground;
        private bool _useBlackText = false;

        #endregion fields

        #region properties

        /// <summary>
        /// Gets/Sets the youtube link.
        /// </summary>
        public string YoutubeLink
        {
            get => _youtubeLink;
            set
            {
                _youtubeLink = value;
                RaisePropertyChanged(nameof(YoutubeLink));
            }
        }

        /// <summary>
        /// Gets/Sets the twitch link.
        /// </summary>
        public string TwitchLink
        {
            get => _twitchLink;
            set
            {
                _twitchLink = value;
                RaisePropertyChanged(nameof(TwitchLink));
            }
        }

        /// <summary>
        /// Gets/Sets the twitter link.
        /// </summary>
        public string TwitterLink
        {
            get => _twitterLink;
            set
            {
                _twitterLink = value;
                RaisePropertyChanged(nameof(TwitterLink));
            }
        }

        /// <summary>
        /// Gets/Sets the facebook link.
        /// </summary>
        public string FacebookLink
        {
            get => _facebookLink;
            set
            {
                _facebookLink = value;
                RaisePropertyChanged(nameof(FacebookLink));
            }
        }

        /// <summary>
        /// Gets/Sets the discord link.
        /// </summary>
        public string DiscordLink
        {
            get => _discordLink;
            set
            {
                _discordLink = value;
                RaisePropertyChanged(nameof(DiscordLink));
            }
        }

        /// <summary>
        /// Gets/Sets the website link.
        /// </summary>
        public string WebsiteLink
        {
            get => _websiteLink;
            set
            {
                _websiteLink = value;
                RaisePropertyChanged(nameof(WebsiteLink));
            }
        }

        /// <summary>
        /// Gets/Sets the donate link.
        /// </summary>
        public string DonateLink
        {
            get => _donateLink;
            set
            {
                _donateLink = value;
                RaisePropertyChanged(nameof(DonateLink));
            }
        }

        /// <summary>
        /// Gets/Sets the license.
        /// </summary>
        public string License
        {
            get => _license;
            set
            {
                _license = value;
                RaisePropertyChanged(nameof(License));
            }
        }

        /// <summary>
        /// Gets/Sets the description.
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        /// <summary>
        /// Gets/Sets the large description.
        /// </summary>
        public string LargeDescription
        {
            get => _largeDescription;
            set
            {
                _largeDescription = value;
                RaisePropertyChanged(nameof(LargeDescription));
            }
        }

        /// <summary>
        /// Gets/Sets the author's profile image brush.
        /// </summary>
        public ImageBrush ProfileImageBrush
        {
            get => _profileImageBrush;
            set
            {
                _profileImageBrush = value;
                RaisePropertyChanged(nameof(ProfileImageBrush));
            }
        }

        /// <summary>
        /// Gets/Sets the author's profile image path.
        /// </summary>
        public string ProfileImageBrushPath
        {
            get => _profileImagePath;
            set
            {
                _profileImagePath = value;
                RaisePropertyChanged(nameof(ProfileImageBrushPath));
            }
        }

        /// <summary>
        /// Gets/Sets the header background color.
        /// </summary>
        public Color HeaderBackground
        {
            get => _headerBackground;
            set
            {
                _headerBackground = value;
                RaisePropertyChanged(nameof(HeaderBackground));
            }
        }

        /// <summary>
        /// Gets/Sets the icon background color.
        /// </summary>
        public Color IconBackground
        {
            get => _iconBackground;
            set
            {
                _iconBackground = value;
                RaisePropertyChanged(nameof(IconBackground));
            }
        }

        /// <summary>
        /// Gets/Sets the use black text property.
        /// </summary>
        public bool UseBlackText
        {
            get => _useBlackText;
            set
            {
                _useBlackText = value;
                RaisePropertyChanged(nameof(UseBlackText));
            }
        }

        #endregion properties
    }
}
