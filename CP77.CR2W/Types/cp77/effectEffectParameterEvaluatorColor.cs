using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorColor : CVariable
	{
		[Ordinal(0)]  [RED("evaluator")] public CHandle<IEvaluatorColor> Evaluator { get; set; }
		[Ordinal(1)]  [RED("inputParameterOverride")] public CName InputParameterOverride { get; set; }

		public effectEffectParameterEvaluatorColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
