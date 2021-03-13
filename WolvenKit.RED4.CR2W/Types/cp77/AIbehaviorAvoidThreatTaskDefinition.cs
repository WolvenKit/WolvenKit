using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAvoidThreatTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("threatObject")] public CHandle<AIArgumentMapping> ThreatObject { get; set; }
		[Ordinal(2)] [RED("threatRadius")] public CHandle<AIArgumentMapping> ThreatRadius { get; set; }

		public AIbehaviorAvoidThreatTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
