using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questFollowObject_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)]  [RED("followObjectRef")] public gameEntityReference FollowObjectRef { get; set; }
		[Ordinal(2)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(3)]  [RED("positionLerpSpeed")] public CFloat PositionLerpSpeed { get; set; }
		[Ordinal(4)]  [RED("rotationLerpSpeed")] public CFloat RotationLerpSpeed { get; set; }

		public questFollowObject_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
