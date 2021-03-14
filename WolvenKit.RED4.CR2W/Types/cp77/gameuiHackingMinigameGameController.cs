using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHackingMinigameGameController : gameuiWidgetGameController
	{
		private TweakDBID _symbolsRecordTDBID;
		private TweakDBID _minigameDefaultsTDBID;
		private wCHandle<gamedataMinigame_Def_Record> _miniGameRecord;
		private CInt32 _dimension;
		private CBool _isTutorialActive;
		private CBool _isOfficerBreach;
		private CBool _isRemoteBreach;
		private CBool _isItemBreach;
		private CInt32 _numberAttempts;
		private inkWidgetReference _tooltipsManagerRef;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CBool _contextHelpOverlay;
		private CHandle<gameIBlackboard> _bbMinigame;
		private CUInt32 _bbMinigameStateListener;
		private CHandle<gameIBlackboard> _bbUiData;
		private CUInt32 _bbControllerStateListener;

		[Ordinal(2)] 
		[RED("symbolsRecordTDBID")] 
		public TweakDBID SymbolsRecordTDBID
		{
			get
			{
				if (_symbolsRecordTDBID == null)
				{
					_symbolsRecordTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "symbolsRecordTDBID", cr2w, this);
				}
				return _symbolsRecordTDBID;
			}
			set
			{
				if (_symbolsRecordTDBID == value)
				{
					return;
				}
				_symbolsRecordTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("minigameDefaultsTDBID")] 
		public TweakDBID MinigameDefaultsTDBID
		{
			get
			{
				if (_minigameDefaultsTDBID == null)
				{
					_minigameDefaultsTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "minigameDefaultsTDBID", cr2w, this);
				}
				return _minigameDefaultsTDBID;
			}
			set
			{
				if (_minigameDefaultsTDBID == value)
				{
					return;
				}
				_minigameDefaultsTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("miniGameRecord")] 
		public wCHandle<gamedataMinigame_Def_Record> MiniGameRecord
		{
			get
			{
				if (_miniGameRecord == null)
				{
					_miniGameRecord = (wCHandle<gamedataMinigame_Def_Record>) CR2WTypeManager.Create("whandle:gamedataMinigame_Def_Record", "miniGameRecord", cr2w, this);
				}
				return _miniGameRecord;
			}
			set
			{
				if (_miniGameRecord == value)
				{
					return;
				}
				_miniGameRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dimension")] 
		public CInt32 Dimension
		{
			get
			{
				if (_dimension == null)
				{
					_dimension = (CInt32) CR2WTypeManager.Create("Int32", "dimension", cr2w, this);
				}
				return _dimension;
			}
			set
			{
				if (_dimension == value)
				{
					return;
				}
				_dimension = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isTutorialActive")] 
		public CBool IsTutorialActive
		{
			get
			{
				if (_isTutorialActive == null)
				{
					_isTutorialActive = (CBool) CR2WTypeManager.Create("Bool", "isTutorialActive", cr2w, this);
				}
				return _isTutorialActive;
			}
			set
			{
				if (_isTutorialActive == value)
				{
					return;
				}
				_isTutorialActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isOfficerBreach")] 
		public CBool IsOfficerBreach
		{
			get
			{
				if (_isOfficerBreach == null)
				{
					_isOfficerBreach = (CBool) CR2WTypeManager.Create("Bool", "isOfficerBreach", cr2w, this);
				}
				return _isOfficerBreach;
			}
			set
			{
				if (_isOfficerBreach == value)
				{
					return;
				}
				_isOfficerBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isRemoteBreach")] 
		public CBool IsRemoteBreach
		{
			get
			{
				if (_isRemoteBreach == null)
				{
					_isRemoteBreach = (CBool) CR2WTypeManager.Create("Bool", "isRemoteBreach", cr2w, this);
				}
				return _isRemoteBreach;
			}
			set
			{
				if (_isRemoteBreach == value)
				{
					return;
				}
				_isRemoteBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isItemBreach")] 
		public CBool IsItemBreach
		{
			get
			{
				if (_isItemBreach == null)
				{
					_isItemBreach = (CBool) CR2WTypeManager.Create("Bool", "isItemBreach", cr2w, this);
				}
				return _isItemBreach;
			}
			set
			{
				if (_isItemBreach == value)
				{
					return;
				}
				_isItemBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("numberAttempts")] 
		public CInt32 NumberAttempts
		{
			get
			{
				if (_numberAttempts == null)
				{
					_numberAttempts = (CInt32) CR2WTypeManager.Create("Int32", "numberAttempts", cr2w, this);
				}
				return _numberAttempts;
			}
			set
			{
				if (_numberAttempts == value)
				{
					return;
				}
				_numberAttempts = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get
			{
				if (_uiSystem == null)
				{
					_uiSystem = (CHandle<gameuiGameSystemUI>) CR2WTypeManager.Create("handle:gameuiGameSystemUI", "uiSystem", cr2w, this);
				}
				return _uiSystem;
			}
			set
			{
				if (_uiSystem == value)
				{
					return;
				}
				_uiSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("contextHelpOverlay")] 
		public CBool ContextHelpOverlay
		{
			get
			{
				if (_contextHelpOverlay == null)
				{
					_contextHelpOverlay = (CBool) CR2WTypeManager.Create("Bool", "contextHelpOverlay", cr2w, this);
				}
				return _contextHelpOverlay;
			}
			set
			{
				if (_contextHelpOverlay == value)
				{
					return;
				}
				_contextHelpOverlay = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bbMinigame")] 
		public CHandle<gameIBlackboard> BbMinigame
		{
			get
			{
				if (_bbMinigame == null)
				{
					_bbMinigame = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbMinigame", cr2w, this);
				}
				return _bbMinigame;
			}
			set
			{
				if (_bbMinigame == value)
				{
					return;
				}
				_bbMinigame = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bbMinigameStateListener")] 
		public CUInt32 BbMinigameStateListener
		{
			get
			{
				if (_bbMinigameStateListener == null)
				{
					_bbMinigameStateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "bbMinigameStateListener", cr2w, this);
				}
				return _bbMinigameStateListener;
			}
			set
			{
				if (_bbMinigameStateListener == value)
				{
					return;
				}
				_bbMinigameStateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bbUiData")] 
		public CHandle<gameIBlackboard> BbUiData
		{
			get
			{
				if (_bbUiData == null)
				{
					_bbUiData = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbUiData", cr2w, this);
				}
				return _bbUiData;
			}
			set
			{
				if (_bbUiData == value)
				{
					return;
				}
				_bbUiData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bbControllerStateListener")] 
		public CUInt32 BbControllerStateListener
		{
			get
			{
				if (_bbControllerStateListener == null)
				{
					_bbControllerStateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "bbControllerStateListener", cr2w, this);
				}
				return _bbControllerStateListener;
			}
			set
			{
				if (_bbControllerStateListener == value)
				{
					return;
				}
				_bbControllerStateListener = value;
				PropertySet(this);
			}
		}

		public gameuiHackingMinigameGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
