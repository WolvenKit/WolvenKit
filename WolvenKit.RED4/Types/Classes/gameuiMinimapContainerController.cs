using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapContainerController : gameuiMappinsContainerController
	{
		[Ordinal(18)] 
		[RED("settings")] 
		public CHandle<gameMinimapSettings> Settings
		{
			get => GetPropertyValue<CHandle<gameMinimapSettings>>();
			set => SetPropertyValue<CHandle<gameMinimapSettings>>(value);
		}

		[Ordinal(19)] 
		[RED("clampedMappinContainer")] 
		public inkCompoundWidgetReference ClampedMappinContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("unclampedMappinContainer")] 
		public inkCompoundWidgetReference UnclampedMappinContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("maskWidget")] 
		public inkMaskWidgetReference MaskWidget
		{
			get => GetPropertyValue<inkMaskWidgetReference>();
			set => SetPropertyValue<inkMaskWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("playerIconWidget")] 
		public inkWidgetReference PlayerIconWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("worldGeometryContainer")] 
		public inkCanvasWidgetReference WorldGeometryContainer
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("worldGeometryCache")] 
		public inkCacheWidgetReference WorldGeometryCache
		{
			get => GetPropertyValue<inkCacheWidgetReference>();
			set => SetPropertyValue<inkCacheWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("geometryLibraryID")] 
		public CName GeometryLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("timeDisplayWidget")] 
		public inkCompoundWidgetReference TimeDisplayWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("rootZoneSafety")] 
		public CWeakHandle<inkWidget> RootZoneSafety
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("locationTextWidget")] 
		public inkTextWidgetReference LocationTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("securityAreaVignetteWidget")] 
		public inkWidgetReference SecurityAreaVignetteWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("securityAreaText")] 
		public inkTextWidgetReference SecurityAreaText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("combatModeHighlight")] 
		public inkWidgetReference CombatModeHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("courierTimerContainer")] 
		public inkWidgetReference CourierTimerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("courierTimerText")] 
		public inkTextWidgetReference CourierTimerText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("alternativeIconContainer")] 
		public inkWidgetReference AlternativeIconContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("autoDriveModeHighlight")] 
		public inkWidgetReference AutoDriveModeHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("autoDriveIconRef")] 
		public inkWidgetLibraryReference AutoDriveIconRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(39)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(40)] 
		[RED("zoneVignetteAnimProxy")] 
		public CHandle<inkanimProxy> ZoneVignetteAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("inPublicOrRestrictedZone")] 
		public CBool InPublicOrRestrictedZone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("fluffTextCount")] 
		public CInt32 FluffTextCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(43)] 
		[RED("alternativePlayerIconAnimProxy")] 
		public CHandle<inkanimProxy> AlternativePlayerIconAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(44)] 
		[RED("hasOverridenPlayerIcon")] 
		public CBool HasOverridenPlayerIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(46)] 
		[RED("mapBlackboard")] 
		public CWeakHandle<gameIBlackboard> MapBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(47)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(48)] 
		[RED("locationDataCallback")] 
		public CHandle<redCallbackObject> LocationDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("highlightRequestCallback")] 
		public CHandle<redCallbackObject> HighlightRequestCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("countdownTimerBlackboard")] 
		public CWeakHandle<gameIBlackboard> CountdownTimerBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(51)] 
		[RED("countdownTimerDefinition")] 
		public CHandle<UI_HUDCountdownTimerDef> CountdownTimerDefinition
		{
			get => GetPropertyValue<CHandle<UI_HUDCountdownTimerDef>>();
			set => SetPropertyValue<CHandle<UI_HUDCountdownTimerDef>>(value);
		}

		[Ordinal(52)] 
		[RED("countdownTimerActiveCallback")] 
		public CHandle<redCallbackObject> CountdownTimerActiveCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(53)] 
		[RED("countdownTimerTimeCallback")] 
		public CHandle<redCallbackObject> CountdownTimerTimeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(54)] 
		[RED("securityBlackBoardID")] 
		public CHandle<redCallbackObject> SecurityBlackBoardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(55)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(56)] 
		[RED("remoteControlledVehicleCameraChangedToTPPCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleCameraChangedToTPPCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(57)] 
		[RED("combatAnimation")] 
		public CHandle<inkanimProxy> CombatAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(58)] 
		[RED("autodriveDataDefinition")] 
		public CHandle<UI_AutodriveDataDef> AutodriveDataDefinition
		{
			get => GetPropertyValue<CHandle<UI_AutodriveDataDef>>();
			set => SetPropertyValue<CHandle<UI_AutodriveDataDef>>(value);
		}

		[Ordinal(59)] 
		[RED("autodriveDataBlackboard")] 
		public CWeakHandle<gameIBlackboard> AutodriveDataBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(60)] 
		[RED("autoDriveEnabledCallback")] 
		public CHandle<redCallbackObject> AutoDriveEnabledCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(61)] 
		[RED("autoDriveEnabled")] 
		public CBool AutoDriveEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("autoDriveAnimation")] 
		public CHandle<inkanimProxy> AutoDriveAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(63)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("currentZoneType")] 
		public CEnum<ESecurityAreaType> CurrentZoneType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(65)] 
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
			LocationTextWidget = new inkTextWidgetReference();
			FluffText1 = new inkTextWidgetReference();
			SecurityAreaVignetteWidget = new inkWidgetReference();
			SecurityAreaText = new inkTextWidgetReference();
			CombatModeHighlight = new inkWidgetReference();
			CourierTimerContainer = new inkWidgetReference();
			CourierTimerText = new inkTextWidgetReference();
			AlternativeIconContainer = new inkWidgetReference();
			AutoDriveModeHighlight = new inkWidgetReference();
			AutoDriveIconRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
