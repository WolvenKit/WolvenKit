using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConditionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		[Ordinal(0)]  [RED("isInverted")] public CBool IsInverted { get; set; }

		public AIbehaviorConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
