using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAvoidThreatTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("threatObject")] public CHandle<AIArgumentMapping> ThreatObject { get; set; }
		[Ordinal(1)]  [RED("threatRadius")] public CHandle<AIArgumentMapping> ThreatRadius { get; set; }

		public AIbehaviorAvoidThreatTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
