using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workSequence : workIContainerEntry
	{
		[Ordinal(4)] [RED("previousLoopInfinitely")] public CBool PreviousLoopInfinitely { get; set; }
		[Ordinal(5)] [RED("loopInfinitely")] public CBool LoopInfinitely { get; set; }
		[Ordinal(6)] [RED("category")] public CEnum<gamedataWorkspotCategory> Category { get; set; }

		public workSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
