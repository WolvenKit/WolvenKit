using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HighestPrioritySignalCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(1)] [RED("cbId")] public CUInt32 CbId { get; set; }
		[Ordinal(2)] [RED("lastValue")] public CBool LastValue { get; set; }

		public HighestPrioritySignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
