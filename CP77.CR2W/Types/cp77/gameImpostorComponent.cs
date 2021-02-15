using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameImpostorComponent : entIComponent
	{
		[Ordinal(3)] [RED("isCharacterReplica")] public CBool IsCharacterReplica { get; set; }
		[Ordinal(4)] [RED("addHead")] public CBool AddHead { get; set; }
		[Ordinal(5)] [RED("ignorePlayerHeadSlot")] public CBool IgnorePlayerHeadSlot { get; set; }
		[Ordinal(6)] [RED("slotIDsToOmit")] public CArray<TweakDBID> SlotIDsToOmit { get; set; }

		public gameImpostorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
