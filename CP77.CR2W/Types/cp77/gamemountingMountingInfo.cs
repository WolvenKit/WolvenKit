using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingInfo : CVariable
	{
		[Ordinal(0)]  [RED("childId")] public entEntityID ChildId { get; set; }
		[Ordinal(1)]  [RED("parentId")] public entEntityID ParentId { get; set; }
		[Ordinal(2)]  [RED("slotId")] public gamemountingMountingSlotId SlotId { get; set; }

		public gamemountingMountingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
