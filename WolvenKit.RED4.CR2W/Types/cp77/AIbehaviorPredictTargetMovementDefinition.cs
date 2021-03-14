using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPredictTargetMovementDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(2)] [RED("timeInterval")] public CHandle<AIArgumentMapping> TimeInterval { get; set; }
		[Ordinal(3)] [RED("result")] public CHandle<AIArgumentMapping> Result { get; set; }

		public AIbehaviorPredictTargetMovementDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
