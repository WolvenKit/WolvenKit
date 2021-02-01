using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GetRandomThreat : AIRandomTasks
	{
		[Ordinal(0)]  [RED("outThreatArgument")] public CHandle<AIArgumentMapping> OutThreatArgument { get; set; }

		public GetRandomThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
