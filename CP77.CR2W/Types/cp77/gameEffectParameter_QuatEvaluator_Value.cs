using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_QuatEvaluator_Value : gameIEffectParameter_QuatEvaluator
	{
		[Ordinal(0)]  [RED("value")] public Quaternion Value { get; set; }

		public gameEffectParameter_QuatEvaluator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
