using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldVehicleForbiddenAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(0)]  [RED("innerAreaBoundToOuterArea")] public CBool InnerAreaBoundToOuterArea { get; set; }
		[Ordinal(1)]  [RED("innerAreaOutline")] public CHandle<AreaShapeOutline> InnerAreaOutline { get; set; }
		[Ordinal(2)]  [RED("parkingSpots")] public CArray<NodeRef> ParkingSpots { get; set; }
		[Ordinal(3)]  [RED("innerAreaSpeedLimit")] public CFloat InnerAreaSpeedLimit { get; set; }
		[Ordinal(4)]  [RED("areaSpeedLimit")] public CFloat AreaSpeedLimit { get; set; }
		[Ordinal(5)]  [RED("enableNullArea")] public CBool EnableNullArea { get; set; }
		[Ordinal(6)]  [RED("dismount")] public CBool Dismount { get; set; }
		[Ordinal(7)]  [RED("enableSummoning")] public CBool EnableSummoning { get; set; }

		public worldVehicleForbiddenAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
