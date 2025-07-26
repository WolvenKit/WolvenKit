using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWorldMapMenuGameController : gameuiMappinsContainerController
	{
		[Ordinal(18)] 
		[RED("settingsRecordID")] 
		public TweakDBID SettingsRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(19)] 
		[RED("selectedMappin")] 
		public CWeakHandle<gameuiBaseWorldMapMappinController> SelectedMappin
		{
			get => GetPropertyValue<CWeakHandle<gameuiBaseWorldMapMappinController>>();
			set => SetPropertyValue<CWeakHandle<gameuiBaseWorldMapMappinController>>(value);
		}

		[Ordinal(20)] 
		[RED("playerOnTop")] 
		public CBool PlayerOnTop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("entityPreviewLibraryID")] 
		public CName EntityPreviewLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("entityPreviewSpawnContainer")] 
		public inkCompoundWidgetReference EntityPreviewSpawnContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("floorPlanSpawnContainer")] 
		public inkCompoundWidgetReference FloorPlanSpawnContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("districtsContainer")] 
		public inkCompoundWidgetReference DistrictsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("subdistrictsContainer")] 
		public inkCompoundWidgetReference SubdistrictsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("mappinOutlinesContainer")] 
		public inkCompoundWidgetReference MappinOutlinesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("groupOutlinesContainer")] 
		public inkCompoundWidgetReference GroupOutlinesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("tooltipContainer")] 
		public inkCompoundWidgetReference TooltipContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("tooltipOffset")] 
		public inkMargin TooltipOffset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(31)] 
		[RED("tooltipDistrictOffset")] 
		public inkMargin TooltipDistrictOffset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(32)] 
		[RED("districtView")] 
		public CEnum<gameuiEWorldMapDistrictView> DistrictView
		{
			get => GetPropertyValue<CEnum<gameuiEWorldMapDistrictView>>();
			set => SetPropertyValue<CEnum<gameuiEWorldMapDistrictView>>(value);
		}

		[Ordinal(33)] 
		[RED("hoveredDistrict")] 
		public CEnum<gamedataDistrict> HoveredDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(34)] 
		[RED("hoveredSubDistrict")] 
		public CEnum<gamedataDistrict> HoveredSubDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(35)] 
		[RED("selectedDistrict")] 
		public CEnum<gamedataDistrict> SelectedDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(36)] 
		[RED("canChangeCustomFilter")] 
		public CBool CanChangeCustomFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("isZoomToMappinEnabled")] 
		public CBool IsZoomToMappinEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("delamainTaxiMappinID")] 
		public gameNewMappinID DelamainTaxiMappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(39)] 
		[RED("preloaderWidget")] 
		public inkWidgetReference PreloaderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("fastTravelInstructions")] 
		public inkWidgetReference FastTravelInstructions
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("delamainTaxiInstructions")] 
		public inkWidgetReference DelamainTaxiInstructions
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("filterSelector")] 
		public inkWidgetReference FilterSelector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("filterSelectorWarning")] 
		public inkWidgetReference FilterSelectorWarning
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("filterText")] 
		public inkTextWidgetReference FilterText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("districtIconImageContainer")] 
		public inkWidgetReference DistrictIconImageContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("districtIconImage")] 
		public inkImageWidgetReference DistrictIconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("districtNameText")] 
		public inkTextWidgetReference DistrictNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("subdistrictNameText")] 
		public inkTextWidgetReference SubdistrictNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("locationAndGangsContainer")] 
		public inkWidgetReference LocationAndGangsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("gangsInfoContainer")] 
		public inkWidgetReference GangsInfoContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("gangsList")] 
		public inkCompoundWidgetReference GangsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("questContainer")] 
		public inkWidgetReference QuestContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("questName")] 
		public inkTextWidgetReference QuestName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("openInJournalButton")] 
		public inkWidgetReference OpenInJournalButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(57)] 
		[RED("objectiveBackground")] 
		public inkWidgetReference ObjectiveBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("objectiveFrame")] 
		public inkWidgetReference ObjectiveFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(59)] 
		[RED("topShadow")] 
		public inkWidgetReference TopShadow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(60)] 
		[RED("rightAxisZoomThreshold")] 
		public CFloat RightAxisZoomThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("customFilters")] 
		public inkWidgetReference CustomFilters
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(62)] 
		[RED("filtersList")] 
		public inkVerticalPanelWidgetReference FiltersList
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(63)] 
		[RED("filterLeftArrow")] 
		public inkWidgetReference FilterLeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(64)] 
		[RED("filterRightArrow")] 
		public inkWidgetReference FilterRightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(65)] 
		[RED("quickFilterIndicators")] 
		public CArray<inkWidgetReference> QuickFilterIndicators
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(66)] 
		[RED("customFiltersListAnimationDelay")] 
		public CFloat CustomFiltersListAnimationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(67)] 
		[RED("cameraMode")] 
		public CEnum<gameuiEWorldMapCameraMode> CameraMode
		{
			get => GetPropertyValue<CEnum<gameuiEWorldMapCameraMode>>();
			set => SetPropertyValue<CEnum<gameuiEWorldMapCameraMode>>(value);
		}

		[Ordinal(68)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(69)] 
		[RED("tooltipController")] 
		public CWeakHandle<WorldMapTooltipContainer> TooltipController
		{
			get => GetPropertyValue<CWeakHandle<WorldMapTooltipContainer>>();
			set => SetPropertyValue<CWeakHandle<WorldMapTooltipContainer>>(value);
		}

		[Ordinal(70)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(71)] 
		[RED("previousHoveredDistrict")] 
		public CEnum<gamedataDistrict> PreviousHoveredDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(72)] 
		[RED("currentHoveredDistrict")] 
		public CEnum<gamedataDistrict> CurrentHoveredDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(73)] 
		[RED("showedSubdistrictGangs")] 
		public CBool ShowedSubdistrictGangs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(75)] 
		[RED("audioSystem")] 
		public CWeakHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetPropertyValue<CWeakHandle<gameGameAudioSystem>>();
			set => SetPropertyValue<CWeakHandle<gameGameAudioSystem>>(value);
		}

		[Ordinal(76)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(77)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>(value);
		}

		[Ordinal(78)] 
		[RED("mapBlackboard")] 
		public CWeakHandle<gameIBlackboard> MapBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(79)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(80)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjectiveBase> TrackedObjective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>(value);
		}

		[Ordinal(81)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(82)] 
		[RED("mappinsPositions")] 
		public CArray<Vector3> MappinsPositions
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(83)] 
		[RED("lastRightAxisYAmount")] 
		public CFloat LastRightAxisYAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(84)] 
		[RED("justOpenedQuestJournal")] 
		public CBool JustOpenedQuestJournal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(85)] 
		[RED("initMappinFocus")] 
		public CHandle<MapMenuUserData> InitMappinFocus
		{
			get => GetPropertyValue<CHandle<MapMenuUserData>>();
			set => SetPropertyValue<CHandle<MapMenuUserData>>(value);
		}

		[Ordinal(86)] 
		[RED("currentQuickFilterIndex")] 
		public CInt32 CurrentQuickFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(87)] 
		[RED("currentCustomFilterIndex")] 
		public CInt32 CurrentCustomFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(88)] 
		[RED("spawnedCustomFilterIndex")] 
		public CInt32 SpawnedCustomFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(89)] 
		[RED("gangsAsyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> GangsAsyncSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(90)] 
		[RED("customFiltersList")] 
		public CArray<CWeakHandle<WorldMapFiltersListItem>> CustomFiltersList
		{
			get => GetPropertyValue<CArray<CWeakHandle<WorldMapFiltersListItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<WorldMapFiltersListItem>>>(value);
		}

		[Ordinal(91)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(92)] 
		[RED("entityAttached")] 
		public CBool EntityAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(93)] 
		[RED("readyToZoom")] 
		public CBool ReadyToZoom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(94)] 
		[RED("isHoveringOverFilters")] 
		public CBool IsHoveringOverFilters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(95)] 
		[RED("isPanning")] 
		public CBool IsPanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(96)] 
		[RED("isZooming")] 
		public CBool IsZooming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
		[RED("pressedRMB")] 
		public CBool PressedRMB
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("startedFastTraveling")] 
		public CBool StartedFastTraveling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiWorldMapMenuGameController()
		{
			EntityPreviewSpawnContainer = new inkCompoundWidgetReference();
			FloorPlanSpawnContainer = new inkCompoundWidgetReference();
			CompassWidget = new inkWidgetReference();
			DistrictsContainer = new inkCompoundWidgetReference();
			SubdistrictsContainer = new inkCompoundWidgetReference();
			MappinOutlinesContainer = new inkCompoundWidgetReference();
			GroupOutlinesContainer = new inkCompoundWidgetReference();
			TooltipContainer = new inkCompoundWidgetReference();
			TooltipOffset = new inkMargin();
			TooltipDistrictOffset = new inkMargin();
			HoveredDistrict = Enums.gamedataDistrict.Invalid;
			HoveredSubDistrict = Enums.gamedataDistrict.Invalid;
			SelectedDistrict = Enums.gamedataDistrict.Invalid;
			CanChangeCustomFilter = true;
			DelamainTaxiMappinID = new gameNewMappinID();
			PreloaderWidget = new inkWidgetReference();
			GameTimeText = new inkTextWidgetReference();
			FastTravelInstructions = new inkWidgetReference();
			DelamainTaxiInstructions = new inkWidgetReference();
			FilterSelector = new inkWidgetReference();
			FilterSelectorWarning = new inkWidgetReference();
			FilterText = new inkTextWidgetReference();
			DistrictIconImageContainer = new inkWidgetReference();
			DistrictIconImage = new inkImageWidgetReference();
			DistrictNameText = new inkTextWidgetReference();
			SubdistrictNameText = new inkTextWidgetReference();
			LocationAndGangsContainer = new inkWidgetReference();
			GangsInfoContainer = new inkWidgetReference();
			GangsList = new inkCompoundWidgetReference();
			QuestContainer = new inkWidgetReference();
			QuestName = new inkTextWidgetReference();
			OpenInJournalButton = new inkWidgetReference();
			ObjectiveName = new inkTextWidgetReference();
			ObjectiveBackground = new inkWidgetReference();
			ObjectiveFrame = new inkWidgetReference();
			TopShadow = new inkWidgetReference();
			RightAxisZoomThreshold = 0.800000F;
			CustomFilters = new inkWidgetReference();
			FiltersList = new inkVerticalPanelWidgetReference();
			FilterLeftArrow = new inkWidgetReference();
			FilterRightArrow = new inkWidgetReference();
			QuickFilterIndicators = new();
			MappinsPositions = new();
			GangsAsyncSpawnRequests = new();
			CustomFiltersList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
