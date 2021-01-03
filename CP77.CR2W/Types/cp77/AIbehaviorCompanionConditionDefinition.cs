using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompanionConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("companion")] public CHandle<AIArgumentMapping> Companion { get; set; }
		[Ordinal(1)]  [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }

		public AIbehaviorCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
