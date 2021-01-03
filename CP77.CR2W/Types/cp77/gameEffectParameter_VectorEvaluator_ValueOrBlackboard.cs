using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_VectorEvaluator_ValueOrBlackboard : gameIEffectParameter_VectorEvaluator
	{
		[Ordinal(0)]  [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }
		[Ordinal(1)]  [RED("value")] public Vector4 Value { get; set; }

		public gameEffectParameter_VectorEvaluator_ValueOrBlackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
