using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseSubtitlesGameController : gameuiProjectedHUDGameController
	{
		private CArray<subtitleLineMapEntry> _lineMap;
		private CArray<CRUID> _pendingShowLines;
		private CArray<CRUID> _pendingHideLines;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<SubtitlesSettingsListener> _settingsListener;
		private CName _groupPath;
		private ScriptGameInstance _gameInstance;
		private CWeakHandle<gameIBlackboard> _uiBlackboard;
		private CHandle<redCallbackObject> _bbCbShowDialogLine;
		private CHandle<redCallbackObject> _bbCbHideDialogLine;
		private CHandle<redCallbackObject> _bbCbHideDialogLineByData;
		private CHandle<redCallbackObject> _bbCbShowBackground;
		private CBool _showBackgroud;
		private CBool _isCreoleUnlocked;
		private CBool _isPlayerJohnny;
		private CBool _disabledBySettings;
		private CBool _forceForeignLines;
		private CFloat _backgroundOpacity;
		private CInt32 _fontSize;
		private CUInt32 _factlistenerId;

		[Ordinal(9)] 
		[RED("lineMap")] 
		public CArray<subtitleLineMapEntry> LineMap
		{
			get => GetProperty(ref _lineMap);
			set => SetProperty(ref _lineMap, value);
		}

		[Ordinal(10)] 
		[RED("pendingShowLines")] 
		public CArray<CRUID> PendingShowLines
		{
			get => GetProperty(ref _pendingShowLines);
			set => SetProperty(ref _pendingShowLines, value);
		}

		[Ordinal(11)] 
		[RED("pendingHideLines")] 
		public CArray<CRUID> PendingHideLines
		{
			get => GetProperty(ref _pendingHideLines);
			set => SetProperty(ref _pendingHideLines, value);
		}

		[Ordinal(12)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(13)] 
		[RED("settingsListener")] 
		public CHandle<SubtitlesSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(14)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(15)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(16)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(17)] 
		[RED("bbCbShowDialogLine")] 
		public CHandle<redCallbackObject> BbCbShowDialogLine
		{
			get => GetProperty(ref _bbCbShowDialogLine);
			set => SetProperty(ref _bbCbShowDialogLine, value);
		}

		[Ordinal(18)] 
		[RED("bbCbHideDialogLine")] 
		public CHandle<redCallbackObject> BbCbHideDialogLine
		{
			get => GetProperty(ref _bbCbHideDialogLine);
			set => SetProperty(ref _bbCbHideDialogLine, value);
		}

		[Ordinal(19)] 
		[RED("bbCbHideDialogLineByData")] 
		public CHandle<redCallbackObject> BbCbHideDialogLineByData
		{
			get => GetProperty(ref _bbCbHideDialogLineByData);
			set => SetProperty(ref _bbCbHideDialogLineByData, value);
		}

		[Ordinal(20)] 
		[RED("bbCbShowBackground")] 
		public CHandle<redCallbackObject> BbCbShowBackground
		{
			get => GetProperty(ref _bbCbShowBackground);
			set => SetProperty(ref _bbCbShowBackground, value);
		}

		[Ordinal(21)] 
		[RED("showBackgroud")] 
		public CBool ShowBackgroud
		{
			get => GetProperty(ref _showBackgroud);
			set => SetProperty(ref _showBackgroud, value);
		}

		[Ordinal(22)] 
		[RED("isCreoleUnlocked")] 
		public CBool IsCreoleUnlocked
		{
			get => GetProperty(ref _isCreoleUnlocked);
			set => SetProperty(ref _isCreoleUnlocked, value);
		}

		[Ordinal(23)] 
		[RED("isPlayerJohnny")] 
		public CBool IsPlayerJohnny
		{
			get => GetProperty(ref _isPlayerJohnny);
			set => SetProperty(ref _isPlayerJohnny, value);
		}

		[Ordinal(24)] 
		[RED("disabledBySettings")] 
		public CBool DisabledBySettings
		{
			get => GetProperty(ref _disabledBySettings);
			set => SetProperty(ref _disabledBySettings, value);
		}

		[Ordinal(25)] 
		[RED("forceForeignLines")] 
		public CBool ForceForeignLines
		{
			get => GetProperty(ref _forceForeignLines);
			set => SetProperty(ref _forceForeignLines, value);
		}

		[Ordinal(26)] 
		[RED("backgroundOpacity")] 
		public CFloat BackgroundOpacity
		{
			get => GetProperty(ref _backgroundOpacity);
			set => SetProperty(ref _backgroundOpacity, value);
		}

		[Ordinal(27)] 
		[RED("fontSize")] 
		public CInt32 FontSize
		{
			get => GetProperty(ref _fontSize);
			set => SetProperty(ref _fontSize, value);
		}

		[Ordinal(28)] 
		[RED("factlistenerId")] 
		public CUInt32 FactlistenerId
		{
			get => GetProperty(ref _factlistenerId);
			set => SetProperty(ref _factlistenerId, value);
		}

		public BaseSubtitlesGameController()
		{
			_groupPath = "/audio/subtitles";
		}
	}
}
