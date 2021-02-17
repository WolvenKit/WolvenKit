using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineAndKeepDistance_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)] [RED("keepDistanceFromRef")] public gameEntityReference KeepDistanceFromRef { get; set; }
		[Ordinal(2)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(3)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(4)] [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(5)] [RED("minSpeed")] public CFloat MinSpeed { get; set; }
		[Ordinal(6)] [RED("reduceSpeedOnTurns")] public CBool ReduceSpeedOnTurns { get; set; }

		public questMoveOnSplineAndKeepDistance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
