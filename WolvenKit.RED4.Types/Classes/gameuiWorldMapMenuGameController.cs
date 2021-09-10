using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWorldMapMenuGameController : gameuiMappinsContainerController
	{
		[Ordinal(16)] 
		[RED("settingsRecordID")] 
		public TweakDBID SettingsRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(17)] 
		[RED("selectedMappin")] 
		public CWeakHandle<gameuiBaseWorldMapMappinController> SelectedMappin
		{
			get => GetPropertyValue<CWeakHandle<gameuiBaseWorldMapMappinController>>();
			set => SetPropertyValue<CWeakHandle<gameuiBaseWorldMapMappinController>>(value);
		}

		[Ordinal(18)] 
		[RED("playerOnTop")] 
		public CBool PlayerOnTop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("entityPreviewLibraryID")] 
		public CName EntityPreviewLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("entityPreviewSpawnContainer")] 
		public inkCompoundWidgetReference EntityPreviewSpawnContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("floorPlanSpawnContainer")] 
		public inkCompoundWidgetReference FloorPlanSpawnContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("districtsContainer")] 
		public inkCompoundWidgetReference DistrictsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("subdistrictsContainer")] 
		public inkCompoundWidgetReference SubdistrictsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("mappinOutlinesContainer")] 
		public inkCompoundWidgetReference MappinOutlinesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("groupOutlinesContainer")] 
		public inkCompoundWidgetReference GroupOutlinesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("tooltipContainer")] 
		public inkCompoundWidgetReference TooltipContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("tooltipOffset")] 
		public inkMargin TooltipOffset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(29)] 
		[RED("tooltipDistrictOffset")] 
		public inkMargin TooltipDistrictOffset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(30)] 
		[RED("districtView")] 
		public CEnum<gameuiEWorldMapDistrictView> DistrictView
		{
			get => GetPropertyValue<CEnum<gameuiEWorldMapDistrictView>>();
			set => SetPropertyValue<CEnum<gameuiEWorldMapDistrictView>>(value);
		}

		[Ordinal(31)] 
		[RED("hoveredDistrict")] 
		public CEnum<gamedataDistrict> HoveredDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(32)] 
		[RED("hoveredSubDistrict")] 
		public CEnum<gamedataDistrict> HoveredSubDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(33)] 
		[RED("selectedDistrict")] 
		public CEnum<gamedataDistrict> SelectedDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(34)] 
		[RED("canChangeCustomFilter")] 
		public CBool CanChangeCustomFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("isZoomToMappinEnabled")] 
		public CBool IsZoomToMappinEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("contentWidget")] 
		public inkWidgetReference ContentWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("timeSkipBtn")] 
		public inkWidgetReference TimeSkipBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("zoomContainer")] 
		public inkWidgetReference ZoomContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("zoomLevelContainer")] 
		public inkWidgetReference ZoomLevelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("zoomLevelText")] 
		public inkTextWidgetReference ZoomLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("filterContainer")] 
		public inkWidgetReference FilterContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("filterText")] 
		public inkTextWidgetReference FilterText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("fastTravelInstructions")] 
		public inkWidgetReference FastTravelInstructions
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("legendWrapper")] 
		public inkWidgetReference LegendWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("districtIconImage")] 
		public inkImageWidgetReference DistrictIconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("districtNameText")] 
		public inkTextWidgetReference DistrictNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("subdistrictNameText")] 
		public inkTextWidgetReference SubdistrictNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("questLinkInputHint")] 
		public inkWidgetReference QuestLinkInputHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("questContainer")] 
		public inkWidgetReference QuestContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("questName")] 
		public inkTextWidgetReference QuestName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("rightAxisZoomThreshold")] 
		public CFloat RightAxisZoomThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("view")] 
		public CEnum<EWorldMapView> View
		{
			get => GetPropertyValue<CEnum<EWorldMapView>>();
			set => SetPropertyValue<CEnum<EWorldMapView>>(value);
		}

		[Ordinal(55)] 
		[RED("cameraMode")] 
		public CEnum<gameuiEWorldMapCameraMode> CameraMode
		{
			get => GetPropertyValue<CEnum<gameuiEWorldMapCameraMode>>();
			set => SetPropertyValue<CEnum<gameuiEWorldMapCameraMode>>(value);
		}

		[Ordinal(56)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(57)] 
		[RED("tooltipController")] 
		public CWeakHandle<WorldMapTooltipContainer> TooltipController
		{
			get => GetPropertyValue<CWeakHandle<WorldMapTooltipContainer>>();
			set => SetPropertyValue<CWeakHandle<WorldMapTooltipContainer>>(value);
		}

		[Ordinal(58)] 
		[RED("legendController")] 
		public CWeakHandle<WorldMapLegendController> LegendController
		{
			get => GetPropertyValue<CWeakHandle<WorldMapLegendController>>();
			set => SetPropertyValue<CWeakHandle<WorldMapLegendController>>(value);
		}

		[Ordinal(59)] 
		[RED("timeSkipPopupToken")] 
		public CHandle<inkGameNotificationToken> TimeSkipPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(60)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(61)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(62)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(63)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>(value);
		}

		[Ordinal(64)] 
		[RED("mapBlackboard")] 
		public CWeakHandle<gameIBlackboard> MapBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(65)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(66)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjectiveBase> TrackedObjective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>(value);
		}

		[Ordinal(67)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(68)] 
		[RED("mappinsPositions")] 
		public CArray<Vector3> MappinsPositions
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(69)] 
		[RED("lastRightAxisYAmount")] 
		public CFloat LastRightAxisYAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("justOpenedQuestJournal")] 
		public CBool JustOpenedQuestJournal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("initPosition")] 
		public Vector3 InitPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameuiWorldMapMenuGameController()
		{
			EntityPreviewSpawnContainer = new();
			FloorPlanSpawnContainer = new();
			CompassWidget = new();
			DistrictsContainer = new();
			SubdistrictsContainer = new();
			MappinOutlinesContainer = new();
			GroupOutlinesContainer = new();
			TooltipContainer = new();
			TooltipOffset = new();
			TooltipDistrictOffset = new();
			HoveredDistrict = Enums.gamedataDistrict.Invalid;
			HoveredSubDistrict = Enums.gamedataDistrict.Invalid;
			SelectedDistrict = Enums.gamedataDistrict.Invalid;
			CanChangeCustomFilter = true;
			ContentWidget = new();
			TimeSkipBtn = new();
			GameTimeText = new();
			ZoomContainer = new();
			ZoomLevelContainer = new();
			ZoomLevelText = new();
			FilterContainer = new();
			FilterText = new();
			FastTravelInstructions = new();
			LegendWrapper = new();
			DistrictIconImage = new();
			DistrictNameText = new();
			SubdistrictNameText = new();
			QuestLinkInputHint = new();
			QuestContainer = new();
			QuestName = new();
			ObjectiveName = new();
			RightAxisZoomThreshold = 0.800000F;
			MappinsPositions = new();
			InitPosition = new();
		}
	}
}
