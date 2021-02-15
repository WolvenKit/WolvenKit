using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_IntEvaluator_Value : gameIEffectParameter_IntEvaluator
	{
		[Ordinal(0)] [RED("value")] public CUInt32 Value { get; set; }

		public gameEffectParameter_IntEvaluator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
