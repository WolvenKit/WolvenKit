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
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(9)] 
		[RED("uiSystemBB")] 
		public CWeakHandle<gameIBlackboard> UiSystemBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("uiSystemBBDef")] 
		public CHandle<UI_SystemDef> UiSystemBBDef
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(11)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("isShownBbId")] 
		public CHandle<redCallbackObject> IsShownBbId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("dataBbId")] 
		public CHandle<redCallbackObject> DataBbId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("photomodeActiveId")] 
		public CHandle<redCallbackObject> PhotomodeActiveId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("phoneActiveId")] 
		public CHandle<redCallbackObject> PhoneActiveId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("tutorialOnHold")] 
		public CBool TutorialOnHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("tutorialData")] 
		public gamePopupData TutorialData
		{
			get => GetPropertyValue<gamePopupData>();
			set => SetPropertyValue<gamePopupData>(value);
		}

		[Ordinal(18)] 
		[RED("tutorialSettings")] 
		public gamePopupSettings TutorialSettings
		{
			get => GetPropertyValue<gamePopupSettings>();
			set => SetPropertyValue<gamePopupSettings>(value);
		}

		[Ordinal(19)] 
		[RED("phoneMessageOnHold")] 
		public CBool PhoneMessageOnHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("phoneMessageData")] 
		public CHandle<JournalNotificationData> PhoneMessageData
		{
			get => GetPropertyValue<CHandle<JournalNotificationData>>();
			set => SetPropertyValue<CHandle<JournalNotificationData>>(value);
		}

		[Ordinal(21)] 
		[RED("shardReadOnHold")] 
		public CBool ShardReadOnHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("shardReadData")] 
		public CHandle<NotifyShardRead> ShardReadData
		{
			get => GetPropertyValue<CHandle<NotifyShardRead>>();
			set => SetPropertyValue<CHandle<NotifyShardRead>>(value);
		}

		[Ordinal(23)] 
		[RED("smartFrameData")] 
		public CHandle<inkFrameNotificationData> SmartFrameData
		{
			get => GetPropertyValue<CHandle<inkFrameNotificationData>>();
			set => SetPropertyValue<CHandle<inkFrameNotificationData>>(value);
		}

		[Ordinal(24)] 
		[RED("vehicleColorSelectorData")] 
		public CHandle<inkGameNotificationData> VehicleColorSelectorData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(25)] 
		[RED("tutorialToken")] 
		public CHandle<inkGameNotificationToken> TutorialToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(26)] 
		[RED("phoneMessageToken")] 
		public CHandle<inkGameNotificationToken> PhoneMessageToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(27)] 
		[RED("shardToken")] 
		public CHandle<inkGameNotificationToken> ShardToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(28)] 
		[RED("vehiclesManagerToken")] 
		public CHandle<inkGameNotificationToken> VehiclesManagerToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(29)] 
		[RED("vehicleRadioToken")] 
		public CHandle<inkGameNotificationToken> VehicleRadioToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(30)] 
		[RED("codexToken")] 
		public CHandle<inkGameNotificationToken> CodexToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(31)] 
		[RED("ponrToken")] 
		public CHandle<inkGameNotificationToken> PonrToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(32)] 
		[RED("twintoneOverride")] 
		public CHandle<inkGameNotificationToken> TwintoneOverride
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(33)] 
		[RED("expansionToken")] 
		public CHandle<inkGameNotificationToken> ExpansionToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(34)] 
		[RED("expansionErrorToken")] 
		public CHandle<inkGameNotificationToken> ExpansionErrorToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(35)] 
		[RED("patchNotesToken")] 
		public CHandle<inkGameNotificationToken> PatchNotesToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(36)] 
		[RED("marketingConsentToken")] 
		public CHandle<inkGameNotificationToken> MarketingConsentToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(37)] 
		[RED("signInToken")] 
		public CHandle<inkGameNotificationToken> SignInToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(38)] 
		[RED("expansionStateToken")] 
		public CHandle<inkGameNotificationToken> ExpansionStateToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(39)] 
		[RED("vehicleVisualCustomizationSelectorToken")] 
		public CHandle<inkGameNotificationToken> VehicleVisualCustomizationSelectorToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(40)] 
		[RED("frameSwitcherToken")] 
		public CHandle<inkGameNotificationToken> FrameSwitcherToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(41)] 
		[RED("isInMenu")] 
		public CBool IsInMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("isInPhotoMode")] 
		public CBool IsInPhotoMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("isOnPhone")] 
		public CBool IsOnPhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("isBlockingPopupOpened")] 
		public CBool IsBlockingPopupOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
