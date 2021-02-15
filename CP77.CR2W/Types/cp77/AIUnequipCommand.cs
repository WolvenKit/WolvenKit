using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIUnequipCommand : AICommand
	{
		[Ordinal(4)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(5)] [RED("durationOverride")] public CFloat DurationOverride { get; set; }

		public AIUnequipCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
