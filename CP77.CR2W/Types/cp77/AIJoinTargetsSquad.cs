using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIJoinTargetsSquad : AICommand
	{
		[Ordinal(4)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }

		public AIJoinTargetsSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
