using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
