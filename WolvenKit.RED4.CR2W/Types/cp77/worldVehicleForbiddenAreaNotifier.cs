using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldVehicleForbiddenAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] [RED("innerAreaBoundToOuterArea")] public CBool InnerAreaBoundToOuterArea { get; set; }
		[Ordinal(4)] [RED("innerAreaOutline")] public CHandle<AreaShapeOutline> InnerAreaOutline { get; set; }
		[Ordinal(5)] [RED("parkingSpots")] public CArray<NodeRef> ParkingSpots { get; set; }
		[Ordinal(6)] [RED("innerAreaSpeedLimit")] public CFloat InnerAreaSpeedLimit { get; set; }
		[Ordinal(7)] [RED("areaSpeedLimit")] public CFloat AreaSpeedLimit { get; set; }
		[Ordinal(8)] [RED("enableNullArea")] public CBool EnableNullArea { get; set; }
		[Ordinal(9)] [RED("dismount")] public CBool Dismount { get; set; }
		[Ordinal(10)] [RED("enableSummoning")] public CBool EnableSummoning { get; set; }

		public worldVehicleForbiddenAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
