using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionHandlerDefinition : LibTreeINodeDefinition
	{
		[Ordinal(0)]  [RED("signal")] public AIInterruptionSignal Signal { get; set; }
		[Ordinal(1)]  [RED("supportLessImportantSignals")] public CBool SupportLessImportantSignals { get; set; }

		public AIInterruptionHandlerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
