using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAttachToElevatorCommandTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }

		public AIbehaviorAttachToElevatorCommandTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
