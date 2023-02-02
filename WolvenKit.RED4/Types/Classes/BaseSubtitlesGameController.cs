using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseSubtitlesGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("lineMap")] 
		public CArray<subtitleLineMapEntry> LineMap
		{
			get => GetPropertyValue<CArray<subtitleLineMapEntry>>();
			set => SetPropertyValue<CArray<subtitleLineMapEntry>>(value);
		}

		[Ordinal(10)] 
		[RED("pendingShowLines")] 
		public CArray<CRUID> PendingShowLines
		{
			get => GetPropertyValue<CArray<CRUID>>();
			set => SetPropertyValue<CArray<CRUID>>(value);
		}

		[Ordinal(11)] 
		[RED("pendingHideLines")] 
		public CArray<CRUID> PendingHideLines
		{
			get => GetPropertyValue<CArray<CRUID>>();
			set => SetPropertyValue<CArray<CRUID>>(value);
		}

		[Ordinal(12)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(13)] 
		[RED("settingsListener")] 
		public CHandle<SubtitlesSettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<SubtitlesSettingsListener>>();
			set => SetPropertyValue<CHandle<SubtitlesSettingsListener>>(value);
		}

		[Ordinal(14)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(16)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(17)] 
		[RED("bbCbShowDialogLine")] 
		public CHandle<redCallbackObject> BbCbShowDialogLine
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("bbCbHideDialogLine")] 
		public CHandle<redCallbackObject> BbCbHideDialogLine
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("bbCbHideDialogLineByData")] 
		public CHandle<redCallbackObject> BbCbHideDialogLineByData
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("bbCbShowBackground")] 
		public CHandle<redCallbackObject> BbCbShowBackground
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("showBackgroud")] 
		public CBool ShowBackgroud
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isCreoleUnlocked")] 
		public CBool IsCreoleUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isPlayerJohnny")] 
		public CBool IsPlayerJohnny
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("disabledBySettings")] 
		public CBool DisabledBySettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("forceForeignLines")] 
		public CBool ForceForeignLines
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isRadioSubtitleEnabled")] 
		public CBool IsRadioSubtitleEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("backgroundOpacity")] 
		public CFloat BackgroundOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("fontSize")] 
		public CInt32 FontSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("factlistenerId")] 
		public CUInt32 FactlistenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public BaseSubtitlesGameController()
		{
			LineMap = new();
			PendingShowLines = new();
			PendingHideLines = new();
			GroupPath = "/audio/subtitles";
			GameInstance = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
