using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimationsLoadedCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("coreAnims")] public CBool CoreAnims { get; set; }
		[Ordinal(1)]  [RED("melee")] public CBool Melee { get; set; }

		public AnimationsLoadedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
