using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HudPhoneAvatarController : HUDPhoneElement
	{
		[Ordinal(2)] 
		[RED("ContactAvatar")] 
		public inkImageWidgetReference ContactAvatar
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("HolocallRenderTexture")] 
		public inkImageWidgetReference HolocallRenderTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("SignalRangeIcon")] 
		public inkImageWidgetReference SignalRangeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("ContactName")] 
		public inkTextWidgetReference ContactName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("StatusText")] 
		public inkTextWidgetReference StatusText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("WaveformPlaceholder")] 
		public inkCanvasWidgetReference WaveformPlaceholder
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("HolocallHolder")] 
		public inkFlexWidgetReference HolocallHolder
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("UnknownAvatarName")] 
		public CName UnknownAvatarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("DefaultPortraitColor")] 
		public CColor DefaultPortraitColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(11)] 
		[RED("DefaultImageSize")] 
		public Vector2 DefaultImageSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(12)] 
		[RED("LoopAnimationName")] 
		public CName LoopAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("ShowingAnimationName")] 
		public CName ShowingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("HidingAnimationName")] 
		public CName HidingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("AudiocallShowingAnimationName")] 
		public CName AudiocallShowingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("AudiocallHidingAnimationName")] 
		public CName AudiocallHidingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("HolocallShowingAnimationName")] 
		public CName HolocallShowingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("HolocallHidingAnimationName")] 
		public CName HolocallHidingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("options")] 
		public inkanimPlaybackOptions Options
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(21)] 
		[RED("JournalManager")] 
		public CHandle<gameIJournalManager> JournalManager
		{
			get => GetPropertyValue<CHandle<gameIJournalManager>>();
			set => SetPropertyValue<CHandle<gameIJournalManager>>(value);
		}

		[Ordinal(22)] 
		[RED("RootAnimation")] 
		public CHandle<inkanimProxy> RootAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("AudiocallAnimation")] 
		public CHandle<inkanimProxy> AudiocallAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(24)] 
		[RED("HolocallAnimation")] 
		public CHandle<inkanimProxy> HolocallAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(25)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(27)] 
		[RED("CurrentMode")] 
		public CEnum<EHudAvatarMode> CurrentMode
		{
			get => GetPropertyValue<CEnum<EHudAvatarMode>>();
			set => SetPropertyValue<CEnum<EHudAvatarMode>>(value);
		}

		[Ordinal(28)] 
		[RED("Minimized")] 
		public CBool Minimized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HudPhoneAvatarController()
		{
			ContactAvatar = new inkImageWidgetReference();
			HolocallRenderTexture = new inkImageWidgetReference();
			SignalRangeIcon = new inkImageWidgetReference();
			ContactName = new inkTextWidgetReference();
			StatusText = new inkTextWidgetReference();
			WaveformPlaceholder = new inkCanvasWidgetReference();
			HolocallHolder = new inkFlexWidgetReference();
			UnknownAvatarName = "Unknown";
			DefaultPortraitColor = new CColor();
			DefaultImageSize = new Vector2();
			LoopAnimationName = "avatarHoloCallLoopAnimation";
			ShowingAnimationName = "portraitIntro";
			HidingAnimationName = "portraitOutro";
			AudiocallShowingAnimationName = "avatarAudiocallShowingAnimation";
			AudiocallHidingAnimationName = "avatarAudiocallHidingAnimation";
			HolocallShowingAnimationName = "avatarHolocallShowingAnimation";
			HolocallHidingAnimationName = "avatarHolocallHidingAnimation";
			Options = new inkanimPlaybackOptions();
			Holder = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
