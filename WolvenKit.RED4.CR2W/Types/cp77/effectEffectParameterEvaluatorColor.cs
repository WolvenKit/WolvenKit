using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorColor : CVariable
	{
		[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluatorColor> Evaluator { get; set; }
		[Ordinal(1)] [RED("inputParameterOverride")] public CName InputParameterOverride { get; set; }

		public effectEffectParameterEvaluatorColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
