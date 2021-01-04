using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorIncludedDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)]  [RED("entries")] public CArray<AIbehaviorBehaviorIncludedDebuggerCommandEntry> Entries { get; set; }

		public AIbehaviorBehaviorIncludedDebuggerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
