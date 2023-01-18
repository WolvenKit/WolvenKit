using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapContainerController : gameuiMappinsContainerController
	{
		[Ordinal(16)] 
		[RED("visionRadiusVehicle")] 
		public CFloat VisionRadiusVehicle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("visionRadiusCombat")] 
		public CFloat VisionRadiusCombat
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("visionRadiusQuestArea")] 
		public CFloat VisionRadiusQuestArea
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("visionRadiusSecurityArea")] 
		public CFloat VisionRadiusSecurityArea
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("visionRadiusInterior")] 
		public CFloat VisionRadiusInterior
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("visionRadiusExterior")] 
		public CFloat VisionRadiusExterior
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("clampedMappinContainer")] 
		public inkCompoundWidgetReference ClampedMappinContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("unclampedMappinContainer")] 
		public inkCompoundWidgetReference UnclampedMappinContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("maskWidget")] 
		public inkMaskWidgetReference MaskWidget
		{
			get => GetPropertyValue<inkMaskWidgetReference>();
			set => SetPropertyValue<inkMaskWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("playerIconWidget")] 
		public inkWidgetReference PlayerIconWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("worldGeometryContainer")] 
		public inkCanvasWidgetReference WorldGeometryContainer
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("worldGeometryCache")] 
		public inkCacheWidgetReference WorldGeometryCache
		{
			get => GetPropertyValue<inkCacheWidgetReference>();
			set => SetPropertyValue<inkCacheWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("geometryLibraryID")] 
		public CName GeometryLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("timeDisplayWidget")] 
		public inkCompoundWidgetReference TimeDisplayWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("rootZoneSafety")] 
		public CWeakHandle<inkWidget> RootZoneSafety
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(32)] 
		[RED("locationTextWidget")] 
		public inkTextWidgetReference LocationTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("securityAreaVignetteWidget")] 
		public inkWidgetReference SecurityAreaVignetteWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("securityAreaText")] 
		public inkTextWidgetReference SecurityAreaText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("combatModeHighlight")] 
		public inkWidgetReference CombatModeHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(38)] 
		[RED("zoneVignetteAnimProxy")] 
		public CHandle<inkanimProxy> ZoneVignetteAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(39)] 
		[RED("inPublicOrRestrictedZone")] 
		public CBool InPublicOrRestrictedZone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("fluffTextCount")] 
		public CInt32 FluffTextCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("mapBlackboard")] 
		public CWeakHandle<gameIBlackboard> MapBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(42)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(43)] 
		[RED("locationDataCallback")] 
		public CHandle<redCallbackObject> LocationDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("securityBlackBoardID")] 
		public CHandle<redCallbackObject> SecurityBlackBoardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("combatAnimation")] 
		public CHandle<inkanimProxy> CombatAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(46)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("zoneNeedsUpdate")] 
		public CBool ZoneNeedsUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("lastZoneType")] 
		public CEnum<ESecurityAreaType> LastZoneType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(49)] 
		[RED("messageCounterController")] 
		public CWeakHandle<inkCompoundWidget> MessageCounterController
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		public gameuiMinimapContainerController()
		{
			VisionRadiusVehicle = 125.000000F;
			VisionRadiusCombat = 40.000000F;
			VisionRadiusQuestArea = 40.000000F;
			VisionRadiusSecurityArea = 40.000000F;
			VisionRadiusInterior = 40.000000F;
			VisionRadiusExterior = 100.000000F;
			ClampedMappinContainer = new();
			UnclampedMappinContainer = new();
			MaskWidget = new();
			PlayerIconWidget = new();
			CompassWidget = new();
			WorldGeometryContainer = new();
			WorldGeometryCache = new();
			TimeDisplayWidget = new();
			LocationTextWidget = new();
			FluffText1 = new();
			SecurityAreaVignetteWidget = new();
			SecurityAreaText = new();
			CombatModeHighlight = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
