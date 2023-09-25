using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerHUDGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(10)] 
		[RED("vehiclePS")] 
		public CHandle<VehicleComponentPS> VehiclePS
		{
			get => GetPropertyValue<CHandle<VehicleComponentPS>>();
			set => SetPropertyValue<CHandle<VehicleComponentPS>>(value);
		}

		[Ordinal(11)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("healthStatus")] 
		public inkTextWidgetReference HealthStatus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("healthBar")] 
		public inkWidgetReference HealthBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("rightStickX")] 
		public CFloat RightStickX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("rightStickY")] 
		public CFloat RightStickY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("LeanAngleValue")] 
		public inkCanvasWidgetReference LeanAngleValue
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("CoriRotation")] 
		public inkCanvasWidgetReference CoriRotation
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("CompassRotation")] 
		public inkCanvasWidgetReference CompassRotation
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("Cori_S")] 
		public inkCanvasWidgetReference Cori_S
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("Cori_M")] 
		public inkCanvasWidgetReference Cori_M
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("trimmerArrow")] 
		public inkImageWidgetReference TrimmerArrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("SpeedValue")] 
		public inkTextWidgetReference SpeedValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("RPMValue")] 
		public inkTextWidgetReference RPMValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("scanBlackboard")] 
		public CWeakHandle<gameIBlackboard> ScanBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(31)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(32)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(33)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("gearBBConnectionId")] 
		public CHandle<redCallbackObject> GearBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("tppBBConnectionId")] 
		public CHandle<redCallbackObject> TppBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("leanAngleBBConnectionId")] 
		public CHandle<redCallbackObject> LeanAngleBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("playerStateBBConnectionId")] 
		public CHandle<redCallbackObject> PlayerStateBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("isTargetingFriendlyConnectionId")] 
		public CHandle<redCallbackObject> IsTargetingFriendlyConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(42)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(44)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(46)] 
		[RED("quickhacksMemoryPercent")] 
		public CFloat QuickhacksMemoryPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(48)] 
		[RED("weaponBlackboard")] 
		public CWeakHandle<gameIBlackboard> WeaponBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(49)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("targetIndicators")] 
		public CArray<TargetIndicatorEntry> TargetIndicators
		{
			get => GetPropertyValue<CArray<TargetIndicatorEntry>>();
			set => SetPropertyValue<CArray<TargetIndicatorEntry>>(value);
		}

		[Ordinal(51)] 
		[RED("targetHolder")] 
		public inkCompoundWidgetReference TargetHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("targetWidgetLibraryName")] 
		public CName TargetWidgetLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(53)] 
		[RED("targetWidgetPoolSize")] 
		public CInt32 TargetWidgetPoolSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiPanzerHUDGameController()
		{
			Date = new inkTextWidgetReference();
			Timer = new inkTextWidgetReference();
			HealthStatus = new inkTextWidgetReference();
			HealthBar = new inkWidgetReference();
			LeanAngleValue = new inkCanvasWidgetReference();
			CoriRotation = new inkCanvasWidgetReference();
			CompassRotation = new inkCanvasWidgetReference();
			Cori_S = new inkCanvasWidgetReference();
			Cori_M = new inkCanvasWidgetReference();
			TrimmerArrow = new inkImageWidgetReference();
			SpeedValue = new inkTextWidgetReference();
			RPMValue = new inkTextWidgetReference();
			CurrentTime = new GameTime();
			TargetIndicators = new();
			TargetHolder = new inkCompoundWidgetReference();
			TargetWidgetLibraryName = "Marker";
			TargetWidgetPoolSize = 10;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
