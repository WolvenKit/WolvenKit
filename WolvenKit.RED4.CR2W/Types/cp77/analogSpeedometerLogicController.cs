using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class analogSpeedometerLogicController : IVehicleModuleController
	{
		private inkWidgetReference _analogSpeedNeedleWidget;
		private CFloat _analogSpeedNeedleMinRotation;
		private CFloat _analogSpeedNeedleMaxRotation;
		private CFloat _analogSpeedNeedleMaxValue;
		private CUInt32 _speedBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private wCHandle<vehicleBaseObject> _vehicle;

		[Ordinal(1)] 
		[RED("analogSpeedNeedleWidget")] 
		public inkWidgetReference AnalogSpeedNeedleWidget
		{
			get => GetProperty(ref _analogSpeedNeedleWidget);
			set => SetProperty(ref _analogSpeedNeedleWidget, value);
		}

		[Ordinal(2)] 
		[RED("analogSpeedNeedleMinRotation")] 
		public CFloat AnalogSpeedNeedleMinRotation
		{
			get => GetProperty(ref _analogSpeedNeedleMinRotation);
			set => SetProperty(ref _analogSpeedNeedleMinRotation, value);
		}

		[Ordinal(3)] 
		[RED("analogSpeedNeedleMaxRotation")] 
		public CFloat AnalogSpeedNeedleMaxRotation
		{
			get => GetProperty(ref _analogSpeedNeedleMaxRotation);
			set => SetProperty(ref _analogSpeedNeedleMaxRotation, value);
		}

		[Ordinal(4)] 
		[RED("analogSpeedNeedleMaxValue")] 
		public CFloat AnalogSpeedNeedleMaxValue
		{
			get => GetProperty(ref _analogSpeedNeedleMaxValue);
			set => SetProperty(ref _analogSpeedNeedleMaxValue, value);
		}

		[Ordinal(5)] 
		[RED("speedBBConnectionId")] 
		public CUInt32 SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(6)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}

		[Ordinal(7)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		public analogSpeedometerLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
