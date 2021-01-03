using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineControlRubberbanding_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(1)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(2)]  [RED("keepDistanceFromRef")] public gameEntityReference KeepDistanceFromRef { get; set; }
		[Ordinal(3)]  [RED("minSpeed")] public CFloat MinSpeed { get; set; }
		[Ordinal(4)]  [RED("reduceSpeedOnTurns")] public CBool ReduceSpeedOnTurns { get; set; }
		[Ordinal(5)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }

		public questMoveOnSplineControlRubberbanding_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
