using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleGeneralData : CVariable
	{
		private CName _revSoundbankName;
		private CName _revElectricSoundbankName;
		private CName _enterVehicleEvent;
		private CName _exitVehicleEvent;
		private CName _ignitionStartEvent;
		private CName _ignitionEndEvent;
		private CName _hornOnEvent;
		private CName _hornOffEvent;
		private CName _policeHornOnEvent;
		private CName _policeHornOffEvent;
		private CName _sirenOnEvent;
		private CName _sirenOffEvent;
		private CName _rainStartEvent;
		private CName _rainStopEvent;
		private CName _tyreBurstEvent;
		private CName _skid;
		private CName _inclination;
		private CName _impactVelocity;
		private CName _impactGridCellRawChange;
		private CName _collisionSoundEvent;
		private CName _interiorReverbBus;
		private CName _acoustingIsolationFactor;
		private CName _dopplerShift;
		private audioVehicleDoorsSettingsMetadata _vehicleDoorsSettings;
		private audioVehicleInteriorParameterData _vehicleInteriorParameterData;
		private audioVehicleTemperatureSettings _vehicleTemperatureSettings;

		[Ordinal(0)] 
		[RED("revSoundbankName")] 
		public CName RevSoundbankName
		{
			get => GetProperty(ref _revSoundbankName);
			set => SetProperty(ref _revSoundbankName, value);
		}

		[Ordinal(1)] 
		[RED("revElectricSoundbankName")] 
		public CName RevElectricSoundbankName
		{
			get => GetProperty(ref _revElectricSoundbankName);
			set => SetProperty(ref _revElectricSoundbankName, value);
		}

		[Ordinal(2)] 
		[RED("enterVehicleEvent")] 
		public CName EnterVehicleEvent
		{
			get => GetProperty(ref _enterVehicleEvent);
			set => SetProperty(ref _enterVehicleEvent, value);
		}

		[Ordinal(3)] 
		[RED("exitVehicleEvent")] 
		public CName ExitVehicleEvent
		{
			get => GetProperty(ref _exitVehicleEvent);
			set => SetProperty(ref _exitVehicleEvent, value);
		}

		[Ordinal(4)] 
		[RED("ignitionStartEvent")] 
		public CName IgnitionStartEvent
		{
			get => GetProperty(ref _ignitionStartEvent);
			set => SetProperty(ref _ignitionStartEvent, value);
		}

		[Ordinal(5)] 
		[RED("ignitionEndEvent")] 
		public CName IgnitionEndEvent
		{
			get => GetProperty(ref _ignitionEndEvent);
			set => SetProperty(ref _ignitionEndEvent, value);
		}

		[Ordinal(6)] 
		[RED("hornOnEvent")] 
		public CName HornOnEvent
		{
			get => GetProperty(ref _hornOnEvent);
			set => SetProperty(ref _hornOnEvent, value);
		}

		[Ordinal(7)] 
		[RED("hornOffEvent")] 
		public CName HornOffEvent
		{
			get => GetProperty(ref _hornOffEvent);
			set => SetProperty(ref _hornOffEvent, value);
		}

		[Ordinal(8)] 
		[RED("policeHornOnEvent")] 
		public CName PoliceHornOnEvent
		{
			get => GetProperty(ref _policeHornOnEvent);
			set => SetProperty(ref _policeHornOnEvent, value);
		}

		[Ordinal(9)] 
		[RED("policeHornOffEvent")] 
		public CName PoliceHornOffEvent
		{
			get => GetProperty(ref _policeHornOffEvent);
			set => SetProperty(ref _policeHornOffEvent, value);
		}

		[Ordinal(10)] 
		[RED("sirenOnEvent")] 
		public CName SirenOnEvent
		{
			get => GetProperty(ref _sirenOnEvent);
			set => SetProperty(ref _sirenOnEvent, value);
		}

		[Ordinal(11)] 
		[RED("sirenOffEvent")] 
		public CName SirenOffEvent
		{
			get => GetProperty(ref _sirenOffEvent);
			set => SetProperty(ref _sirenOffEvent, value);
		}

		[Ordinal(12)] 
		[RED("rainStartEvent")] 
		public CName RainStartEvent
		{
			get => GetProperty(ref _rainStartEvent);
			set => SetProperty(ref _rainStartEvent, value);
		}

		[Ordinal(13)] 
		[RED("rainStopEvent")] 
		public CName RainStopEvent
		{
			get => GetProperty(ref _rainStopEvent);
			set => SetProperty(ref _rainStopEvent, value);
		}

		[Ordinal(14)] 
		[RED("tyreBurstEvent")] 
		public CName TyreBurstEvent
		{
			get => GetProperty(ref _tyreBurstEvent);
			set => SetProperty(ref _tyreBurstEvent, value);
		}

		[Ordinal(15)] 
		[RED("skid")] 
		public CName Skid
		{
			get => GetProperty(ref _skid);
			set => SetProperty(ref _skid, value);
		}

		[Ordinal(16)] 
		[RED("inclination")] 
		public CName Inclination
		{
			get => GetProperty(ref _inclination);
			set => SetProperty(ref _inclination, value);
		}

		[Ordinal(17)] 
		[RED("impactVelocity")] 
		public CName ImpactVelocity
		{
			get => GetProperty(ref _impactVelocity);
			set => SetProperty(ref _impactVelocity, value);
		}

		[Ordinal(18)] 
		[RED("impactGridCellRawChange")] 
		public CName ImpactGridCellRawChange
		{
			get => GetProperty(ref _impactGridCellRawChange);
			set => SetProperty(ref _impactGridCellRawChange, value);
		}

		[Ordinal(19)] 
		[RED("collisionSoundEvent")] 
		public CName CollisionSoundEvent
		{
			get => GetProperty(ref _collisionSoundEvent);
			set => SetProperty(ref _collisionSoundEvent, value);
		}

		[Ordinal(20)] 
		[RED("interiorReverbBus")] 
		public CName InteriorReverbBus
		{
			get => GetProperty(ref _interiorReverbBus);
			set => SetProperty(ref _interiorReverbBus, value);
		}

		[Ordinal(21)] 
		[RED("acoustingIsolationFactor")] 
		public CName AcoustingIsolationFactor
		{
			get => GetProperty(ref _acoustingIsolationFactor);
			set => SetProperty(ref _acoustingIsolationFactor, value);
		}

		[Ordinal(22)] 
		[RED("dopplerShift")] 
		public CName DopplerShift
		{
			get => GetProperty(ref _dopplerShift);
			set => SetProperty(ref _dopplerShift, value);
		}

		[Ordinal(23)] 
		[RED("vehicleDoorsSettings")] 
		public audioVehicleDoorsSettingsMetadata VehicleDoorsSettings
		{
			get => GetProperty(ref _vehicleDoorsSettings);
			set => SetProperty(ref _vehicleDoorsSettings, value);
		}

		[Ordinal(24)] 
		[RED("vehicleInteriorParameterData")] 
		public audioVehicleInteriorParameterData VehicleInteriorParameterData
		{
			get => GetProperty(ref _vehicleInteriorParameterData);
			set => SetProperty(ref _vehicleInteriorParameterData, value);
		}

		[Ordinal(25)] 
		[RED("vehicleTemperatureSettings")] 
		public audioVehicleTemperatureSettings VehicleTemperatureSettings
		{
			get => GetProperty(ref _vehicleTemperatureSettings);
			set => SetProperty(ref _vehicleTemperatureSettings, value);
		}

		public audioVehicleGeneralData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
