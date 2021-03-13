using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorVector : CVariable
	{
		[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluatorVector> Evaluator { get; set; }
		[Ordinal(1)] [RED("inputParameterOverride")] public CName InputParameterOverride { get; set; }

		public effectEffectParameterEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
