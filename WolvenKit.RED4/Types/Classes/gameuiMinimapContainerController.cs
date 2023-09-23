using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapContainerController : gameuiMappinsContainerController
	{
		[Ordinal(16)] 
		[RED("settings")] 
		public CHandle<gameMinimapSettings> Settings
		{
			get => GetPropertyValue<CHandle<gameMinimapSettings>>();
			set => SetPropertyValue<CHandle<gameMinimapSettings>>(value);
		}

		[Ordinal(17)] 
		[RED("clampedMappinContainer")] 
		public inkCompoundWidgetReference ClampedMappinContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("unclampedMappinContainer")] 
		public inkCompoundWidgetReference UnclampedMappinContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("maskWidget")] 
		public inkMaskWidgetReference MaskWidget
		{
			get => GetPropertyValue<inkMaskWidgetReference>();
			set => SetPropertyValue<inkMaskWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("playerIconWidget")] 
		public inkWidgetReference PlayerIconWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("worldGeometryContainer")] 
		public inkCanvasWidgetReference WorldGeometryContainer
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("worldGeometryCache")] 
		public inkCacheWidgetReference WorldGeometryCache
		{
			get => GetPropertyValue<inkCacheWidgetReference>();
			set => SetPropertyValue<inkCacheWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("geometryLibraryID")] 
		public CName GeometryLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("timeDisplayWidget")] 
		public inkCompoundWidgetReference TimeDisplayWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("rootZoneSafety")] 
		public CWeakHandle<inkWidget> RootZoneSafety
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("locationTextWidget")] 
		public inkTextWidgetReference LocationTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("securityAreaVignetteWidget")] 
		public inkWidgetReference SecurityAreaVignetteWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("securityAreaText")] 
		public inkTextWidgetReference SecurityAreaText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("combatModeHighlight")] 
		public inkWidgetReference CombatModeHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("courierTimerContainer")] 
		public inkWidgetReference CourierTimerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("courierTimerText")] 
		public inkTextWidgetReference CourierTimerText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(35)] 
		[RED("zoneVignetteAnimProxy")] 
		public CHandle<inkanimProxy> ZoneVignetteAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(36)] 
		[RED("inPublicOrRestrictedZone")] 
		public CBool InPublicOrRestrictedZone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("fluffTextCount")] 
		public CInt32 FluffTextCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(38)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(39)] 
		[RED("mapBlackboard")] 
		public CWeakHandle<gameIBlackboard> MapBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(40)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(41)] 
		[RED("locationDataCallback")] 
		public CHandle<redCallbackObject> LocationDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("countdownTimerBlackboard")] 
		public CWeakHandle<gameIBlackboard> CountdownTimerBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(43)] 
		[RED("countdownTimerDefinition")] 
		public CHandle<UI_HUDCountdownTimerDef> CountdownTimerDefinition
		{
			get => GetPropertyValue<CHandle<UI_HUDCountdownTimerDef>>();
			set => SetPropertyValue<CHandle<UI_HUDCountdownTimerDef>>(value);
		}

		[Ordinal(44)] 
		[RED("countdownTimerActiveCallback")] 
		public CHandle<redCallbackObject> CountdownTimerActiveCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("countdownTimerTimeCallback")] 
		public CHandle<redCallbackObject> CountdownTimerTimeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("securityBlackBoardID")] 
		public CHandle<redCallbackObject> SecurityBlackBoardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(48)] 
		[RED("remoteControlledVehicleCameraChangedToTPPCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleCameraChangedToTPPCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("combatAnimation")] 
		public CHandle<inkanimProxy> CombatAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(50)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("currentZoneType")] 
		public CEnum<ESecurityAreaType> CurrentZoneType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(52)] 
		[RED("messageCounterController")] 
		public CWeakHandle<inkCompoundWidget> MessageCounterController
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		public gameuiMinimapContainerController()
		{
			ClampedMappinContainer = new inkCompoundWidgetReference();
			UnclampedMappinContainer = new inkCompoundWidgetReference();
			MaskWidget = new inkMaskWidgetReference();
			PlayerIconWidget = new inkWidgetReference();
			CompassWidget = new inkWidgetReference();
			WorldGeometryContainer = new inkCanvasWidgetReference();
			WorldGeometryCache = new inkCacheWidgetReference();
			TimeDisplayWidget = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
