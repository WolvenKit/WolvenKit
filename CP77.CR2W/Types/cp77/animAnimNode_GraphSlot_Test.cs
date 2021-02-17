using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlot_Test : animAnimNode_GraphSlot
	{
		[Ordinal(4)] [RED("graph_TEST")] public rRef<animAnimGraph> Graph_TEST { get; set; }

		public animAnimNode_GraphSlot_Test(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
