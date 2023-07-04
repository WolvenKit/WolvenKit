using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("preloaderWidget")] 
		public inkWidgetReference PreloaderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("fastTravelInstructions")] 
		public inkWidgetReference FastTravelInstructions
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("filterSelector")] 
		public inkWidgetReference FilterSelector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("filterSelectorWarning")] 
		public inkWidgetReference FilterSelectorWarning
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("filterText")] 
		public inkTextWidgetReference FilterText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("districtIconImage")] 
		public inkImageWidgetReference DistrictIconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("districtNameText")] 
		public inkTextWidgetReference DistrictNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("subdistrictNameText")] 
		public inkTextWidgetReference SubdistrictNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("locationAndGangsContainer")] 
		public inkWidgetReference LocationAndGangsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("gangsInfoContainer")] 
		public inkWidgetReference GangsInfoContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("gangsList")] 
		public inkCompoundWidgetReference GangsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("questContainer")] 
		public inkWidgetReference QuestContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("questName")] 
		public inkTextWidgetReference QuestName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("objectiveBackground")] 
		public inkWidgetReference ObjectiveBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("objectiveFrame")] 
		public inkWidgetReference ObjectiveFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("topShadow")] 
		public inkWidgetReference TopShadow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("rightAxisZoomThreshold")] 
		public CFloat RightAxisZoomThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("customFilters")] 
		public inkWidgetReference CustomFilters
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("filtersList")] 
		public inkVerticalPanelWidgetReference FiltersList
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(57)] 
		[RED("filterLeftArrow")] 
		public inkWidgetReference FilterLeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("filterRightArrow")] 
		public inkWidgetReference FilterRightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(59)] 
		[RED("quickFilterIndicators")] 
		public CArray<inkWidgetReference> QuickFilterIndicators
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(60)] 
		[RED("customFiltersListAnimationDelay")] 
		public CFloat CustomFiltersListAnimationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("cameraMode")] 
		public CEnum<gameuiEWorldMapCameraMode> CameraMode
		{
			get => GetPropertyValue<CEnum<gameuiEWorldMapCameraMode>>();
			set => SetPropertyValue<CEnum<gameuiEWorldMapCameraMode>>(value);
		}

		[Ordinal(62)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(63)] 
		[RED("tooltipController")] 
		public CWeakHandle<WorldMapTooltipContainer> TooltipController
		{
			get => GetPropertyValue<CWeakHandle<WorldMapTooltipContainer>>();
			set => SetPropertyValue<CWeakHandle<WorldMapTooltipContainer>>(value);
		}

		[Ordinal(64)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(65)] 
		[RED("previousHoveredDistrict")] 
		public CEnum<gamedataDistrict> PreviousHoveredDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(66)] 
		[RED("currentHoveredDistrict")] 
		public CEnum<gamedataDistrict> CurrentHoveredDistrict
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(67)] 
		[RED("showedSubdistrictGangs")] 
		public CBool ShowedSubdistrictGangs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(69)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(70)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>(value);
		}

		[Ordinal(71)] 
		[RED("mapBlackboard")] 
		public CWeakHandle<gameIBlackboard> MapBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(72)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(73)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjectiveBase> TrackedObjective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>(value);
		}

		[Ordinal(74)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(75)] 
		[RED("mappinsPositions")] 
		public CArray<Vector3> MappinsPositions
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(76)] 
		[RED("lastRightAxisYAmount")] 
		public CFloat LastRightAxisYAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(77)] 
		[RED("justOpenedQuestJournal")] 
		public CBool JustOpenedQuestJournal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("initPosition")] 
		public Vector3 InitPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(79)] 
		[RED("currentQuickFilterIndex")] 
		public CInt32 CurrentQuickFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(80)] 
		[RED("currentCustomFilterIndex")] 
		public CInt32 CurrentCustomFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(81)] 
		[RED("spawnedCustomFilterIndex")] 
		public CInt32 SpawnedCustomFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(82)] 
		[RED("quickFilterLeftArrow")] 
		public CWeakHandle<inkButtonController> QuickFilterLeftArrow
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(83)] 
		[RED("quickFilterRightArrow")] 
		public CWeakHandle<inkButtonController> QuickFilterRightArrow
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(84)] 
		[RED("gangsAsyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> GangsAsyncSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(85)] 
		[RED("customFiltersList")] 
		public CArray<CWeakHandle<WorldMapFiltersListItem>> CustomFiltersList
		{
			get => GetPropertyValue<CArray<CWeakHandle<WorldMapFiltersListItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<WorldMapFiltersListItem>>>(value);
		}

		[Ordinal(86)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(87)] 
		[RED("entityAttached")] 
		public CBool EntityAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(88)] 
		[RED("readyToZoom")] 
		public CBool ReadyToZoom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
			PreloaderWidget = new();
			GameTimeText = new();
			FastTravelInstructions = new();
			FilterSelector = new();
			FilterSelectorWarning = new();
			FilterText = new();
			DistrictIconImage = new();
			DistrictNameText = new();
			SubdistrictNameText = new();
			LocationAndGangsContainer = new();
			GangsInfoContainer = new();
			GangsList = new();
			QuestContainer = new();
			QuestName = new();
			ObjectiveName = new();
			ObjectiveBackground = new();
			ObjectiveFrame = new();
			TopShadow = new();
			RightAxisZoomThreshold = 0.800000F;
			CustomFilters = new();
			FiltersList = new();
			FilterLeftArrow = new();
			FilterRightArrow = new();
			QuickFilterIndicators = new();
			MappinsPositions = new();
			InitPosition = new();
			GangsAsyncSpawnRequests = new();
			CustomFiltersList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
