using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseSubtitlesGameController : gameuiProjectedHUDGameController
	{
		private CArray<subtitleLineMapEntry> _lineMap;
		private CArray<CRUID> _pendingShowLines;
		private CArray<CRUID> _pendingHideLines;
		private ScriptGameInstance _gameInstance;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private CUInt32 _bbCbShowDialogLine;
		private CUInt32 _bbCbHideDialogLine;
		private CUInt32 _bbCbHideDialogLineByData;
		private CUInt32 _bbCbShowBackground;
		private CBool _showBackgroud;
		private CBool _isCreoleUnlocked;
		private CBool _isPlayerJohnny;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<SubtitlesSettingsListener> _settingsListener;
		private CName _groupPath;
		private CBool _disabledBySettings;
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
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(13)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(14)] 
		[RED("bbCbShowDialogLine")] 
		public CUInt32 BbCbShowDialogLine
		{
			get => GetProperty(ref _bbCbShowDialogLine);
			set => SetProperty(ref _bbCbShowDialogLine, value);
		}

		[Ordinal(15)] 
		[RED("bbCbHideDialogLine")] 
		public CUInt32 BbCbHideDialogLine
		{
			get => GetProperty(ref _bbCbHideDialogLine);
			set => SetProperty(ref _bbCbHideDialogLine, value);
		}

		[Ordinal(16)] 
		[RED("bbCbHideDialogLineByData")] 
		public CUInt32 BbCbHideDialogLineByData
		{
			get => GetProperty(ref _bbCbHideDialogLineByData);
			set => SetProperty(ref _bbCbHideDialogLineByData, value);
		}

		[Ordinal(17)] 
		[RED("bbCbShowBackground")] 
		public CUInt32 BbCbShowBackground
		{
			get => GetProperty(ref _bbCbShowBackground);
			set => SetProperty(ref _bbCbShowBackground, value);
		}

		[Ordinal(18)] 
		[RED("showBackgroud")] 
		public CBool ShowBackgroud
		{
			get => GetProperty(ref _showBackgroud);
			set => SetProperty(ref _showBackgroud, value);
		}

		[Ordinal(19)] 
		[RED("isCreoleUnlocked")] 
		public CBool IsCreoleUnlocked
		{
			get => GetProperty(ref _isCreoleUnlocked);
			set => SetProperty(ref _isCreoleUnlocked, value);
		}

		[Ordinal(20)] 
		[RED("isPlayerJohnny")] 
		public CBool IsPlayerJohnny
		{
			get => GetProperty(ref _isPlayerJohnny);
			set => SetProperty(ref _isPlayerJohnny, value);
		}

		[Ordinal(21)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(22)] 
		[RED("settingsListener")] 
		public CHandle<SubtitlesSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(23)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(24)] 
		[RED("disabledBySettings")] 
		public CBool DisabledBySettings
		{
			get => GetProperty(ref _disabledBySettings);
			set => SetProperty(ref _disabledBySettings, value);
		}

		[Ordinal(25)] 
		[RED("backgroundOpacity")] 
		public CFloat BackgroundOpacity
		{
			get => GetProperty(ref _backgroundOpacity);
			set => SetProperty(ref _backgroundOpacity, value);
		}

		[Ordinal(26)] 
		[RED("fontSize")] 
		public CInt32 FontSize
		{
			get => GetProperty(ref _fontSize);
			set => SetProperty(ref _fontSize, value);
		}

		[Ordinal(27)] 
		[RED("factlistenerId")] 
		public CUInt32 FactlistenerId
		{
			get => GetProperty(ref _factlistenerId);
			set => SetProperty(ref _factlistenerId, value);
		}

		public BaseSubtitlesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
