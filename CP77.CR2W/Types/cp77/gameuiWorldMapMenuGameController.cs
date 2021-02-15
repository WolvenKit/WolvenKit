using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapMenuGameController : gameuiMappinsContainerController
	{
		[Ordinal(16)] [RED("settingsRecordID")] public TweakDBID SettingsRecordID { get; set; }
		[Ordinal(17)] [RED("selectedMappin")] public wCHandle<gameuiBaseWorldMapMappinController> SelectedMappin { get; set; }
		[Ordinal(18)] [RED("playerOnTop")] public CBool PlayerOnTop { get; set; }
		[Ordinal(19)] [RED("entityPreviewLibraryID")] public CName EntityPreviewLibraryID { get; set; }
		[Ordinal(20)] [RED("entityPreviewSpawnContainer")] public inkCompoundWidgetReference EntityPreviewSpawnContainer { get; set; }
		[Ordinal(21)] [RED("floorPlanSpawnContainer")] public inkCompoundWidgetReference FloorPlanSpawnContainer { get; set; }
		[Ordinal(22)] [RED("compassWidget")] public inkWidgetReference CompassWidget { get; set; }
		[Ordinal(23)] [RED("districtsContainer")] public inkCompoundWidgetReference DistrictsContainer { get; set; }
		[Ordinal(24)] [RED("subdistrictsContainer")] public inkCompoundWidgetReference SubdistrictsContainer { get; set; }
		[Ordinal(25)] [RED("mappinOutlinesContainer")] public inkCompoundWidgetReference MappinOutlinesContainer { get; set; }
		[Ordinal(26)] [RED("groupOutlinesContainer")] public inkCompoundWidgetReference GroupOutlinesContainer { get; set; }
		[Ordinal(27)] [RED("tooltipContainer")] public inkCompoundWidgetReference TooltipContainer { get; set; }
		[Ordinal(28)] [RED("tooltipOffset")] public inkMargin TooltipOffset { get; set; }
		[Ordinal(29)] [RED("tooltipDistrictOffset")] public inkMargin TooltipDistrictOffset { get; set; }
		[Ordinal(30)] [RED("districtView")] public CEnum<gameuiEWorldMapDistrictView> DistrictView { get; set; }
		[Ordinal(31)] [RED("hoveredDistrict")] public CEnum<gamedataDistrict> HoveredDistrict { get; set; }
		[Ordinal(32)] [RED("hoveredSubDistrict")] public CEnum<gamedataDistrict> HoveredSubDistrict { get; set; }
		[Ordinal(33)] [RED("selectedDistrict")] public CEnum<gamedataDistrict> SelectedDistrict { get; set; }
		[Ordinal(34)] [RED("canChangeCustomFilter")] public CBool CanChangeCustomFilter { get; set; }
		[Ordinal(35)] [RED("isZoomToMappinEnabled")] public CBool IsZoomToMappinEnabled { get; set; }
		[Ordinal(36)] [RED("contentWidget")] public inkWidgetReference ContentWidget { get; set; }
		[Ordinal(37)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(38)] [RED("timeSkipBtn")] public inkWidgetReference TimeSkipBtn { get; set; }
		[Ordinal(39)] [RED("gameTimeText")] public inkTextWidgetReference GameTimeText { get; set; }
		[Ordinal(40)] [RED("zoomContainer")] public inkWidgetReference ZoomContainer { get; set; }
		[Ordinal(41)] [RED("zoomLevelContainer")] public inkWidgetReference ZoomLevelContainer { get; set; }
		[Ordinal(42)] [RED("zoomLevelText")] public inkTextWidgetReference ZoomLevelText { get; set; }
		[Ordinal(43)] [RED("filterContainer")] public inkWidgetReference FilterContainer { get; set; }
		[Ordinal(44)] [RED("filterText")] public inkTextWidgetReference FilterText { get; set; }
		[Ordinal(45)] [RED("fastTravelInstructions")] public inkWidgetReference FastTravelInstructions { get; set; }
		[Ordinal(46)] [RED("legendWrapper")] public inkWidgetReference LegendWrapper { get; set; }
		[Ordinal(47)] [RED("districtIconImage")] public inkImageWidgetReference DistrictIconImage { get; set; }
		[Ordinal(48)] [RED("districtNameText")] public inkTextWidgetReference DistrictNameText { get; set; }
		[Ordinal(49)] [RED("subdistrictNameText")] public inkTextWidgetReference SubdistrictNameText { get; set; }
		[Ordinal(50)] [RED("questLinkInputHint")] public inkWidgetReference QuestLinkInputHint { get; set; }
		[Ordinal(51)] [RED("questContainer")] public inkWidgetReference QuestContainer { get; set; }
		[Ordinal(52)] [RED("questName")] public inkTextWidgetReference QuestName { get; set; }
		[Ordinal(53)] [RED("objectiveName")] public inkTextWidgetReference ObjectiveName { get; set; }
		[Ordinal(54)] [RED("rightAxisZoomThreshold")] public CFloat RightAxisZoomThreshold { get; set; }
		[Ordinal(55)] [RED("view")] public CEnum<EWorldMapView> View { get; set; }
		[Ordinal(56)] [RED("cameraMode")] public CEnum<gameuiEWorldMapCameraMode> CameraMode { get; set; }
		[Ordinal(57)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(58)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(59)] [RED("tooltipController")] public wCHandle<WorldMapTooltipContainer> TooltipController { get; set; }
		[Ordinal(60)] [RED("legendController")] public wCHandle<WorldMapLegendController> LegendController { get; set; }
		[Ordinal(61)] [RED("timeSkipPopupToken")] public CHandle<inkGameNotificationToken> TimeSkipPopupToken { get; set; }
		[Ordinal(62)] [RED("gameTimeTextParams")] public CHandle<textTextParameterSet> GameTimeTextParams { get; set; }
		[Ordinal(63)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(64)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(65)] [RED("mappinSystem")] public wCHandle<gamemappinsMappinSystem> MappinSystem { get; set; }
		[Ordinal(66)] [RED("mapBlackboard")] public CHandle<gameIBlackboard> MapBlackboard { get; set; }
		[Ordinal(67)] [RED("mapDefinition")] public CHandle<UI_MapDef> MapDefinition { get; set; }
		[Ordinal(68)] [RED("trackedObjective")] public wCHandle<gameJournalQuestObjectiveBase> TrackedObjective { get; set; }
		[Ordinal(69)] [RED("trackedQuest")] public wCHandle<gameJournalQuest> TrackedQuest { get; set; }
		[Ordinal(70)] [RED("mappinsPositions")] public CArray<Vector3> MappinsPositions { get; set; }
		[Ordinal(71)] [RED("lastRightAxisYAmount")] public CFloat LastRightAxisYAmount { get; set; }
		[Ordinal(72)] [RED("justOpenedQuestJournal")] public CBool JustOpenedQuestJournal { get; set; }
		[Ordinal(73)] [RED("initPosition")] public Vector3 InitPosition { get; set; }

		public gameuiWorldMapMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
