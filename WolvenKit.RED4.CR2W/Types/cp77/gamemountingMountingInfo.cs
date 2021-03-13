using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingInfo : CVariable
	{
		[Ordinal(0)] [RED("childId")] public entEntityID ChildId { get; set; }
		[Ordinal(1)] [RED("parentId")] public entEntityID ParentId { get; set; }
		[Ordinal(2)] [RED("slotId")] public gamemountingMountingSlotId SlotId { get; set; }

		public gamemountingMountingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
