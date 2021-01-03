using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEventWithTagConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("consumeEvent")] public CBool ConsumeEvent { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }

		public AIbehaviorEventWithTagConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
