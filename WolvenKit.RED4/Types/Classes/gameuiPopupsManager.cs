using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPopupsManager : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("bracketsContainer")] 
		public inkCompoundWidgetReference BracketsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("tutorialOverlayContainer")] 
		public inkCompoundWidgetReference TutorialOverlayContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("bracketLibraryID")] 
		public CName BracketLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("bbDefinition")] 
		public CHandle<UIGameDataDef> BbDefinition
		{
			get => GetPropertyValue<CHandle<UIGameDataDef>>();
			set => SetPropertyValue<CHandle<UIGameDataDef>>(value);
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(8)] 
		[RED("uiSystemBB")] 
		public CWeakHandle<gameIBlackboard> UiSystemBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(9)] 
		[RED("uiSystemBBDef")] 
		public CHandle<UI_SystemDef> UiSystemBBDef
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(10)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("isShownBbId")] 
		public CHandle<redCallbackObject> IsShownBbId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("dataBbId")] 
		public CHandle<redCallbackObject> DataBbId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("photomodeActiveId")] 
		public CHandle<redCallbackObject> PhotomodeActiveId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("tutorialOnHold")] 
		public CBool TutorialOnHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("tutorialData")] 
		public gamePopupData TutorialData
		{
			get => GetPropertyValue<gamePopupData>();
			set => SetPropertyValue<gamePopupData>(value);
		}

		[Ordinal(16)] 
		[RED("tutorialSettings")] 
		public gamePopupSettings TutorialSettings
		{
			get => GetPropertyValue<gamePopupSettings>();
			set => SetPropertyValue<gamePopupSettings>(value);
		}

		[Ordinal(17)] 
		[RED("phoneMessageOnHold")] 
		public CBool PhoneMessageOnHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("phoneMessageData")] 
		public CHandle<JournalNotificationData> PhoneMessageData
		{
			get => GetPropertyValue<CHandle<JournalNotificationData>>();
			set => SetPropertyValue<CHandle<JournalNotificationData>>(value);
		}

		[Ordinal(19)] 
		[RED("shardReadOnHold")] 
		public CBool ShardReadOnHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("shardReadData")] 
		public CHandle<NotifyShardRead> ShardReadData
		{
			get => GetPropertyValue<CHandle<NotifyShardRead>>();
			set => SetPropertyValue<CHandle<NotifyShardRead>>(value);
		}

		[Ordinal(21)] 
		[RED("tutorialToken")] 
		public CHandle<inkGameNotificationToken> TutorialToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(22)] 
		[RED("phoneMessageToken")] 
		public CHandle<inkGameNotificationToken> PhoneMessageToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(23)] 
		[RED("shardToken")] 
		public CHandle<inkGameNotificationToken> ShardToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(24)] 
		[RED("vehiclesManagerToken")] 
		public CHandle<inkGameNotificationToken> VehiclesManagerToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(25)] 
		[RED("vehicleRadioToken")] 
		public CHandle<inkGameNotificationToken> VehicleRadioToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(26)] 
		[RED("codexToken")] 
		public CHandle<inkGameNotificationToken> CodexToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(27)] 
		[RED("ponrToken")] 
		public CHandle<inkGameNotificationToken> PonrToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(28)] 
		[RED("expansionToken")] 
		public CHandle<inkGameNotificationToken> ExpansionToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(29)] 
		[RED("expansionErrorToken")] 
		public CHandle<inkGameNotificationToken> ExpansionErrorToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(30)] 
		[RED("patchNotesToken")] 
		public CHandle<inkGameNotificationToken> PatchNotesToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(31)] 
		[RED("expansionStateToken")] 
		public CHandle<inkGameNotificationToken> ExpansionStateToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		public gameuiPopupsManager()
		{
			BracketsContainer = new inkCompoundWidgetReference();
			TutorialOverlayContainer = new inkCompoundWidgetReference();
			TutorialData = new gamePopupData { MessageOverrideDataList = new(), VideoType = Enums.gameVideoType.Unknown };
			TutorialSettings = new gamePopupSettings { CloseAtInput = true, Position = Enums.gamePopupPosition.Center, Margin = new inkMargin() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
