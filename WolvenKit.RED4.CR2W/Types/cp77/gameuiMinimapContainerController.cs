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
		private CHandle<inkWidget> _rootZoneSafety;
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
			get
			{
				if (_visionRadiusVehicle == null)
				{
					_visionRadiusVehicle = (CFloat) CR2WTypeManager.Create("Float", "visionRadiusVehicle", cr2w, this);
				}
				return _visionRadiusVehicle;
			}
			set
			{
				if (_visionRadiusVehicle == value)
				{
					return;
				}
				_visionRadiusVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("visionRadiusCombat")] 
		public CFloat VisionRadiusCombat
		{
			get
			{
				if (_visionRadiusCombat == null)
				{
					_visionRadiusCombat = (CFloat) CR2WTypeManager.Create("Float", "visionRadiusCombat", cr2w, this);
				}
				return _visionRadiusCombat;
			}
			set
			{
				if (_visionRadiusCombat == value)
				{
					return;
				}
				_visionRadiusCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("visionRadiusQuestArea")] 
		public CFloat VisionRadiusQuestArea
		{
			get
			{
				if (_visionRadiusQuestArea == null)
				{
					_visionRadiusQuestArea = (CFloat) CR2WTypeManager.Create("Float", "visionRadiusQuestArea", cr2w, this);
				}
				return _visionRadiusQuestArea;
			}
			set
			{
				if (_visionRadiusQuestArea == value)
				{
					return;
				}
				_visionRadiusQuestArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("visionRadiusSecurityArea")] 
		public CFloat VisionRadiusSecurityArea
		{
			get
			{
				if (_visionRadiusSecurityArea == null)
				{
					_visionRadiusSecurityArea = (CFloat) CR2WTypeManager.Create("Float", "visionRadiusSecurityArea", cr2w, this);
				}
				return _visionRadiusSecurityArea;
			}
			set
			{
				if (_visionRadiusSecurityArea == value)
				{
					return;
				}
				_visionRadiusSecurityArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("visionRadiusInterior")] 
		public CFloat VisionRadiusInterior
		{
			get
			{
				if (_visionRadiusInterior == null)
				{
					_visionRadiusInterior = (CFloat) CR2WTypeManager.Create("Float", "visionRadiusInterior", cr2w, this);
				}
				return _visionRadiusInterior;
			}
			set
			{
				if (_visionRadiusInterior == value)
				{
					return;
				}
				_visionRadiusInterior = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("visionRadiusExterior")] 
		public CFloat VisionRadiusExterior
		{
			get
			{
				if (_visionRadiusExterior == null)
				{
					_visionRadiusExterior = (CFloat) CR2WTypeManager.Create("Float", "visionRadiusExterior", cr2w, this);
				}
				return _visionRadiusExterior;
			}
			set
			{
				if (_visionRadiusExterior == value)
				{
					return;
				}
				_visionRadiusExterior = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("clampedMappinContainer")] 
		public inkCompoundWidgetReference ClampedMappinContainer
		{
			get
			{
				if (_clampedMappinContainer == null)
				{
					_clampedMappinContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "clampedMappinContainer", cr2w, this);
				}
				return _clampedMappinContainer;
			}
			set
			{
				if (_clampedMappinContainer == value)
				{
					return;
				}
				_clampedMappinContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("unclampedMappinContainer")] 
		public inkCompoundWidgetReference UnclampedMappinContainer
		{
			get
			{
				if (_unclampedMappinContainer == null)
				{
					_unclampedMappinContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "unclampedMappinContainer", cr2w, this);
				}
				return _unclampedMappinContainer;
			}
			set
			{
				if (_unclampedMappinContainer == value)
				{
					return;
				}
				_unclampedMappinContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("maskWidget")] 
		public inkMaskWidgetReference MaskWidget
		{
			get
			{
				if (_maskWidget == null)
				{
					_maskWidget = (inkMaskWidgetReference) CR2WTypeManager.Create("inkMaskWidgetReference", "maskWidget", cr2w, this);
				}
				return _maskWidget;
			}
			set
			{
				if (_maskWidget == value)
				{
					return;
				}
				_maskWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("playerIconWidget")] 
		public inkWidgetReference PlayerIconWidget
		{
			get
			{
				if (_playerIconWidget == null)
				{
					_playerIconWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerIconWidget", cr2w, this);
				}
				return _playerIconWidget;
			}
			set
			{
				if (_playerIconWidget == value)
				{
					return;
				}
				_playerIconWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
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

		[Ordinal(27)] 
		[RED("worldGeometryContainer")] 
		public inkCanvasWidgetReference WorldGeometryContainer
		{
			get
			{
				if (_worldGeometryContainer == null)
				{
					_worldGeometryContainer = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "worldGeometryContainer", cr2w, this);
				}
				return _worldGeometryContainer;
			}
			set
			{
				if (_worldGeometryContainer == value)
				{
					return;
				}
				_worldGeometryContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("worldGeometryCache")] 
		public inkCacheWidgetReference WorldGeometryCache
		{
			get
			{
				if (_worldGeometryCache == null)
				{
					_worldGeometryCache = (inkCacheWidgetReference) CR2WTypeManager.Create("inkCacheWidgetReference", "worldGeometryCache", cr2w, this);
				}
				return _worldGeometryCache;
			}
			set
			{
				if (_worldGeometryCache == value)
				{
					return;
				}
				_worldGeometryCache = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("geometryLibraryID")] 
		public CName GeometryLibraryID
		{
			get
			{
				if (_geometryLibraryID == null)
				{
					_geometryLibraryID = (CName) CR2WTypeManager.Create("CName", "geometryLibraryID", cr2w, this);
				}
				return _geometryLibraryID;
			}
			set
			{
				if (_geometryLibraryID == value)
				{
					return;
				}
				_geometryLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("timeDisplayWidget")] 
		public inkCompoundWidgetReference TimeDisplayWidget
		{
			get
			{
				if (_timeDisplayWidget == null)
				{
					_timeDisplayWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "timeDisplayWidget", cr2w, this);
				}
				return _timeDisplayWidget;
			}
			set
			{
				if (_timeDisplayWidget == value)
				{
					return;
				}
				_timeDisplayWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("rootZoneSafety")] 
		public CHandle<inkWidget> RootZoneSafety
		{
			get
			{
				if (_rootZoneSafety == null)
				{
					_rootZoneSafety = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "rootZoneSafety", cr2w, this);
				}
				return _rootZoneSafety;
			}
			set
			{
				if (_rootZoneSafety == value)
				{
					return;
				}
				_rootZoneSafety = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("locationTextWidget")] 
		public inkTextWidgetReference LocationTextWidget
		{
			get
			{
				if (_locationTextWidget == null)
				{
					_locationTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "locationTextWidget", cr2w, this);
				}
				return _locationTextWidget;
			}
			set
			{
				if (_locationTextWidget == value)
				{
					return;
				}
				_locationTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get
			{
				if (_fluffText1 == null)
				{
					_fluffText1 = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffText1", cr2w, this);
				}
				return _fluffText1;
			}
			set
			{
				if (_fluffText1 == value)
				{
					return;
				}
				_fluffText1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("securityAreaVignetteWidget")] 
		public inkWidgetReference SecurityAreaVignetteWidget
		{
			get
			{
				if (_securityAreaVignetteWidget == null)
				{
					_securityAreaVignetteWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "securityAreaVignetteWidget", cr2w, this);
				}
				return _securityAreaVignetteWidget;
			}
			set
			{
				if (_securityAreaVignetteWidget == value)
				{
					return;
				}
				_securityAreaVignetteWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("securityAreaText")] 
		public inkTextWidgetReference SecurityAreaText
		{
			get
			{
				if (_securityAreaText == null)
				{
					_securityAreaText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "securityAreaText", cr2w, this);
				}
				return _securityAreaText;
			}
			set
			{
				if (_securityAreaText == value)
				{
					return;
				}
				_securityAreaText = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("messageCounter")] 
		public inkWidgetReference MessageCounter
		{
			get
			{
				if (_messageCounter == null)
				{
					_messageCounter = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "messageCounter", cr2w, this);
				}
				return _messageCounter;
			}
			set
			{
				if (_messageCounter == value)
				{
					return;
				}
				_messageCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("combatModeHighlight")] 
		public inkWidgetReference CombatModeHighlight
		{
			get
			{
				if (_combatModeHighlight == null)
				{
					_combatModeHighlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "combatModeHighlight", cr2w, this);
				}
				return _combatModeHighlight;
			}
			set
			{
				if (_combatModeHighlight == value)
				{
					return;
				}
				_combatModeHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("zoneVignetteAnimProxy")] 
		public CHandle<inkanimProxy> ZoneVignetteAnimProxy
		{
			get
			{
				if (_zoneVignetteAnimProxy == null)
				{
					_zoneVignetteAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "zoneVignetteAnimProxy", cr2w, this);
				}
				return _zoneVignetteAnimProxy;
			}
			set
			{
				if (_zoneVignetteAnimProxy == value)
				{
					return;
				}
				_zoneVignetteAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("inPublicOrRestrictedZone")] 
		public CBool InPublicOrRestrictedZone
		{
			get
			{
				if (_inPublicOrRestrictedZone == null)
				{
					_inPublicOrRestrictedZone = (CBool) CR2WTypeManager.Create("Bool", "inPublicOrRestrictedZone", cr2w, this);
				}
				return _inPublicOrRestrictedZone;
			}
			set
			{
				if (_inPublicOrRestrictedZone == value)
				{
					return;
				}
				_inPublicOrRestrictedZone = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("fluffTextCount")] 
		public CInt32 FluffTextCount
		{
			get
			{
				if (_fluffTextCount == null)
				{
					_fluffTextCount = (CInt32) CR2WTypeManager.Create("Int32", "fluffTextCount", cr2w, this);
				}
				return _fluffTextCount;
			}
			set
			{
				if (_fluffTextCount == value)
				{
					return;
				}
				_fluffTextCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
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

		[Ordinal(43)] 
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

		[Ordinal(44)] 
		[RED("locationDataCallback")] 
		public CUInt32 LocationDataCallback
		{
			get
			{
				if (_locationDataCallback == null)
				{
					_locationDataCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "locationDataCallback", cr2w, this);
				}
				return _locationDataCallback;
			}
			set
			{
				if (_locationDataCallback == value)
				{
					return;
				}
				_locationDataCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("securityBlackBoardID")] 
		public CUInt32 SecurityBlackBoardID
		{
			get
			{
				if (_securityBlackBoardID == null)
				{
					_securityBlackBoardID = (CUInt32) CR2WTypeManager.Create("Uint32", "securityBlackBoardID", cr2w, this);
				}
				return _securityBlackBoardID;
			}
			set
			{
				if (_securityBlackBoardID == value)
				{
					return;
				}
				_securityBlackBoardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("combatAnimation")] 
		public CHandle<inkanimProxy> CombatAnimation
		{
			get
			{
				if (_combatAnimation == null)
				{
					_combatAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "combatAnimation", cr2w, this);
				}
				return _combatAnimation;
			}
			set
			{
				if (_combatAnimation == value)
				{
					return;
				}
				_combatAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get
			{
				if (_playerInCombat == null)
				{
					_playerInCombat = (CBool) CR2WTypeManager.Create("Bool", "playerInCombat", cr2w, this);
				}
				return _playerInCombat;
			}
			set
			{
				if (_playerInCombat == value)
				{
					return;
				}
				_playerInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("zoneNeedsUpdate")] 
		public CBool ZoneNeedsUpdate
		{
			get
			{
				if (_zoneNeedsUpdate == null)
				{
					_zoneNeedsUpdate = (CBool) CR2WTypeManager.Create("Bool", "zoneNeedsUpdate", cr2w, this);
				}
				return _zoneNeedsUpdate;
			}
			set
			{
				if (_zoneNeedsUpdate == value)
				{
					return;
				}
				_zoneNeedsUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("lastZoneType")] 
		public CEnum<ESecurityAreaType> LastZoneType
		{
			get
			{
				if (_lastZoneType == null)
				{
					_lastZoneType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "lastZoneType", cr2w, this);
				}
				return _lastZoneType;
			}
			set
			{
				if (_lastZoneType == value)
				{
					return;
				}
				_lastZoneType = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("messageCounterController")] 
		public wCHandle<inkCompoundWidget> MessageCounterController
		{
			get
			{
				if (_messageCounterController == null)
				{
					_messageCounterController = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "messageCounterController", cr2w, this);
				}
				return _messageCounterController;
			}
			set
			{
				if (_messageCounterController == value)
				{
					return;
				}
				_messageCounterController = value;
				PropertySet(this);
			}
		}

		public gameuiMinimapContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
