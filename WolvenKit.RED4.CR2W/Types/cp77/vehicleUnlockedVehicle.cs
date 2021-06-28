using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleUnlockedVehicle : CVariable
	{
		private vehicleGarageVehicleID _vehicleID;
		private CFloat _health;

		[Ordinal(0)] 
		[RED("vehicleID")] 
		public vehicleGarageVehicleID VehicleID
		{
			get => GetProperty(ref _vehicleID);
			set => SetProperty(ref _vehicleID, value);
		}

		[Ordinal(1)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		public vehicleUnlockedVehicle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
