using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSignalConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("mode")] public CEnum<AIbehaviorSignalConditionModes> Mode { get; set; }
		[Ordinal(1)]  [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(2)]  [RED("tagSignal")] public CBool TagSignal { get; set; }

		public AIbehaviorSignalConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
