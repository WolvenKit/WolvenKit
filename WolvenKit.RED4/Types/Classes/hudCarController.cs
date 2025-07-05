using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudCarController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("SpeedValue")] 
		public inkTextWidgetReference SpeedValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("SpeedUnits")] 
		public inkTextWidgetReference SpeedUnits
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("RPMChunks")] 
		public CArray<inkImageWidgetReference> RPMChunks
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(12)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(16)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(17)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("gearBBConnectionId")] 
		public CHandle<redCallbackObject> GearBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("tppBBConnectionId")] 
		public CHandle<redCallbackObject> TppBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("leanAngleBBConnectionId")] 
		public CHandle<redCallbackObject> LeanAngleBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("playerStateBBConnectionId")] 
		public CHandle<redCallbackObject> PlayerStateBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("currentSpeed")] 
		public CInt32 CurrentSpeed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(27)] 
		[RED("activeVehicle")] 
		public CWeakHandle<vehicleBaseObject> ActiveVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(28)] 
		[RED("driver")] 
		public CBool Driver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(30)] 
		[RED("settingsListener")] 
		public CHandle<CarSpeedometerSettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<CarSpeedometerSettingsListener>>();
			set => SetPropertyValue<CHandle<CarSpeedometerSettingsListener>>(value);
		}

		[Ordinal(31)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("kmOn")] 
		public CBool KmOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public hudCarController()
		{
			SpeedValue = new inkTextWidgetReference();
			SpeedUnits = new inkTextWidgetReference();
			RPMChunks = new();
			CurrentTime = new GameTime();
			CurrentSpeed = -1;
			GroupPath = "/interface";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
