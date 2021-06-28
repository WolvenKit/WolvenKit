using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapContainerController : gameuiMappinsContainerController
	{
		private CFloat _visionRadiusVehicle;
		private CFloat _visionRadiusCombat;
		private CFloat _visionRadiusQuestArea;
		private CFloat _visionRadiusSecurityArea;
		private CFloat _visionRadiusInterior;
		private CFloat _visionRadiusExterior;
		private inkCompoundWidgetReference _clampedMappinContainer;
		private inkCompoundWidgetReference _unclampedMappinContainer;
		private inkMaskWidgetReference _maskWidget;
		private inkWidgetReference _playerIconWidget;
		private inkWidgetReference _compassWidget;
		private inkCanvasWidgetReference _worldGeometryContainer;
		private inkCacheWidgetReference _worldGeometryCache;
		private CName _geometryLibraryID;
		private inkCompoundWidgetReference _timeDisplayWidget;
		private wCHandle<inkWidget> _rootZoneSafety;
		private inkTextWidgetReference _locationTextWidget;
		private inkTextWidgetReference _fluffText1;
		private inkWidgetReference _securityAreaVignetteWidget;
		private inkTextWidgetReference _securityAreaText;
		private inkWidgetReference _messageCounter;
		private inkWidgetReference _combatModeHighlight;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkanimProxy> _zoneVignetteAnimProxy;
		private CBool _inPublicOrRestrictedZone;
		private CInt32 _fluffTextCount;
		private CHandle<gameIBlackboard> _mapBlackboard;
		private CHandle<UI_MapDef> _mapDefinition;
		private CUInt32 _locationDataCallback;
		private CUInt32 _securityBlackBoardID;
		private CHandle<inkanimProxy> _combatAnimation;
		private CBool _playerInCombat;
		private CBool _zoneNeedsUpdate;
		private CEnum<ESecurityAreaType> _lastZoneType;
		private wCHandle<inkCompoundWidget> _messageCounterController;

		[Ordinal(16)] 
		[RED("visionRadiusVehicle")] 
		public CFloat VisionRadiusVehicle
		{
			get => GetProperty(ref _visionRadiusVehicle);
			set => SetProperty(ref _visionRadiusVehicle, value);
		}

		[Ordinal(17)] 
		[RED("visionRadiusCombat")] 
		public CFloat VisionRadiusCombat
		{
			get => GetProperty(ref _visionRadiusCombat);
			set => SetProperty(ref _visionRadiusCombat, value);
		}

		[Ordinal(18)] 
		[RED("visionRadiusQuestArea")] 
		public CFloat VisionRadiusQuestArea
		{
			get => GetProperty(ref _visionRadiusQuestArea);
			set => SetProperty(ref _visionRadiusQuestArea, value);
		}

		[Ordinal(19)] 
		[RED("visionRadiusSecurityArea")] 
		public CFloat VisionRadiusSecurityArea
		{
			get => GetProperty(ref _visionRadiusSecurityArea);
			set => SetProperty(ref _visionRadiusSecurityArea, value);
		}

		[Ordinal(20)] 
		[RED("visionRadiusInterior")] 
		public CFloat VisionRadiusInterior
		{
			get => GetProperty(ref _visionRadiusInterior);
			set => SetProperty(ref _visionRadiusInterior, value);
		}

		[Ordinal(21)] 
		[RED("visionRadiusExterior")] 
		public CFloat VisionRadiusExterior
		{
			get => GetProperty(ref _visionRadiusExterior);
			set => SetProperty(ref _visionRadiusExterior, value);
		}

		[Ordinal(22)] 
		[RED("clampedMappinContainer")] 
		public inkCompoundWidgetReference ClampedMappinContainer
		{
			get => GetProperty(ref _clampedMappinContainer);
			set => SetProperty(ref _clampedMappinContainer, value);
		}

		[Ordinal(23)] 
		[RED("unclampedMappinContainer")] 
		public inkCompoundWidgetReference UnclampedMappinContainer
		{
			get => GetProperty(ref _unclampedMappinContainer);
			set => SetProperty(ref _unclampedMappinContainer, value);
		}

		[Ordinal(24)] 
		[RED("maskWidget")] 
		public inkMaskWidgetReference MaskWidget
		{
			get => GetProperty(ref _maskWidget);
			set => SetProperty(ref _maskWidget, value);
		}

		[Ordinal(25)] 
		[RED("playerIconWidget")] 
		public inkWidgetReference PlayerIconWidget
		{
			get => GetProperty(ref _playerIconWidget);
			set => SetProperty(ref _playerIconWidget, value);
		}

		[Ordinal(26)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetProperty(ref _compassWidget);
			set => SetProperty(ref _compassWidget, value);
		}

		[Ordinal(27)] 
		[RED("worldGeometryContainer")] 
		public inkCanvasWidgetReference WorldGeometryContainer
		{
			get => GetProperty(ref _worldGeometryContainer);
			set => SetProperty(ref _worldGeometryContainer, value);
		}

		[Ordinal(28)] 
		[RED("worldGeometryCache")] 
		public inkCacheWidgetReference WorldGeometryCache
		{
			get => GetProperty(ref _worldGeometryCache);
			set => SetProperty(ref _worldGeometryCache, value);
		}

		[Ordinal(29)] 
		[RED("geometryLibraryID")] 
		public CName GeometryLibraryID
		{
			get => GetProperty(ref _geometryLibraryID);
			set => SetProperty(ref _geometryLibraryID, value);
		}

		[Ordinal(30)] 
		[RED("timeDisplayWidget")] 
		public inkCompoundWidgetReference TimeDisplayWidget
		{
			get => GetProperty(ref _timeDisplayWidget);
			set => SetProperty(ref _timeDisplayWidget, value);
		}

		[Ordinal(31)] 
		[RED("rootZoneSafety")] 
		public wCHandle<inkWidget> RootZoneSafety
		{
			get => GetProperty(ref _rootZoneSafety);
			set => SetProperty(ref _rootZoneSafety, value);
		}

		[Ordinal(32)] 
		[RED("locationTextWidget")] 
		public inkTextWidgetReference LocationTextWidget
		{
			get => GetProperty(ref _locationTextWidget);
			set => SetProperty(ref _locationTextWidget, value);
		}

		[Ordinal(33)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get => GetProperty(ref _fluffText1);
			set => SetProperty(ref _fluffText1, value);
		}

		[Ordinal(34)] 
		[RED("securityAreaVignetteWidget")] 
		public inkWidgetReference SecurityAreaVignetteWidget
		{
			get => GetProperty(ref _securityAreaVignetteWidget);
			set => SetProperty(ref _securityAreaVignetteWidget, value);
		}

		[Ordinal(35)] 
		[RED("securityAreaText")] 
		public inkTextWidgetReference SecurityAreaText
		{
			get => GetProperty(ref _securityAreaText);
			set => SetProperty(ref _securityAreaText, value);
		}

		[Ordinal(36)] 
		[RED("messageCounter")] 
		public inkWidgetReference MessageCounter
		{
			get => GetProperty(ref _messageCounter);
			set => SetProperty(ref _messageCounter, value);
		}

		[Ordinal(37)] 
		[RED("combatModeHighlight")] 
		public inkWidgetReference CombatModeHighlight
		{
			get => GetProperty(ref _combatModeHighlight);
			set => SetProperty(ref _combatModeHighlight, value);
		}

		[Ordinal(38)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(39)] 
		[RED("zoneVignetteAnimProxy")] 
		public CHandle<inkanimProxy> ZoneVignetteAnimProxy
		{
			get => GetProperty(ref _zoneVignetteAnimProxy);
			set => SetProperty(ref _zoneVignetteAnimProxy, value);
		}

		[Ordinal(40)] 
		[RED("inPublicOrRestrictedZone")] 
		public CBool InPublicOrRestrictedZone
		{
			get => GetProperty(ref _inPublicOrRestrictedZone);
			set => SetProperty(ref _inPublicOrRestrictedZone, value);
		}

		[Ordinal(41)] 
		[RED("fluffTextCount")] 
		public CInt32 FluffTextCount
		{
			get => GetProperty(ref _fluffTextCount);
			set => SetProperty(ref _fluffTextCount, value);
		}

		[Ordinal(42)] 
		[RED("mapBlackboard")] 
		public CHandle<gameIBlackboard> MapBlackboard
		{
			get => GetProperty(ref _mapBlackboard);
			set => SetProperty(ref _mapBlackboard, value);
		}

		[Ordinal(43)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetProperty(ref _mapDefinition);
			set => SetProperty(ref _mapDefinition, value);
		}

		[Ordinal(44)] 
		[RED("locationDataCallback")] 
		public CUInt32 LocationDataCallback
		{
			get => GetProperty(ref _locationDataCallback);
			set => SetProperty(ref _locationDataCallback, value);
		}

		[Ordinal(45)] 
		[RED("securityBlackBoardID")] 
		public CUInt32 SecurityBlackBoardID
		{
			get => GetProperty(ref _securityBlackBoardID);
			set => SetProperty(ref _securityBlackBoardID, value);
		}

		[Ordinal(46)] 
		[RED("combatAnimation")] 
		public CHandle<inkanimProxy> CombatAnimation
		{
			get => GetProperty(ref _combatAnimation);
			set => SetProperty(ref _combatAnimation, value);
		}

		[Ordinal(47)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetProperty(ref _playerInCombat);
			set => SetProperty(ref _playerInCombat, value);
		}

		[Ordinal(48)] 
		[RED("zoneNeedsUpdate")] 
		public CBool ZoneNeedsUpdate
		{
			get => GetProperty(ref _zoneNeedsUpdate);
			set => SetProperty(ref _zoneNeedsUpdate, value);
		}

		[Ordinal(49)] 
		[RED("lastZoneType")] 
		public CEnum<ESecurityAreaType> LastZoneType
		{
			get => GetProperty(ref _lastZoneType);
			set => SetProperty(ref _lastZoneType, value);
		}

		[Ordinal(50)] 
		[RED("messageCounterController")] 
		public wCHandle<inkCompoundWidget> MessageCounterController
		{
			get => GetProperty(ref _messageCounterController);
			set => SetProperty(ref _messageCounterController, value);
		}

		public gameuiMinimapContainerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
