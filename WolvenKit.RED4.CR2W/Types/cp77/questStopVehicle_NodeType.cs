using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStopVehicle_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(2)] [RED("detachFromSpline")] public CBool DetachFromSpline { get; set; }

		public questStopVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
