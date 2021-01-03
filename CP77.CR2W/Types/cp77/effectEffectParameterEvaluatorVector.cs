using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorVector : CVariable
	{
		[Ordinal(0)]  [RED("evaluator")] public CHandle<IEvaluatorVector> Evaluator { get; set; }
		[Ordinal(1)]  [RED("inputParameterOverride")] public CName InputParameterOverride { get; set; }

		public effectEffectParameterEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
