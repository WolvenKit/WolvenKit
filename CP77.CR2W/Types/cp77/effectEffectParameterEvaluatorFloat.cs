using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorFloat : CVariable
	{
		[Ordinal(0)]  [RED("evaluator")] public CHandle<IEvaluatorFloat> Evaluator { get; set; }
		[Ordinal(1)]  [RED("inputParameterIsPostMultiplier")] public CBool InputParameterIsPostMultiplier { get; set; }
		[Ordinal(2)]  [RED("inputParameterOverride")] public CName InputParameterOverride { get; set; }

		public effectEffectParameterEvaluatorFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
