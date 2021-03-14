using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorFloat : CVariable
	{
		[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluatorFloat> Evaluator { get; set; }
		[Ordinal(1)] [RED("inputParameterOverride")] public CName InputParameterOverride { get; set; }
		[Ordinal(2)] [RED("inputParameterIsPostMultiplier")] public CBool InputParameterIsPostMultiplier { get; set; }

		public effectEffectParameterEvaluatorFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
