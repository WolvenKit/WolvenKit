using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectSlotEntries : effectIPlacementEntries
	{
		[Ordinal(0)] [RED("inheritRotation")] public CBool InheritRotation { get; set; }
		[Ordinal(1)] [RED("slots")] public CArray<effectSlotEntry> Slots { get; set; }

		public effectSlotEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
