using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimGraphResourceContainerEntry : CVariable
	{
		[Ordinal(0)] [RED("graphName")] public CName GraphName { get; set; }
		[Ordinal(1)] [RED("animGraphResource")] public rRef<animAnimGraph> AnimGraphResource { get; set; }

		public entAnimGraphResourceContainerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
