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
			get => GetProperty(ref _bracketsContainer);
			set => SetProperty(ref _bracketsContainer, value);
		}

		[Ordinal(3)] 
		[RED("tutorialOverlayContainer")] 
		public inkCompoundWidgetReference TutorialOverlayContainer
		{
			get => GetProperty(ref _tutorialOverlayContainer);
			set => SetProperty(ref _tutorialOverlayContainer, value);
		}

		[Ordinal(4)] 
		[RED("bracketLibraryID")] 
		public CName BracketLibraryID
		{
			get => GetProperty(ref _bracketLibraryID);
			set => SetProperty(ref _bracketLibraryID, value);
		}

		[Ordinal(5)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(6)] 
		[RED("bbDefinition")] 
		public CHandle<UIGameDataDef> BbDefinition
		{
			get => GetProperty(ref _bbDefinition);
			set => SetProperty(ref _bbDefinition, value);
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(8)] 
		[RED("uiSystemBB")] 
		public CHandle<gameIBlackboard> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(9)] 
		[RED("uiSystemBBDef")] 
		public CHandle<UI_SystemDef> UiSystemBBDef
		{
			get => GetProperty(ref _uiSystemBBDef);
			set => SetProperty(ref _uiSystemBBDef, value);
		}

		[Ordinal(10)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		[Ordinal(11)] 
		[RED("isShownBbId")] 
		public CUInt32 IsShownBbId
		{
			get => GetProperty(ref _isShownBbId);
			set => SetProperty(ref _isShownBbId, value);
		}

		[Ordinal(12)] 
		[RED("dataBbId")] 
		public CUInt32 DataBbId
		{
			get => GetProperty(ref _dataBbId);
			set => SetProperty(ref _dataBbId, value);
		}

		[Ordinal(13)] 
		[RED("tutorialOnHold")] 
		public CBool TutorialOnHold
		{
			get => GetProperty(ref _tutorialOnHold);
			set => SetProperty(ref _tutorialOnHold, value);
		}

		[Ordinal(14)] 
		[RED("tutorialData")] 
		public gamePopupData TutorialData
		{
			get => GetProperty(ref _tutorialData);
			set => SetProperty(ref _tutorialData, value);
		}

		[Ordinal(15)] 
		[RED("tutorialSettings")] 
		public gamePopupSettings TutorialSettings
		{
			get => GetProperty(ref _tutorialSettings);
			set => SetProperty(ref _tutorialSettings, value);
		}

		[Ordinal(16)] 
		[RED("tutorialToken")] 
		public CHandle<inkGameNotificationToken> TutorialToken
		{
			get => GetProperty(ref _tutorialToken);
			set => SetProperty(ref _tutorialToken, value);
		}

		[Ordinal(17)] 
		[RED("phoneMessageToken")] 
		public CHandle<inkGameNotificationToken> PhoneMessageToken
		{
			get => GetProperty(ref _phoneMessageToken);
			set => SetProperty(ref _phoneMessageToken, value);
		}

		[Ordinal(18)] 
		[RED("shardToken")] 
		public CHandle<inkGameNotificationToken> ShardToken
		{
			get => GetProperty(ref _shardToken);
			set => SetProperty(ref _shardToken, value);
		}

		[Ordinal(19)] 
		[RED("vehiclesManagerToken")] 
		public CHandle<inkGameNotificationToken> VehiclesManagerToken
		{
			get => GetProperty(ref _vehiclesManagerToken);
			set => SetProperty(ref _vehiclesManagerToken, value);
		}

		[Ordinal(20)] 
		[RED("vehicleRadioToken")] 
		public CHandle<inkGameNotificationToken> VehicleRadioToken
		{
			get => GetProperty(ref _vehicleRadioToken);
			set => SetProperty(ref _vehicleRadioToken, value);
		}

		[Ordinal(21)] 
		[RED("codexToken")] 
		public CHandle<inkGameNotificationToken> CodexToken
		{
			get => GetProperty(ref _codexToken);
			set => SetProperty(ref _codexToken, value);
		}

		public gameuiPopupsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
