using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleAVArrived_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }

		public questVehicleAVArrived_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
