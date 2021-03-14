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
			get
			{
				if (_lineMap == null)
				{
					_lineMap = (CArray<subtitleLineMapEntry>) CR2WTypeManager.Create("array:subtitleLineMapEntry", "lineMap", cr2w, this);
				}
				return _lineMap;
			}
			set
			{
				if (_lineMap == value)
				{
					return;
				}
				_lineMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("pendingShowLines")] 
		public CArray<CRUID> PendingShowLines
		{
			get
			{
				if (_pendingShowLines == null)
				{
					_pendingShowLines = (CArray<CRUID>) CR2WTypeManager.Create("array:CRUID", "pendingShowLines", cr2w, this);
				}
				return _pendingShowLines;
			}
			set
			{
				if (_pendingShowLines == value)
				{
					return;
				}
				_pendingShowLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("pendingHideLines")] 
		public CArray<CRUID> PendingHideLines
		{
			get
			{
				if (_pendingHideLines == null)
				{
					_pendingHideLines = (CArray<CRUID>) CR2WTypeManager.Create("array:CRUID", "pendingHideLines", cr2w, this);
				}
				return _pendingHideLines;
			}
			set
			{
				if (_pendingHideLines == value)
				{
					return;
				}
				_pendingHideLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get
			{
				if (_uiBlackboard == null)
				{
					_uiBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboard", cr2w, this);
				}
				return _uiBlackboard;
			}
			set
			{
				if (_uiBlackboard == value)
				{
					return;
				}
				_uiBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bbCbShowDialogLine")] 
		public CUInt32 BbCbShowDialogLine
		{
			get
			{
				if (_bbCbShowDialogLine == null)
				{
					_bbCbShowDialogLine = (CUInt32) CR2WTypeManager.Create("Uint32", "bbCbShowDialogLine", cr2w, this);
				}
				return _bbCbShowDialogLine;
			}
			set
			{
				if (_bbCbShowDialogLine == value)
				{
					return;
				}
				_bbCbShowDialogLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bbCbHideDialogLine")] 
		public CUInt32 BbCbHideDialogLine
		{
			get
			{
				if (_bbCbHideDialogLine == null)
				{
					_bbCbHideDialogLine = (CUInt32) CR2WTypeManager.Create("Uint32", "bbCbHideDialogLine", cr2w, this);
				}
				return _bbCbHideDialogLine;
			}
			set
			{
				if (_bbCbHideDialogLine == value)
				{
					return;
				}
				_bbCbHideDialogLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bbCbHideDialogLineByData")] 
		public CUInt32 BbCbHideDialogLineByData
		{
			get
			{
				if (_bbCbHideDialogLineByData == null)
				{
					_bbCbHideDialogLineByData = (CUInt32) CR2WTypeManager.Create("Uint32", "bbCbHideDialogLineByData", cr2w, this);
				}
				return _bbCbHideDialogLineByData;
			}
			set
			{
				if (_bbCbHideDialogLineByData == value)
				{
					return;
				}
				_bbCbHideDialogLineByData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bbCbShowBackground")] 
		public CUInt32 BbCbShowBackground
		{
			get
			{
				if (_bbCbShowBackground == null)
				{
					_bbCbShowBackground = (CUInt32) CR2WTypeManager.Create("Uint32", "bbCbShowBackground", cr2w, this);
				}
				return _bbCbShowBackground;
			}
			set
			{
				if (_bbCbShowBackground == value)
				{
					return;
				}
				_bbCbShowBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("showBackgroud")] 
		public CBool ShowBackgroud
		{
			get
			{
				if (_showBackgroud == null)
				{
					_showBackgroud = (CBool) CR2WTypeManager.Create("Bool", "showBackgroud", cr2w, this);
				}
				return _showBackgroud;
			}
			set
			{
				if (_showBackgroud == value)
				{
					return;
				}
				_showBackgroud = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("isCreoleUnlocked")] 
		public CBool IsCreoleUnlocked
		{
			get
			{
				if (_isCreoleUnlocked == null)
				{
					_isCreoleUnlocked = (CBool) CR2WTypeManager.Create("Bool", "isCreoleUnlocked", cr2w, this);
				}
				return _isCreoleUnlocked;
			}
			set
			{
				if (_isCreoleUnlocked == value)
				{
					return;
				}
				_isCreoleUnlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("isPlayerJohnny")] 
		public CBool IsPlayerJohnny
		{
			get
			{
				if (_isPlayerJohnny == null)
				{
					_isPlayerJohnny = (CBool) CR2WTypeManager.Create("Bool", "isPlayerJohnny", cr2w, this);
				}
				return _isPlayerJohnny;
			}
			set
			{
				if (_isPlayerJohnny == value)
				{
					return;
				}
				_isPlayerJohnny = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (CHandle<userSettingsUserSettings>) CR2WTypeManager.Create("handle:userSettingsUserSettings", "settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("settingsListener")] 
		public CHandle<SubtitlesSettingsListener> SettingsListener
		{
			get
			{
				if (_settingsListener == null)
				{
					_settingsListener = (CHandle<SubtitlesSettingsListener>) CR2WTypeManager.Create("handle:SubtitlesSettingsListener", "settingsListener", cr2w, this);
				}
				return _settingsListener;
			}
			set
			{
				if (_settingsListener == value)
				{
					return;
				}
				_settingsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get
			{
				if (_groupPath == null)
				{
					_groupPath = (CName) CR2WTypeManager.Create("CName", "groupPath", cr2w, this);
				}
				return _groupPath;
			}
			set
			{
				if (_groupPath == value)
				{
					return;
				}
				_groupPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("disabledBySettings")] 
		public CBool DisabledBySettings
		{
			get
			{
				if (_disabledBySettings == null)
				{
					_disabledBySettings = (CBool) CR2WTypeManager.Create("Bool", "disabledBySettings", cr2w, this);
				}
				return _disabledBySettings;
			}
			set
			{
				if (_disabledBySettings == value)
				{
					return;
				}
				_disabledBySettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("backgroundOpacity")] 
		public CFloat BackgroundOpacity
		{
			get
			{
				if (_backgroundOpacity == null)
				{
					_backgroundOpacity = (CFloat) CR2WTypeManager.Create("Float", "backgroundOpacity", cr2w, this);
				}
				return _backgroundOpacity;
			}
			set
			{
				if (_backgroundOpacity == value)
				{
					return;
				}
				_backgroundOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("fontSize")] 
		public CInt32 FontSize
		{
			get
			{
				if (_fontSize == null)
				{
					_fontSize = (CInt32) CR2WTypeManager.Create("Int32", "fontSize", cr2w, this);
				}
				return _fontSize;
			}
			set
			{
				if (_fontSize == value)
				{
					return;
				}
				_fontSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("factlistenerId")] 
		public CUInt32 FactlistenerId
		{
			get
			{
				if (_factlistenerId == null)
				{
					_factlistenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "factlistenerId", cr2w, this);
				}
				return _factlistenerId;
			}
			set
			{
				if (_factlistenerId == value)
				{
					return;
				}
				_factlistenerId = value;
				PropertySet(this);
			}
		}

		public BaseSubtitlesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
