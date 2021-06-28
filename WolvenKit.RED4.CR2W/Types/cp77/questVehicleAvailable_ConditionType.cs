using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleAvailable_ConditionType : questIVehicleConditionType
	{
		private CEnum<questAvailableVehicleType> _vehicleType;
		private CString _vehicleName;

		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questAvailableVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(1)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get => GetProperty(ref _vehicleName);
			set => SetProperty(ref _vehicleName, value);
		}

		public questVehicleAvailable_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
