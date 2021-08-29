using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudCarController : gameuiHUDGameController
	{
		private inkTextWidgetReference _speedValue;
		private CArray<inkImageWidgetReference> _rPMChunks;
		private CWeakHandle<gameIBlackboard> _psmBlackboard;
		private CHandle<redCallbackObject> _pSM_BBID;
		private CFloat _currentZoom;
		private GameTime _currentTime;
		private CWeakHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CHandle<redCallbackObject> _vehicleBBStateConectionId;
		private CHandle<redCallbackObject> _speedBBConnectionId;
		private CHandle<redCallbackObject> _gearBBConnectionId;
		private CHandle<redCallbackObject> _tppBBConnectionId;
		private CHandle<redCallbackObject> _rpmValueBBConnectionId;
		private CHandle<redCallbackObject> _leanAngleBBConnectionId;
		private CHandle<redCallbackObject> _playerStateBBConnectionId;
		private CInt32 _activeChunks;
		private CWeakHandle<vehicleBaseObject> _activeVehicle;
		private CBool _driver;

		[Ordinal(9)] 
		[RED("SpeedValue")] 
		public inkTextWidgetReference SpeedValue
		{
			get => GetProperty(ref _speedValue);
			set => SetProperty(ref _speedValue, value);
		}

		[Ordinal(10)] 
		[RED("RPMChunks")] 
		public CArray<inkImageWidgetReference> RPMChunks
		{
			get => GetProperty(ref _rPMChunks);
			set => SetProperty(ref _rPMChunks, value);
		}

		[Ordinal(11)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(12)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(13)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetProperty(ref _currentZoom);
			set => SetProperty(ref _currentZoom, value);
		}

		[Ordinal(14)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(15)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetProperty(ref _activeVehicleUIBlackboard);
			set => SetProperty(ref _activeVehicleUIBlackboard, value);
		}

		[Ordinal(16)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
		}

		[Ordinal(17)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(18)] 
		[RED("gearBBConnectionId")] 
		public CHandle<redCallbackObject> GearBBConnectionId
		{
			get => GetProperty(ref _gearBBConnectionId);
			set => SetProperty(ref _gearBBConnectionId, value);
		}

		[Ordinal(19)] 
		[RED("tppBBConnectionId")] 
		public CHandle<redCallbackObject> TppBBConnectionId
		{
			get => GetProperty(ref _tppBBConnectionId);
			set => SetProperty(ref _tppBBConnectionId, value);
		}

		[Ordinal(20)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(21)] 
		[RED("leanAngleBBConnectionId")] 
		public CHandle<redCallbackObject> LeanAngleBBConnectionId
		{
			get => GetProperty(ref _leanAngleBBConnectionId);
			set => SetProperty(ref _leanAngleBBConnectionId, value);
		}

		[Ordinal(22)] 
		[RED("playerStateBBConnectionId")] 
		public CHandle<redCallbackObject> PlayerStateBBConnectionId
		{
			get => GetProperty(ref _playerStateBBConnectionId);
			set => SetProperty(ref _playerStateBBConnectionId, value);
		}

		[Ordinal(23)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetProperty(ref _activeChunks);
			set => SetProperty(ref _activeChunks, value);
		}

		[Ordinal(24)] 
		[RED("activeVehicle")] 
		public CWeakHandle<vehicleBaseObject> ActiveVehicle
		{
			get => GetProperty(ref _activeVehicle);
			set => SetProperty(ref _activeVehicle, value);
		}

		[Ordinal(25)] 
		[RED("driver")] 
		public CBool Driver
		{
			get => GetProperty(ref _driver);
			set => SetProperty(ref _driver, value);
		}
	}
}
