using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleControllerPS : gameComponentPS
	{
		private CStatic<vehicleVehicleSlotsState> _vehicleDoors;
		private CEnum<vehicleEState> _state;
		private CEnum<vehicleELightMode> _lightMode;
		private CBool _isAlarmOn;

		[Ordinal(0)] 
		[RED("vehicleDoors", 6)] 
		public CStatic<vehicleVehicleSlotsState> VehicleDoors
		{
			get => GetProperty(ref _vehicleDoors);
			set => SetProperty(ref _vehicleDoors, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<vehicleEState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("lightMode")] 
		public CEnum<vehicleELightMode> LightMode
		{
			get => GetProperty(ref _lightMode);
			set => SetProperty(ref _lightMode, value);
		}

		[Ordinal(3)] 
		[RED("isAlarmOn")] 
		public CBool IsAlarmOn
		{
			get => GetProperty(ref _isAlarmOn);
			set => SetProperty(ref _isAlarmOn, value);
		}

		public vehicleControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
