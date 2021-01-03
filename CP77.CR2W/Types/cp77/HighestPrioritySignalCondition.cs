using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HighestPrioritySignalCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)]  [RED("cbId")] public CUInt32 CbId { get; set; }
		[Ordinal(1)]  [RED("lastValue")] public CBool LastValue { get; set; }
		[Ordinal(2)]  [RED("signalName")] public CName SignalName { get; set; }

		public HighestPrioritySignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
