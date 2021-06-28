using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudCarController : gameuiHUDGameController
	{
		private inkTextWidgetReference _speedValue;
		private CArray<inkImageWidgetReference> _rPMChunks;
		private CHandle<gameIBlackboard> _psmBlackboard;
		private CUInt32 _pSM_BBID;
		private CFloat _currentZoom;
		private GameTime _currentTime;
		private wCHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CUInt32 _vehicleBBStateConectionId;
		private CUInt32 _speedBBConnectionId;
		private CUInt32 _gearBBConnectionId;
		private CUInt32 _tppBBConnectionId;
		private CUInt32 _rpmValueBBConnectionId;
		private CUInt32 _leanAngleBBConnectionId;
		private CUInt32 _playerStateBBConnectionId;
		private CInt32 _activeChunks;
		private wCHandle<vehicleBaseObject> _activeVehicle;
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
		public CHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(12)] 
		[RED("PSM_BBID")] 
		public CUInt32 PSM_BBID
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
		public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetProperty(ref _activeVehicleUIBlackboard);
			set => SetProperty(ref _activeVehicleUIBlackboard, value);
		}

		[Ordinal(16)] 
		[RED("vehicleBBStateConectionId")] 
		public CUInt32 VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
		}

		[Ordinal(17)] 
		[RED("speedBBConnectionId")] 
		public CUInt32 SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(18)] 
		[RED("gearBBConnectionId")] 
		public CUInt32 GearBBConnectionId
		{
			get => GetProperty(ref _gearBBConnectionId);
			set => SetProperty(ref _gearBBConnectionId, value);
		}

		[Ordinal(19)] 
		[RED("tppBBConnectionId")] 
		public CUInt32 TppBBConnectionId
		{
			get => GetProperty(ref _tppBBConnectionId);
			set => SetProperty(ref _tppBBConnectionId, value);
		}

		[Ordinal(20)] 
		[RED("rpmValueBBConnectionId")] 
		public CUInt32 RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(21)] 
		[RED("leanAngleBBConnectionId")] 
		public CUInt32 LeanAngleBBConnectionId
		{
			get => GetProperty(ref _leanAngleBBConnectionId);
			set => SetProperty(ref _leanAngleBBConnectionId, value);
		}

		[Ordinal(22)] 
		[RED("playerStateBBConnectionId")] 
		public CUInt32 PlayerStateBBConnectionId
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
		public wCHandle<vehicleBaseObject> ActiveVehicle
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

		public hudCarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
