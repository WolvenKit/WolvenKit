using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorLimiterNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("activationLimitPerFrame")] public CUInt32 ActivationLimitPerFrame { get; set; }
		[Ordinal(2)] [RED("delayChildActivation")] public CBool DelayChildActivation { get; set; }
		[Ordinal(3)] [RED("delayChildActivationIfAttaching")] public CBool DelayChildActivationIfAttaching { get; set; }

		public AIbehaviorLimiterNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
