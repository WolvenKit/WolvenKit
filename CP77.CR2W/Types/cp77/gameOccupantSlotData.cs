using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameOccupantSlotData : CVariable
	{
		[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)] [RED("syncAnimationTag")] public CName SyncAnimationTag { get; set; }
		[Ordinal(2)] [RED("workSpotResource")] public rRef<workWorkspotResource> WorkSpotResource { get; set; }
		[Ordinal(3)] [RED("exitOffsetFromSlot")] public Vector4 ExitOffsetFromSlot { get; set; }
		[Ordinal(4)] [RED("role")] public CEnum<gameMountingSlotRole> Role { get; set; }

		public gameOccupantSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
