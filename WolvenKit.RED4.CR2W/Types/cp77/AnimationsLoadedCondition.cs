using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationsLoadedCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("coreAnims")] public CBool CoreAnims { get; set; }
		[Ordinal(1)] [RED("melee")] public CBool Melee { get; set; }

		public AnimationsLoadedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
