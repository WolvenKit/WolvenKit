using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPopupsManager : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _bracketsContainer;
		private inkCompoundWidgetReference _tutorialOverlayContainer;
		private CName _bracketLibraryID;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UIGameDataDef> _bbDefinition;
		private wCHandle<gameJournalManager> _journalManager;
		private CHandle<gameIBlackboard> _uiSystemBB;
		private CHandle<UI_SystemDef> _uiSystemBBDef;
		private CUInt32 _uiSystemId;
		private CUInt32 _isShownBbId;
		private CUInt32 _dataBbId;
		private CBool _tutorialOnHold;
		private gamePopupData _tutorialData;
		private gamePopupSettings _tutorialSettings;
		private CHandle<inkGameNotificationToken> _tutorialToken;
		private CHandle<inkGameNotificationToken> _phoneMessageToken;
		private CHandle<inkGameNotificationToken> _shardToken;
		private CHandle<inkGameNotificationToken> _vehiclesManagerToken;
		private CHandle<inkGameNotificationToken> _vehicleRadioToken;
		private CHandle<inkGameNotificationToken> _codexToken;

		[Ordinal(2)] 
		[RED("bracketsContainer")] 
		public inkCompoundWidgetReference BracketsContainer
		{
			get
			{
				if (_bracketsContainer == null)
				{
					_bracketsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "bracketsContainer", cr2w, this);
				}
				return _bracketsContainer;
			}
			set
			{
				if (_bracketsContainer == value)
				{
					return;
				}
				_bracketsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tutorialOverlayContainer")] 
		public inkCompoundWidgetReference TutorialOverlayContainer
		{
			get
			{
				if (_tutorialOverlayContainer == null)
				{
					_tutorialOverlayContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "tutorialOverlayContainer", cr2w, this);
				}
				return _tutorialOverlayContainer;
			}
			set
			{
				if (_tutorialOverlayContainer == value)
				{
					return;
				}
				_tutorialOverlayContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bracketLibraryID")] 
		public CName BracketLibraryID
		{
			get
			{
				if (_bracketLibraryID == null)
				{
					_bracketLibraryID = (CName) CR2WTypeManager.Create("CName", "bracketLibraryID", cr2w, this);
				}
				return _bracketLibraryID;
			}
			set
			{
				if (_bracketLibraryID == value)
				{
					return;
				}
				_bracketLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bbDefinition")] 
		public CHandle<UIGameDataDef> BbDefinition
		{
			get
			{
				if (_bbDefinition == null)
				{
					_bbDefinition = (CHandle<UIGameDataDef>) CR2WTypeManager.Create("handle:UIGameDataDef", "bbDefinition", cr2w, this);
				}
				return _bbDefinition;
			}
			set
			{
				if (_bbDefinition == value)
				{
					return;
				}
				_bbDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("uiSystemBB")] 
		public CHandle<gameIBlackboard> UiSystemBB
		{
			get
			{
				if (_uiSystemBB == null)
				{
					_uiSystemBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiSystemBB", cr2w, this);
				}
				return _uiSystemBB;
			}
			set
			{
				if (_uiSystemBB == value)
				{
					return;
				}
				_uiSystemBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("uiSystemBBDef")] 
		public CHandle<UI_SystemDef> UiSystemBBDef
		{
			get
			{
				if (_uiSystemBBDef == null)
				{
					_uiSystemBBDef = (CHandle<UI_SystemDef>) CR2WTypeManager.Create("handle:UI_SystemDef", "uiSystemBBDef", cr2w, this);
				}
				return _uiSystemBBDef;
			}
			set
			{
				if (_uiSystemBBDef == value)
				{
					return;
				}
				_uiSystemBBDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get
			{
				if (_uiSystemId == null)
				{
					_uiSystemId = (CUInt32) CR2WTypeManager.Create("Uint32", "uiSystemId", cr2w, this);
				}
				return _uiSystemId;
			}
			set
			{
				if (_uiSystemId == value)
				{
					return;
				}
				_uiSystemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isShownBbId")] 
		public CUInt32 IsShownBbId
		{
			get
			{
				if (_isShownBbId == null)
				{
					_isShownBbId = (CUInt32) CR2WTypeManager.Create("Uint32", "isShownBbId", cr2w, this);
				}
				return _isShownBbId;
			}
			set
			{
				if (_isShownBbId == value)
				{
					return;
				}
				_isShownBbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("dataBbId")] 
		public CUInt32 DataBbId
		{
			get
			{
				if (_dataBbId == null)
				{
					_dataBbId = (CUInt32) CR2WTypeManager.Create("Uint32", "dataBbId", cr2w, this);
				}
				return _dataBbId;
			}
			set
			{
				if (_dataBbId == value)
				{
					return;
				}
				_dataBbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("tutorialOnHold")] 
		public CBool TutorialOnHold
		{
			get
			{
				if (_tutorialOnHold == null)
				{
					_tutorialOnHold = (CBool) CR2WTypeManager.Create("Bool", "tutorialOnHold", cr2w, this);
				}
				return _tutorialOnHold;
			}
			set
			{
				if (_tutorialOnHold == value)
				{
					return;
				}
				_tutorialOnHold = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("tutorialData")] 
		public gamePopupData TutorialData
		{
			get
			{
				if (_tutorialData == null)
				{
					_tutorialData = (gamePopupData) CR2WTypeManager.Create("gamePopupData", "tutorialData", cr2w, this);
				}
				return _tutorialData;
			}
			set
			{
				if (_tutorialData == value)
				{
					return;
				}
				_tutorialData = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("tutorialSettings")] 
		public gamePopupSettings TutorialSettings
		{
			get
			{
				if (_tutorialSettings == null)
				{
					_tutorialSettings = (gamePopupSettings) CR2WTypeManager.Create("gamePopupSettings", "tutorialSettings", cr2w, this);
				}
				return _tutorialSettings;
			}
			set
			{
				if (_tutorialSettings == value)
				{
					return;
				}
				_tutorialSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("tutorialToken")] 
		public CHandle<inkGameNotificationToken> TutorialToken
		{
			get
			{
				if (_tutorialToken == null)
				{
					_tutorialToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "tutorialToken", cr2w, this);
				}
				return _tutorialToken;
			}
			set
			{
				if (_tutorialToken == value)
				{
					return;
				}
				_tutorialToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("phoneMessageToken")] 
		public CHandle<inkGameNotificationToken> PhoneMessageToken
		{
			get
			{
				if (_phoneMessageToken == null)
				{
					_phoneMessageToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "phoneMessageToken", cr2w, this);
				}
				return _phoneMessageToken;
			}
			set
			{
				if (_phoneMessageToken == value)
				{
					return;
				}
				_phoneMessageToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("shardToken")] 
		public CHandle<inkGameNotificationToken> ShardToken
		{
			get
			{
				if (_shardToken == null)
				{
					_shardToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "shardToken", cr2w, this);
				}
				return _shardToken;
			}
			set
			{
				if (_shardToken == value)
				{
					return;
				}
				_shardToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("vehiclesManagerToken")] 
		public CHandle<inkGameNotificationToken> VehiclesManagerToken
		{
			get
			{
				if (_vehiclesManagerToken == null)
				{
					_vehiclesManagerToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "vehiclesManagerToken", cr2w, this);
				}
				return _vehiclesManagerToken;
			}
			set
			{
				if (_vehiclesManagerToken == value)
				{
					return;
				}
				_vehiclesManagerToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("vehicleRadioToken")] 
		public CHandle<inkGameNotificationToken> VehicleRadioToken
		{
			get
			{
				if (_vehicleRadioToken == null)
				{
					_vehicleRadioToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "vehicleRadioToken", cr2w, this);
				}
				return _vehicleRadioToken;
			}
			set
			{
				if (_vehicleRadioToken == value)
				{
					return;
				}
				_vehicleRadioToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("codexToken")] 
		public CHandle<inkGameNotificationToken> CodexToken
		{
			get
			{
				if (_codexToken == null)
				{
					_codexToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "codexToken", cr2w, this);
				}
				return _codexToken;
			}
			set
			{
				if (_codexToken == value)
				{
					return;
				}
				_codexToken = value;
				PropertySet(this);
			}
		}

		public gameuiPopupsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
