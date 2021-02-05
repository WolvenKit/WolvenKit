using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneExitDefinition : CVariable
	{
		[Ordinal(0)]  [RED("outLaneRef")] public NodeRef OutLaneRef { get; set; }
		[Ordinal(1)]  [RED("exitPosition")] public Vector4 ExitPosition { get; set; }
		[Ordinal(2)]  [RED("exitProbability")] public CFloat ExitProbability { get; set; }
		[Ordinal(3)]  [RED("endConnection")] public CBool EndConnection { get; set; }
		[Ordinal(4)]  [RED("thisLaneReversed")] public CBool ThisLaneReversed { get; set; }
		[Ordinal(5)]  [RED("outLaneReversed")] public CBool OutLaneReversed { get; set; }

		public worldTrafficLaneExitDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
