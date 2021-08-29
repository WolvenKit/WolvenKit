using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWorldMapMenuGameController : gameuiMappinsContainerController
	{
		private TweakDBID _settingsRecordID;
		private CWeakHandle<gameuiBaseWorldMapMappinController> _selectedMappin;
		private CBool _playerOnTop;
		private CName _entityPreviewLibraryID;
		private inkCompoundWidgetReference _entityPreviewSpawnContainer;
		private inkCompoundWidgetReference _floorPlanSpawnContainer;
		private inkWidgetReference _compassWidget;
		private inkCompoundWidgetReference _districtsContainer;
		private inkCompoundWidgetReference _subdistrictsContainer;
		private inkCompoundWidgetReference _mappinOutlinesContainer;
		private inkCompoundWidgetReference _groupOutlinesContainer;
		private inkCompoundWidgetReference _tooltipContainer;
		private inkMargin _tooltipOffset;
		private inkMargin _tooltipDistrictOffset;
		private CEnum<gameuiEWorldMapDistrictView> _districtView;
		private CEnum<gamedataDistrict> _hoveredDistrict;
		private CEnum<gamedataDistrict> _hoveredSubDistrict;
		private CEnum<gamedataDistrict> _selectedDistrict;
		private CBool _canChangeCustomFilter;
		private CBool _isZoomToMappinEnabled;
		private inkWidgetReference _contentWidget;
		private inkWidgetReference _timeSkipBtn;
		private inkTextWidgetReference _gameTimeText;
		private inkWidgetReference _zoomContainer;
		private inkWidgetReference _zoomLevelContainer;
		private inkTextWidgetReference _zoomLevelText;
		private inkWidgetReference _filterContainer;
		private inkTextWidgetReference _filterText;
		private inkWidgetReference _fastTravelInstructions;
		private inkWidgetReference _legendWrapper;
		private inkImageWidgetReference _districtIconImage;
		private inkTextWidgetReference _districtNameText;
		private inkTextWidgetReference _subdistrictNameText;
		private inkWidgetReference _questLinkInputHint;
		private inkWidgetReference _questContainer;
		private inkTextWidgetReference _questName;
		private inkTextWidgetReference _objectiveName;
		private CFloat _rightAxisZoomThreshold;
		private CEnum<EWorldMapView> _view;
		private CEnum<gameuiEWorldMapCameraMode> _cameraMode;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CWeakHandle<WorldMapTooltipContainer> _tooltipController;
		private CWeakHandle<WorldMapLegendController> _legendController;
		private CHandle<inkGameNotificationToken> _timeSkipPopupToken;
		private CHandle<textTextParameterSet> _gameTimeTextParams;
		private CWeakHandle<gameObject> _player;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<gamemappinsMappinSystem> _mappinSystem;
		private CWeakHandle<gameIBlackboard> _mapBlackboard;
		private CHandle<UI_MapDef> _mapDefinition;
		private CWeakHandle<gameJournalQuestObjectiveBase> _trackedObjective;
		private CWeakHandle<gameJournalQuest> _trackedQuest;
		private CArray<Vector3> _mappinsPositions;
		private CFloat _lastRightAxisYAmount;
		private CBool _justOpenedQuestJournal;
		private Vector3 _initPosition;

		[Ordinal(16)] 
		[RED("settingsRecordID")] 
		public TweakDBID SettingsRecordID
		{
			get => GetProperty(ref _settingsRecordID);
			set => SetProperty(ref _settingsRecordID, value);
		}

		[Ordinal(17)] 
		[RED("selectedMappin")] 
		public CWeakHandle<gameuiBaseWorldMapMappinController> SelectedMappin
		{
			get => GetProperty(ref _selectedMappin);
			set => SetProperty(ref _selectedMappin, value);
		}

		[Ordinal(18)] 
		[RED("playerOnTop")] 
		public CBool PlayerOnTop
		{
			get => GetProperty(ref _playerOnTop);
			set => SetProperty(ref _playerOnTop, value);
		}

		[Ordinal(19)] 
		[RED("entityPreviewLibraryID")] 
		public CName EntityPreviewLibraryID
		{
			get => GetProperty(ref _entityPreviewLibraryID);
			set => SetProperty(ref _entityPreviewLibraryID, value);
		}

		[Ordinal(20)] 
		[RED("entityPreviewSpawnContainer")] 
		public inkCompoundWidgetReference EntityPreviewSpawnContainer
		{
			get => GetProperty(ref _entityPreviewSpawnContainer);
			set => SetProperty(ref _entityPreviewSpawnContainer, value);
		}

		[Ordinal(21)] 
		[RED("floorPlanSpawnContainer")] 
		public inkCompoundWidgetReference FloorPlanSpawnContainer
		{
			get => GetProperty(ref _floorPlanSpawnContainer);
			set => SetProperty(ref _floorPlanSpawnContainer, value);
		}

		[Ordinal(22)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetProperty(ref _compassWidget);
			set => SetProperty(ref _compassWidget, value);
		}

		[Ordinal(23)] 
		[RED("districtsContainer")] 
		public inkCompoundWidgetReference DistrictsContainer
		{
			get => GetProperty(ref _districtsContainer);
			set => SetProperty(ref _districtsContainer, value);
		}

		[Ordinal(24)] 
		[RED("subdistrictsContainer")] 
		public inkCompoundWidgetReference SubdistrictsContainer
		{
			get => GetProperty(ref _subdistrictsContainer);
			set => SetProperty(ref _subdistrictsContainer, value);
		}

		[Ordinal(25)] 
		[RED("mappinOutlinesContainer")] 
		public inkCompoundWidgetReference MappinOutlinesContainer
		{
			get => GetProperty(ref _mappinOutlinesContainer);
			set => SetProperty(ref _mappinOutlinesContainer, value);
		}

		[Ordinal(26)] 
		[RED("groupOutlinesContainer")] 
		public inkCompoundWidgetReference GroupOutlinesContainer
		{
			get => GetProperty(ref _groupOutlinesContainer);
			set => SetProperty(ref _groupOutlinesContainer, value);
		}

		[Ordinal(27)] 
		[RED("tooltipContainer")] 
		public inkCompoundWidgetReference TooltipContainer
		{
			get => GetProperty(ref _tooltipContainer);
			set => SetProperty(ref _tooltipContainer, value);
		}

		[Ordinal(28)] 
		[RED("tooltipOffset")] 
		public inkMargin TooltipOffset
		{
			get => GetProperty(ref _tooltipOffset);
			set => SetProperty(ref _tooltipOffset, value);
		}

		[Ordinal(29)] 
		[RED("tooltipDistrictOffset")] 
		public inkMargin TooltipDistrictOffset
		{
			get => GetProperty(ref _tooltipDistrictOffset);
			set => SetProperty(ref _tooltipDistrictOffset, value);
		}

		[Ordinal(30)] 
		[RED("districtView")] 
		public CEnum<gameuiEWorldMapDistrictView> DistrictView
		{
			get => GetProperty(ref _districtView);
			set => SetProperty(ref _districtView, value);
		}

		[Ordinal(31)] 
		[RED("hoveredDistrict")] 
		public CEnum<gamedataDistrict> HoveredDistrict
		{
			get => GetProperty(ref _hoveredDistrict);
			set => SetProperty(ref _hoveredDistrict, value);
		}

		[Ordinal(32)] 
		[RED("hoveredSubDistrict")] 
		public CEnum<gamedataDistrict> HoveredSubDistrict
		{
			get => GetProperty(ref _hoveredSubDistrict);
			set => SetProperty(ref _hoveredSubDistrict, value);
		}

		[Ordinal(33)] 
		[RED("selectedDistrict")] 
		public CEnum<gamedataDistrict> SelectedDistrict
		{
			get => GetProperty(ref _selectedDistrict);
			set => SetProperty(ref _selectedDistrict, value);
		}

		[Ordinal(34)] 
		[RED("canChangeCustomFilter")] 
		public CBool CanChangeCustomFilter
		{
			get => GetProperty(ref _canChangeCustomFilter);
			set => SetProperty(ref _canChangeCustomFilter, value);
		}

		[Ordinal(35)] 
		[RED("isZoomToMappinEnabled")] 
		public CBool IsZoomToMappinEnabled
		{
			get => GetProperty(ref _isZoomToMappinEnabled);
			set => SetProperty(ref _isZoomToMappinEnabled, value);
		}

		[Ordinal(36)] 
		[RED("contentWidget")] 
		public inkWidgetReference ContentWidget
		{
			get => GetProperty(ref _contentWidget);
			set => SetProperty(ref _contentWidget, value);
		}

		[Ordinal(37)] 
		[RED("timeSkipBtn")] 
		public inkWidgetReference TimeSkipBtn
		{
			get => GetProperty(ref _timeSkipBtn);
			set => SetProperty(ref _timeSkipBtn, value);
		}

		[Ordinal(38)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get => GetProperty(ref _gameTimeText);
			set => SetProperty(ref _gameTimeText, value);
		}

		[Ordinal(39)] 
		[RED("zoomContainer")] 
		public inkWidgetReference ZoomContainer
		{
			get => GetProperty(ref _zoomContainer);
			set => SetProperty(ref _zoomContainer, value);
		}

		[Ordinal(40)] 
		[RED("zoomLevelContainer")] 
		public inkWidgetReference ZoomLevelContainer
		{
			get => GetProperty(ref _zoomLevelContainer);
			set => SetProperty(ref _zoomLevelContainer, value);
		}

		[Ordinal(41)] 
		[RED("zoomLevelText")] 
		public inkTextWidgetReference ZoomLevelText
		{
			get => GetProperty(ref _zoomLevelText);
			set => SetProperty(ref _zoomLevelText, value);
		}

		[Ordinal(42)] 
		[RED("filterContainer")] 
		public inkWidgetReference FilterContainer
		{
			get => GetProperty(ref _filterContainer);
			set => SetProperty(ref _filterContainer, value);
		}

		[Ordinal(43)] 
		[RED("filterText")] 
		public inkTextWidgetReference FilterText
		{
			get => GetProperty(ref _filterText);
			set => SetProperty(ref _filterText, value);
		}

		[Ordinal(44)] 
		[RED("fastTravelInstructions")] 
		public inkWidgetReference FastTravelInstructions
		{
			get => GetProperty(ref _fastTravelInstructions);
			set => SetProperty(ref _fastTravelInstructions, value);
		}

		[Ordinal(45)] 
		[RED("legendWrapper")] 
		public inkWidgetReference LegendWrapper
		{
			get => GetProperty(ref _legendWrapper);
			set => SetProperty(ref _legendWrapper, value);
		}

		[Ordinal(46)] 
		[RED("districtIconImage")] 
		public inkImageWidgetReference DistrictIconImage
		{
			get => GetProperty(ref _districtIconImage);
			set => SetProperty(ref _districtIconImage, value);
		}

		[Ordinal(47)] 
		[RED("districtNameText")] 
		public inkTextWidgetReference DistrictNameText
		{
			get => GetProperty(ref _districtNameText);
			set => SetProperty(ref _districtNameText, value);
		}

		[Ordinal(48)] 
		[RED("subdistrictNameText")] 
		public inkTextWidgetReference SubdistrictNameText
		{
			get => GetProperty(ref _subdistrictNameText);
			set => SetProperty(ref _subdistrictNameText, value);
		}

		[Ordinal(49)] 
		[RED("questLinkInputHint")] 
		public inkWidgetReference QuestLinkInputHint
		{
			get => GetProperty(ref _questLinkInputHint);
			set => SetProperty(ref _questLinkInputHint, value);
		}

		[Ordinal(50)] 
		[RED("questContainer")] 
		public inkWidgetReference QuestContainer
		{
			get => GetProperty(ref _questContainer);
			set => SetProperty(ref _questContainer, value);
		}

		[Ordinal(51)] 
		[RED("questName")] 
		public inkTextWidgetReference QuestName
		{
			get => GetProperty(ref _questName);
			set => SetProperty(ref _questName, value);
		}

		[Ordinal(52)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get => GetProperty(ref _objectiveName);
			set => SetProperty(ref _objectiveName, value);
		}

		[Ordinal(53)] 
		[RED("rightAxisZoomThreshold")] 
		public CFloat RightAxisZoomThreshold
		{
			get => GetProperty(ref _rightAxisZoomThreshold);
			set => SetProperty(ref _rightAxisZoomThreshold, value);
		}

		[Ordinal(54)] 
		[RED("view")] 
		public CEnum<EWorldMapView> View
		{
			get => GetProperty(ref _view);
			set => SetProperty(ref _view, value);
		}

		[Ordinal(55)] 
		[RED("cameraMode")] 
		public CEnum<gameuiEWorldMapCameraMode> CameraMode
		{
			get => GetProperty(ref _cameraMode);
			set => SetProperty(ref _cameraMode, value);
		}

		[Ordinal(56)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(57)] 
		[RED("tooltipController")] 
		public CWeakHandle<WorldMapTooltipContainer> TooltipController
		{
			get => GetProperty(ref _tooltipController);
			set => SetProperty(ref _tooltipController, value);
		}

		[Ordinal(58)] 
		[RED("legendController")] 
		public CWeakHandle<WorldMapLegendController> LegendController
		{
			get => GetProperty(ref _legendController);
			set => SetProperty(ref _legendController, value);
		}

		[Ordinal(59)] 
		[RED("timeSkipPopupToken")] 
		public CHandle<inkGameNotificationToken> TimeSkipPopupToken
		{
			get => GetProperty(ref _timeSkipPopupToken);
			set => SetProperty(ref _timeSkipPopupToken, value);
		}

		[Ordinal(60)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get => GetProperty(ref _gameTimeTextParams);
			set => SetProperty(ref _gameTimeTextParams, value);
		}

		[Ordinal(61)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(62)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(63)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetProperty(ref _mappinSystem);
			set => SetProperty(ref _mappinSystem, value);
		}

		[Ordinal(64)] 
		[RED("mapBlackboard")] 
		public CWeakHandle<gameIBlackboard> MapBlackboard
		{
			get => GetProperty(ref _mapBlackboard);
			set => SetProperty(ref _mapBlackboard, value);
		}

		[Ordinal(65)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetProperty(ref _mapDefinition);
			set => SetProperty(ref _mapDefinition, value);
		}

		[Ordinal(66)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjectiveBase> TrackedObjective
		{
			get => GetProperty(ref _trackedObjective);
			set => SetProperty(ref _trackedObjective, value);
		}

		[Ordinal(67)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(68)] 
		[RED("mappinsPositions")] 
		public CArray<Vector3> MappinsPositions
		{
			get => GetProperty(ref _mappinsPositions);
			set => SetProperty(ref _mappinsPositions, value);
		}

		[Ordinal(69)] 
		[RED("lastRightAxisYAmount")] 
		public CFloat LastRightAxisYAmount
		{
			get => GetProperty(ref _lastRightAxisYAmount);
			set => SetProperty(ref _lastRightAxisYAmount, value);
		}

		[Ordinal(70)] 
		[RED("justOpenedQuestJournal")] 
		public CBool JustOpenedQuestJournal
		{
			get => GetProperty(ref _justOpenedQuestJournal);
			set => SetProperty(ref _justOpenedQuestJournal, value);
		}

		[Ordinal(71)] 
		[RED("initPosition")] 
		public Vector3 InitPosition
		{
			get => GetProperty(ref _initPosition);
			set => SetProperty(ref _initPosition, value);
		}
	}
}
