using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSignalConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(2)] [RED("mode")] public CEnum<AIbehaviorSignalConditionModes> Mode { get; set; }
		[Ordinal(3)] [RED("tagSignal")] public CBool TagSignal { get; set; }

		public AIbehaviorSignalConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
