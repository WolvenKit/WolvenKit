using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluator : CVariable
	{
		[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluator> Evaluator { get; set; }
		[Ordinal(1)] [RED("inputParameterOverride")] public CName InputParameterOverride { get; set; }

		public effectEffectParameterEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
