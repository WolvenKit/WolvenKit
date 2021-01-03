using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsInDesiredRangeConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(0)]  [RED("deadZoneRadius")] public CHandle<AIArgumentMapping> DeadZoneRadius { get; set; }
		[Ordinal(1)]  [RED("desiredDistance")] public CHandle<AIArgumentMapping> DesiredDistance { get; set; }

		public AIbehaviorIsInDesiredRangeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
