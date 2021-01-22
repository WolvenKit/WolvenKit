using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workSequence : workIContainerEntry
	{
		[Ordinal(0)]  [RED("category")] public CEnum<gamedataWorkspotCategory> Category { get; set; }
		[Ordinal(1)]  [RED("loopInfinitely")] public CBool LoopInfinitely { get; set; }
		[Ordinal(2)]  [RED("previousLoopInfinitely")] public CBool PreviousLoopInfinitely { get; set; }

		public workSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
