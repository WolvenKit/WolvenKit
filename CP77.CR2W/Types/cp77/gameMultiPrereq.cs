using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereq : gameIPrereq
	{
		[Ordinal(0)] [RED("aggregationType")] public CEnum<gameAggregationType> AggregationType { get; set; }
		[Ordinal(1)] [RED("nestedPrereqs")] public CArray<CHandle<gameIPrereq>> NestedPrereqs { get; set; }

		public gameMultiPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
