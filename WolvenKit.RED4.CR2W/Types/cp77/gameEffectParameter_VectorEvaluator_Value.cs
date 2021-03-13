using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_VectorEvaluator_Value : gameIEffectParameter_VectorEvaluator
	{
		[Ordinal(0)] [RED("value")] public Vector4 Value { get; set; }

		public gameEffectParameter_VectorEvaluator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
