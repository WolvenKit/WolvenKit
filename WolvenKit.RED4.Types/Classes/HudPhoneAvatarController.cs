using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HudPhoneAvatarController : HUDPhoneElement
	{
		private inkImageWidgetReference _contactAvatar;
		private inkImageWidgetReference _holocallRenderTexture;
		private inkImageWidgetReference _signalRangeIcon;
		private inkTextWidgetReference _contactName;
		private inkTextWidgetReference _statusText;
		private inkCanvasWidgetReference _waveformPlaceholder;
		private inkFlexWidgetReference _holocallHolder;
		private CName _unknownAvatarName;
		private CColor _defaultPortraitColor;
		private Vector2 _defaultImageSize;
		private CName _loopAnimationName;
		private CName _showingAnimationName;
		private CName _hidingAnimationName;
		private CName _audiocallShowingAnimationName;
		private CName _audiocallHidingAnimationName;
		private CName _holocallShowingAnimationName;
		private CName _holocallHidingAnimationName;
		private CHandle<inkanimProxy> _loopAnimation;
		private inkanimPlaybackOptions _options;
		private CHandle<gameIJournalManager> _journalManager;
		private CHandle<inkanimProxy> _rootAnimation;
		private CHandle<inkanimProxy> _audiocallAnimation;
		private CHandle<inkanimProxy> _holocallAnimation;
		private inkWidgetReference _holder;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CEnum<EHudAvatarMode> _currentMode;
		private CBool _minimized;

		[Ordinal(2)] 
		[RED("ContactAvatar")] 
		public inkImageWidgetReference ContactAvatar
		{
			get => GetProperty(ref _contactAvatar);
			set => SetProperty(ref _contactAvatar, value);
		}

		[Ordinal(3)] 
		[RED("HolocallRenderTexture")] 
		public inkImageWidgetReference HolocallRenderTexture
		{
			get => GetProperty(ref _holocallRenderTexture);
			set => SetProperty(ref _holocallRenderTexture, value);
		}

		[Ordinal(4)] 
		[RED("SignalRangeIcon")] 
		public inkImageWidgetReference SignalRangeIcon
		{
			get => GetProperty(ref _signalRangeIcon);
			set => SetProperty(ref _signalRangeIcon, value);
		}

		[Ordinal(5)] 
		[RED("ContactName")] 
		public inkTextWidgetReference ContactName
		{
			get => GetProperty(ref _contactName);
			set => SetProperty(ref _contactName, value);
		}

		[Ordinal(6)] 
		[RED("StatusText")] 
		public inkTextWidgetReference StatusText
		{
			get => GetProperty(ref _statusText);
			set => SetProperty(ref _statusText, value);
		}

		[Ordinal(7)] 
		[RED("WaveformPlaceholder")] 
		public inkCanvasWidgetReference WaveformPlaceholder
		{
			get => GetProperty(ref _waveformPlaceholder);
			set => SetProperty(ref _waveformPlaceholder, value);
		}

		[Ordinal(8)] 
		[RED("HolocallHolder")] 
		public inkFlexWidgetReference HolocallHolder
		{
			get => GetProperty(ref _holocallHolder);
			set => SetProperty(ref _holocallHolder, value);
		}

		[Ordinal(9)] 
		[RED("UnknownAvatarName")] 
		public CName UnknownAvatarName
		{
			get => GetProperty(ref _unknownAvatarName);
			set => SetProperty(ref _unknownAvatarName, value);
		}

		[Ordinal(10)] 
		[RED("DefaultPortraitColor")] 
		public CColor DefaultPortraitColor
		{
			get => GetProperty(ref _defaultPortraitColor);
			set => SetProperty(ref _defaultPortraitColor, value);
		}

		[Ordinal(11)] 
		[RED("DefaultImageSize")] 
		public Vector2 DefaultImageSize
		{
			get => GetProperty(ref _defaultImageSize);
			set => SetProperty(ref _defaultImageSize, value);
		}

		[Ordinal(12)] 
		[RED("LoopAnimationName")] 
		public CName LoopAnimationName
		{
			get => GetProperty(ref _loopAnimationName);
			set => SetProperty(ref _loopAnimationName, value);
		}

		[Ordinal(13)] 
		[RED("ShowingAnimationName")] 
		public CName ShowingAnimationName
		{
			get => GetProperty(ref _showingAnimationName);
			set => SetProperty(ref _showingAnimationName, value);
		}

		[Ordinal(14)] 
		[RED("HidingAnimationName")] 
		public CName HidingAnimationName
		{
			get => GetProperty(ref _hidingAnimationName);
			set => SetProperty(ref _hidingAnimationName, value);
		}

		[Ordinal(15)] 
		[RED("AudiocallShowingAnimationName")] 
		public CName AudiocallShowingAnimationName
		{
			get => GetProperty(ref _audiocallShowingAnimationName);
			set => SetProperty(ref _audiocallShowingAnimationName, value);
		}

		[Ordinal(16)] 
		[RED("AudiocallHidingAnimationName")] 
		public CName AudiocallHidingAnimationName
		{
			get => GetProperty(ref _audiocallHidingAnimationName);
			set => SetProperty(ref _audiocallHidingAnimationName, value);
		}

		[Ordinal(17)] 
		[RED("HolocallShowingAnimationName")] 
		public CName HolocallShowingAnimationName
		{
			get => GetProperty(ref _holocallShowingAnimationName);
			set => SetProperty(ref _holocallShowingAnimationName, value);
		}

		[Ordinal(18)] 
		[RED("HolocallHidingAnimationName")] 
		public CName HolocallHidingAnimationName
		{
			get => GetProperty(ref _holocallHidingAnimationName);
			set => SetProperty(ref _holocallHidingAnimationName, value);
		}

		[Ordinal(19)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get => GetProperty(ref _loopAnimation);
			set => SetProperty(ref _loopAnimation, value);
		}

		[Ordinal(20)] 
		[RED("options")] 
		public inkanimPlaybackOptions Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}

		[Ordinal(21)] 
		[RED("JournalManager")] 
		public CHandle<gameIJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(22)] 
		[RED("RootAnimation")] 
		public CHandle<inkanimProxy> RootAnimation
		{
			get => GetProperty(ref _rootAnimation);
			set => SetProperty(ref _rootAnimation, value);
		}

		[Ordinal(23)] 
		[RED("AudiocallAnimation")] 
		public CHandle<inkanimProxy> AudiocallAnimation
		{
			get => GetProperty(ref _audiocallAnimation);
			set => SetProperty(ref _audiocallAnimation, value);
		}

		[Ordinal(24)] 
		[RED("HolocallAnimation")] 
		public CHandle<inkanimProxy> HolocallAnimation
		{
			get => GetProperty(ref _holocallAnimation);
			set => SetProperty(ref _holocallAnimation, value);
		}

		[Ordinal(25)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetProperty(ref _holder);
			set => SetProperty(ref _holder, value);
		}

		[Ordinal(26)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(27)] 
		[RED("CurrentMode")] 
		public CEnum<EHudAvatarMode> CurrentMode
		{
			get => GetProperty(ref _currentMode);
			set => SetProperty(ref _currentMode, value);
		}

		[Ordinal(28)] 
		[RED("Minimized")] 
		public CBool Minimized
		{
			get => GetProperty(ref _minimized);
			set => SetProperty(ref _minimized, value);
		}

		public HudPhoneAvatarController()
		{
			_unknownAvatarName = "Unknown";
			_loopAnimationName = "avatarHoloCallLoopAnimation";
			_showingAnimationName = "portraitIntro";
			_hidingAnimationName = "portraitOutro";
			_audiocallShowingAnimationName = "avatarAudiocallShowingAnimation";
			_audiocallHidingAnimationName = "avatarAudiocallHidingAnimation";
			_holocallShowingAnimationName = "avatarHolocallShowingAnimation";
			_holocallHidingAnimationName = "avatarHolocallHidingAnimation";
		}
	}
}
