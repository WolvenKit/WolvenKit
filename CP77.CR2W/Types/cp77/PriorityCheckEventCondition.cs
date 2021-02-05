using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PriorityCheckEventCondition : AISignalCondition
	{
		[Ordinal(0)]  [RED("requiredFlags")] public CArray<CEnum<AISignalFlags>> RequiredFlags { get; set; }
		[Ordinal(1)]  [RED("consumesSignal")] public CBool ConsumesSignal { get; set; }
		[Ordinal(2)]  [RED("activated")] public CBool Activated { get; set; }
		[Ordinal(3)]  [RED("executingSignal")] public AIGateSignal ExecutingSignal { get; set; }
		[Ordinal(4)]  [RED("executingSignalId")] public CUInt32 ExecutingSignalId { get; set; }

		public PriorityCheckEventCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
