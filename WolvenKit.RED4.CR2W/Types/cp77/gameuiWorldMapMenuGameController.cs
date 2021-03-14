using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapMenuGameController : gameuiMappinsContainerController
	{
		private TweakDBID _settingsRecordID;
		private wCHandle<gameuiBaseWorldMapMappinController> _selectedMappin;
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
		private inkWidgetReference _buttonHintsManagerRef;
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
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<WorldMapTooltipContainer> _tooltipController;
		private wCHandle<WorldMapLegendController> _legendController;
		private CHandle<inkGameNotificationToken> _timeSkipPopupToken;
		private CHandle<textTextParameterSet> _gameTimeTextParams;
		private wCHandle<gameObject> _player;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;
		private CHandle<gameIBlackboard> _mapBlackboard;
		private CHandle<UI_MapDef> _mapDefinition;
		private wCHandle<gameJournalQuestObjectiveBase> _trackedObjective;
		private wCHandle<gameJournalQuest> _trackedQuest;
		private CArray<Vector3> _mappinsPositions;
		private CFloat _lastRightAxisYAmount;
		private CBool _justOpenedQuestJournal;
		private Vector3 _initPosition;

		[Ordinal(16)] 
		[RED("settingsRecordID")] 
		public TweakDBID SettingsRecordID
		{
			get
			{
				if (_settingsRecordID == null)
				{
					_settingsRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "settingsRecordID", cr2w, this);
				}
				return _settingsRecordID;
			}
			set
			{
				if (_settingsRecordID == value)
				{
					return;
				}
				_settingsRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("selectedMappin")] 
		public wCHandle<gameuiBaseWorldMapMappinController> SelectedMappin
		{
			get
			{
				if (_selectedMappin == null)
				{
					_selectedMappin = (wCHandle<gameuiBaseWorldMapMappinController>) CR2WTypeManager.Create("whandle:gameuiBaseWorldMapMappinController", "selectedMappin", cr2w, this);
				}
				return _selectedMappin;
			}
			set
			{
				if (_selectedMappin == value)
				{
					return;
				}
				_selectedMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("playerOnTop")] 
		public CBool PlayerOnTop
		{
			get
			{
				if (_playerOnTop == null)
				{
					_playerOnTop = (CBool) CR2WTypeManager.Create("Bool", "playerOnTop", cr2w, this);
				}
				return _playerOnTop;
			}
			set
			{
				if (_playerOnTop == value)
				{
					return;
				}
				_playerOnTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("entityPreviewLibraryID")] 
		public CName EntityPreviewLibraryID
		{
			get
			{
				if (_entityPreviewLibraryID == null)
				{
					_entityPreviewLibraryID = (CName) CR2WTypeManager.Create("CName", "entityPreviewLibraryID", cr2w, this);
				}
				return _entityPreviewLibraryID;
			}
			set
			{
				if (_entityPreviewLibraryID == value)
				{
					return;
				}
				_entityPreviewLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("entityPreviewSpawnContainer")] 
		public inkCompoundWidgetReference EntityPreviewSpawnContainer
		{
			get
			{
				if (_entityPreviewSpawnContainer == null)
				{
					_entityPreviewSpawnContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "entityPreviewSpawnContainer", cr2w, this);
				}
				return _entityPreviewSpawnContainer;
			}
			set
			{
				if (_entityPreviewSpawnContainer == value)
				{
					return;
				}
				_entityPreviewSpawnContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("floorPlanSpawnContainer")] 
		public inkCompoundWidgetReference FloorPlanSpawnContainer
		{
			get
			{
				if (_floorPlanSpawnContainer == null)
				{
					_floorPlanSpawnContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "floorPlanSpawnContainer", cr2w, this);
				}
				return _floorPlanSpawnContainer;
			}
			set
			{
				if (_floorPlanSpawnContainer == value)
				{
					return;
				}
				_floorPlanSpawnContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get
			{
				if (_compassWidget == null)
				{
					_compassWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "compassWidget", cr2w, this);
				}
				return _compassWidget;
			}
			set
			{
				if (_compassWidget == value)
				{
					return;
				}
				_compassWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("districtsContainer")] 
		public inkCompoundWidgetReference DistrictsContainer
		{
			get
			{
				if (_districtsContainer == null)
				{
					_districtsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "districtsContainer", cr2w, this);
				}
				return _districtsContainer;
			}
			set
			{
				if (_districtsContainer == value)
				{
					return;
				}
				_districtsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("subdistrictsContainer")] 
		public inkCompoundWidgetReference SubdistrictsContainer
		{
			get
			{
				if (_subdistrictsContainer == null)
				{
					_subdistrictsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "subdistrictsContainer", cr2w, this);
				}
				return _subdistrictsContainer;
			}
			set
			{
				if (_subdistrictsContainer == value)
				{
					return;
				}
				_subdistrictsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("mappinOutlinesContainer")] 
		public inkCompoundWidgetReference MappinOutlinesContainer
		{
			get
			{
				if (_mappinOutlinesContainer == null)
				{
					_mappinOutlinesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "mappinOutlinesContainer", cr2w, this);
				}
				return _mappinOutlinesContainer;
			}
			set
			{
				if (_mappinOutlinesContainer == value)
				{
					return;
				}
				_mappinOutlinesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("groupOutlinesContainer")] 
		public inkCompoundWidgetReference GroupOutlinesContainer
		{
			get
			{
				if (_groupOutlinesContainer == null)
				{
					_groupOutlinesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "groupOutlinesContainer", cr2w, this);
				}
				return _groupOutlinesContainer;
			}
			set
			{
				if (_groupOutlinesContainer == value)
				{
					return;
				}
				_groupOutlinesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("tooltipContainer")] 
		public inkCompoundWidgetReference TooltipContainer
		{
			get
			{
				if (_tooltipContainer == null)
				{
					_tooltipContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "tooltipContainer", cr2w, this);
				}
				return _tooltipContainer;
			}
			set
			{
				if (_tooltipContainer == value)
				{
					return;
				}
				_tooltipContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("tooltipOffset")] 
		public inkMargin TooltipOffset
		{
			get
			{
				if (_tooltipOffset == null)
				{
					_tooltipOffset = (inkMargin) CR2WTypeManager.Create("inkMargin", "tooltipOffset", cr2w, this);
				}
				return _tooltipOffset;
			}
			set
			{
				if (_tooltipOffset == value)
				{
					return;
				}
				_tooltipOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("tooltipDistrictOffset")] 
		public inkMargin TooltipDistrictOffset
		{
			get
			{
				if (_tooltipDistrictOffset == null)
				{
					_tooltipDistrictOffset = (inkMargin) CR2WTypeManager.Create("inkMargin", "tooltipDistrictOffset", cr2w, this);
				}
				return _tooltipDistrictOffset;
			}
			set
			{
				if (_tooltipDistrictOffset == value)
				{
					return;
				}
				_tooltipDistrictOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("districtView")] 
		public CEnum<gameuiEWorldMapDistrictView> DistrictView
		{
			get
			{
				if (_districtView == null)
				{
					_districtView = (CEnum<gameuiEWorldMapDistrictView>) CR2WTypeManager.Create("gameuiEWorldMapDistrictView", "districtView", cr2w, this);
				}
				return _districtView;
			}
			set
			{
				if (_districtView == value)
				{
					return;
				}
				_districtView = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("hoveredDistrict")] 
		public CEnum<gamedataDistrict> HoveredDistrict
		{
			get
			{
				if (_hoveredDistrict == null)
				{
					_hoveredDistrict = (CEnum<gamedataDistrict>) CR2WTypeManager.Create("gamedataDistrict", "hoveredDistrict", cr2w, this);
				}
				return _hoveredDistrict;
			}
			set
			{
				if (_hoveredDistrict == value)
				{
					return;
				}
				_hoveredDistrict = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("hoveredSubDistrict")] 
		public CEnum<gamedataDistrict> HoveredSubDistrict
		{
			get
			{
				if (_hoveredSubDistrict == null)
				{
					_hoveredSubDistrict = (CEnum<gamedataDistrict>) CR2WTypeManager.Create("gamedataDistrict", "hoveredSubDistrict", cr2w, this);
				}
				return _hoveredSubDistrict;
			}
			set
			{
				if (_hoveredSubDistrict == value)
				{
					return;
				}
				_hoveredSubDistrict = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("selectedDistrict")] 
		public CEnum<gamedataDistrict> SelectedDistrict
		{
			get
			{
				if (_selectedDistrict == null)
				{
					_selectedDistrict = (CEnum<gamedataDistrict>) CR2WTypeManager.Create("gamedataDistrict", "selectedDistrict", cr2w, this);
				}
				return _selectedDistrict;
			}
			set
			{
				if (_selectedDistrict == value)
				{
					return;
				}
				_selectedDistrict = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("canChangeCustomFilter")] 
		public CBool CanChangeCustomFilter
		{
			get
			{
				if (_canChangeCustomFilter == null)
				{
					_canChangeCustomFilter = (CBool) CR2WTypeManager.Create("Bool", "canChangeCustomFilter", cr2w, this);
				}
				return _canChangeCustomFilter;
			}
			set
			{
				if (_canChangeCustomFilter == value)
				{
					return;
				}
				_canChangeCustomFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("isZoomToMappinEnabled")] 
		public CBool IsZoomToMappinEnabled
		{
			get
			{
				if (_isZoomToMappinEnabled == null)
				{
					_isZoomToMappinEnabled = (CBool) CR2WTypeManager.Create("Bool", "isZoomToMappinEnabled", cr2w, this);
				}
				return _isZoomToMappinEnabled;
			}
			set
			{
				if (_isZoomToMappinEnabled == value)
				{
					return;
				}
				_isZoomToMappinEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("contentWidget")] 
		public inkWidgetReference ContentWidget
		{
			get
			{
				if (_contentWidget == null)
				{
					_contentWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contentWidget", cr2w, this);
				}
				return _contentWidget;
			}
			set
			{
				if (_contentWidget == value)
				{
					return;
				}
				_contentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("timeSkipBtn")] 
		public inkWidgetReference TimeSkipBtn
		{
			get
			{
				if (_timeSkipBtn == null)
				{
					_timeSkipBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "timeSkipBtn", cr2w, this);
				}
				return _timeSkipBtn;
			}
			set
			{
				if (_timeSkipBtn == value)
				{
					return;
				}
				_timeSkipBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get
			{
				if (_gameTimeText == null)
				{
					_gameTimeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "gameTimeText", cr2w, this);
				}
				return _gameTimeText;
			}
			set
			{
				if (_gameTimeText == value)
				{
					return;
				}
				_gameTimeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("zoomContainer")] 
		public inkWidgetReference ZoomContainer
		{
			get
			{
				if (_zoomContainer == null)
				{
					_zoomContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "zoomContainer", cr2w, this);
				}
				return _zoomContainer;
			}
			set
			{
				if (_zoomContainer == value)
				{
					return;
				}
				_zoomContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("zoomLevelContainer")] 
		public inkWidgetReference ZoomLevelContainer
		{
			get
			{
				if (_zoomLevelContainer == null)
				{
					_zoomLevelContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "zoomLevelContainer", cr2w, this);
				}
				return _zoomLevelContainer;
			}
			set
			{
				if (_zoomLevelContainer == value)
				{
					return;
				}
				_zoomLevelContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("zoomLevelText")] 
		public inkTextWidgetReference ZoomLevelText
		{
			get
			{
				if (_zoomLevelText == null)
				{
					_zoomLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "zoomLevelText", cr2w, this);
				}
				return _zoomLevelText;
			}
			set
			{
				if (_zoomLevelText == value)
				{
					return;
				}
				_zoomLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("filterContainer")] 
		public inkWidgetReference FilterContainer
		{
			get
			{
				if (_filterContainer == null)
				{
					_filterContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "filterContainer", cr2w, this);
				}
				return _filterContainer;
			}
			set
			{
				if (_filterContainer == value)
				{
					return;
				}
				_filterContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("filterText")] 
		public inkTextWidgetReference FilterText
		{
			get
			{
				if (_filterText == null)
				{
					_filterText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "filterText", cr2w, this);
				}
				return _filterText;
			}
			set
			{
				if (_filterText == value)
				{
					return;
				}
				_filterText = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("fastTravelInstructions")] 
		public inkWidgetReference FastTravelInstructions
		{
			get
			{
				if (_fastTravelInstructions == null)
				{
					_fastTravelInstructions = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fastTravelInstructions", cr2w, this);
				}
				return _fastTravelInstructions;
			}
			set
			{
				if (_fastTravelInstructions == value)
				{
					return;
				}
				_fastTravelInstructions = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("legendWrapper")] 
		public inkWidgetReference LegendWrapper
		{
			get
			{
				if (_legendWrapper == null)
				{
					_legendWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "legendWrapper", cr2w, this);
				}
				return _legendWrapper;
			}
			set
			{
				if (_legendWrapper == value)
				{
					return;
				}
				_legendWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("districtIconImage")] 
		public inkImageWidgetReference DistrictIconImage
		{
			get
			{
				if (_districtIconImage == null)
				{
					_districtIconImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "districtIconImage", cr2w, this);
				}
				return _districtIconImage;
			}
			set
			{
				if (_districtIconImage == value)
				{
					return;
				}
				_districtIconImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("districtNameText")] 
		public inkTextWidgetReference DistrictNameText
		{
			get
			{
				if (_districtNameText == null)
				{
					_districtNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "districtNameText", cr2w, this);
				}
				return _districtNameText;
			}
			set
			{
				if (_districtNameText == value)
				{
					return;
				}
				_districtNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("subdistrictNameText")] 
		public inkTextWidgetReference SubdistrictNameText
		{
			get
			{
				if (_subdistrictNameText == null)
				{
					_subdistrictNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "subdistrictNameText", cr2w, this);
				}
				return _subdistrictNameText;
			}
			set
			{
				if (_subdistrictNameText == value)
				{
					return;
				}
				_subdistrictNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("questLinkInputHint")] 
		public inkWidgetReference QuestLinkInputHint
		{
			get
			{
				if (_questLinkInputHint == null)
				{
					_questLinkInputHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "questLinkInputHint", cr2w, this);
				}
				return _questLinkInputHint;
			}
			set
			{
				if (_questLinkInputHint == value)
				{
					return;
				}
				_questLinkInputHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("questContainer")] 
		public inkWidgetReference QuestContainer
		{
			get
			{
				if (_questContainer == null)
				{
					_questContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "questContainer", cr2w, this);
				}
				return _questContainer;
			}
			set
			{
				if (_questContainer == value)
				{
					return;
				}
				_questContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("questName")] 
		public inkTextWidgetReference QuestName
		{
			get
			{
				if (_questName == null)
				{
					_questName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "questName", cr2w, this);
				}
				return _questName;
			}
			set
			{
				if (_questName == value)
				{
					return;
				}
				_questName = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get
			{
				if (_objectiveName == null)
				{
					_objectiveName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "objectiveName", cr2w, this);
				}
				return _objectiveName;
			}
			set
			{
				if (_objectiveName == value)
				{
					return;
				}
				_objectiveName = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("rightAxisZoomThreshold")] 
		public CFloat RightAxisZoomThreshold
		{
			get
			{
				if (_rightAxisZoomThreshold == null)
				{
					_rightAxisZoomThreshold = (CFloat) CR2WTypeManager.Create("Float", "rightAxisZoomThreshold", cr2w, this);
				}
				return _rightAxisZoomThreshold;
			}
			set
			{
				if (_rightAxisZoomThreshold == value)
				{
					return;
				}
				_rightAxisZoomThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("view")] 
		public CEnum<EWorldMapView> View
		{
			get
			{
				if (_view == null)
				{
					_view = (CEnum<EWorldMapView>) CR2WTypeManager.Create("EWorldMapView", "view", cr2w, this);
				}
				return _view;
			}
			set
			{
				if (_view == value)
				{
					return;
				}
				_view = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("cameraMode")] 
		public CEnum<gameuiEWorldMapCameraMode> CameraMode
		{
			get
			{
				if (_cameraMode == null)
				{
					_cameraMode = (CEnum<gameuiEWorldMapCameraMode>) CR2WTypeManager.Create("gameuiEWorldMapCameraMode", "cameraMode", cr2w, this);
				}
				return _cameraMode;
			}
			set
			{
				if (_cameraMode == value)
				{
					return;
				}
				_cameraMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("tooltipController")] 
		public wCHandle<WorldMapTooltipContainer> TooltipController
		{
			get
			{
				if (_tooltipController == null)
				{
					_tooltipController = (wCHandle<WorldMapTooltipContainer>) CR2WTypeManager.Create("whandle:WorldMapTooltipContainer", "tooltipController", cr2w, this);
				}
				return _tooltipController;
			}
			set
			{
				if (_tooltipController == value)
				{
					return;
				}
				_tooltipController = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("legendController")] 
		public wCHandle<WorldMapLegendController> LegendController
		{
			get
			{
				if (_legendController == null)
				{
					_legendController = (wCHandle<WorldMapLegendController>) CR2WTypeManager.Create("whandle:WorldMapLegendController", "legendController", cr2w, this);
				}
				return _legendController;
			}
			set
			{
				if (_legendController == value)
				{
					return;
				}
				_legendController = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("timeSkipPopupToken")] 
		public CHandle<inkGameNotificationToken> TimeSkipPopupToken
		{
			get
			{
				if (_timeSkipPopupToken == null)
				{
					_timeSkipPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "timeSkipPopupToken", cr2w, this);
				}
				return _timeSkipPopupToken;
			}
			set
			{
				if (_timeSkipPopupToken == value)
				{
					return;
				}
				_timeSkipPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get
			{
				if (_gameTimeTextParams == null)
				{
					_gameTimeTextParams = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "gameTimeTextParams", cr2w, this);
				}
				return _gameTimeTextParams;
			}
			set
			{
				if (_gameTimeTextParams == value)
				{
					return;
				}
				_gameTimeTextParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
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

		[Ordinal(65)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get
			{
				if (_mappinSystem == null)
				{
					_mappinSystem = (wCHandle<gamemappinsMappinSystem>) CR2WTypeManager.Create("whandle:gamemappinsMappinSystem", "mappinSystem", cr2w, this);
				}
				return _mappinSystem;
			}
			set
			{
				if (_mappinSystem == value)
				{
					return;
				}
				_mappinSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("mapBlackboard")] 
		public CHandle<gameIBlackboard> MapBlackboard
		{
			get
			{
				if (_mapBlackboard == null)
				{
					_mapBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "mapBlackboard", cr2w, this);
				}
				return _mapBlackboard;
			}
			set
			{
				if (_mapBlackboard == value)
				{
					return;
				}
				_mapBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get
			{
				if (_mapDefinition == null)
				{
					_mapDefinition = (CHandle<UI_MapDef>) CR2WTypeManager.Create("handle:UI_MapDef", "mapDefinition", cr2w, this);
				}
				return _mapDefinition;
			}
			set
			{
				if (_mapDefinition == value)
				{
					return;
				}
				_mapDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("trackedObjective")] 
		public wCHandle<gameJournalQuestObjectiveBase> TrackedObjective
		{
			get
			{
				if (_trackedObjective == null)
				{
					_trackedObjective = (wCHandle<gameJournalQuestObjectiveBase>) CR2WTypeManager.Create("whandle:gameJournalQuestObjectiveBase", "trackedObjective", cr2w, this);
				}
				return _trackedObjective;
			}
			set
			{
				if (_trackedObjective == value)
				{
					return;
				}
				_trackedObjective = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "trackedQuest", cr2w, this);
				}
				return _trackedQuest;
			}
			set
			{
				if (_trackedQuest == value)
				{
					return;
				}
				_trackedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("mappinsPositions")] 
		public CArray<Vector3> MappinsPositions
		{
			get
			{
				if (_mappinsPositions == null)
				{
					_mappinsPositions = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "mappinsPositions", cr2w, this);
				}
				return _mappinsPositions;
			}
			set
			{
				if (_mappinsPositions == value)
				{
					return;
				}
				_mappinsPositions = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("lastRightAxisYAmount")] 
		public CFloat LastRightAxisYAmount
		{
			get
			{
				if (_lastRightAxisYAmount == null)
				{
					_lastRightAxisYAmount = (CFloat) CR2WTypeManager.Create("Float", "lastRightAxisYAmount", cr2w, this);
				}
				return _lastRightAxisYAmount;
			}
			set
			{
				if (_lastRightAxisYAmount == value)
				{
					return;
				}
				_lastRightAxisYAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("justOpenedQuestJournal")] 
		public CBool JustOpenedQuestJournal
		{
			get
			{
				if (_justOpenedQuestJournal == null)
				{
					_justOpenedQuestJournal = (CBool) CR2WTypeManager.Create("Bool", "justOpenedQuestJournal", cr2w, this);
				}
				return _justOpenedQuestJournal;
			}
			set
			{
				if (_justOpenedQuestJournal == value)
				{
					return;
				}
				_justOpenedQuestJournal = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("initPosition")] 
		public Vector3 InitPosition
		{
			get
			{
				if (_initPosition == null)
				{
					_initPosition = (Vector3) CR2WTypeManager.Create("Vector3", "initPosition", cr2w, this);
				}
				return _initPosition;
			}
			set
			{
				if (_initPosition == value)
				{
					return;
				}
				_initPosition = value;
				PropertySet(this);
			}
		}

		public gameuiWorldMapMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
