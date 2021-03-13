using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMinigameNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("start")] public CBool Start { get; set; }
		[Ordinal(3)] [RED("skipSummaryScreen")] public CBool SkipSummaryScreen { get; set; }
		[Ordinal(4)] [RED("networkRef")] public gameEntityReference NetworkRef { get; set; }

		public questMinigameNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
