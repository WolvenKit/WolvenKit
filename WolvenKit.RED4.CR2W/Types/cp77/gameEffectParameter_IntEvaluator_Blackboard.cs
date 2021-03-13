using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_IntEvaluator_Blackboard : gameIEffectParameter_IntEvaluator
	{
		[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }

		public gameEffectParameter_IntEvaluator_Blackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
