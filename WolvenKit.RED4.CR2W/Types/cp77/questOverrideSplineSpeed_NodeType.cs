using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOverrideSplineSpeed_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)] [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(2)] [RED("adjustTime")] public CFloat AdjustTime { get; set; }

		public questOverrideSplineSpeed_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
