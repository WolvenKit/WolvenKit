using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsThreatOnPathConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("threatObject")] public CHandle<AIArgumentMapping> ThreatObject { get; set; }
		[Ordinal(1)]  [RED("threatRadius")] public CHandle<AIArgumentMapping> ThreatRadius { get; set; }

		public AIbehaviorIsThreatOnPathConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
