using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMinigameNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("networkRef")] public gameEntityReference NetworkRef { get; set; }
		[Ordinal(1)]  [RED("skipSummaryScreen")] public CBool SkipSummaryScreen { get; set; }
		[Ordinal(2)]  [RED("start")] public CBool Start { get; set; }

		public questMinigameNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
