using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAttachToElevatorCommandTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }

		public AIbehaviorAttachToElevatorCommandTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
