using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIEquipCommand : AICommand
	{
		[Ordinal(0)]  [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(1)]  [RED("itemId")] public TweakDBID ItemId { get; set; }
		[Ordinal(2)]  [RED("failIfItemNotFound")] public CBool FailIfItemNotFound { get; set; }
		[Ordinal(3)]  [RED("durationOverride")] public CFloat DurationOverride { get; set; }

		public AIEquipCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
