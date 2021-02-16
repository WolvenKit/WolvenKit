using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_String : CVariable
	{
		[Ordinal(0)] [RED("evaluator")] public CHandle<gameIEffectParameter_StringEvaluator> Evaluator { get; set; }

		public gameEffectInputParameter_String(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
