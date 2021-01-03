using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompleteOnEventNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(1)]  [RED("resultOnEvent")] public CEnum<AIbehaviorCompletionStatus> ResultOnEvent { get; set; }

		public AIbehaviorCompleteOnEventNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
