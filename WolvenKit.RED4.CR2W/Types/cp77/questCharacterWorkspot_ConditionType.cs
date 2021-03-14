using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterWorkspot_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("spotRef")] public NodeRef SpotRef { get; set; }
		[Ordinal(3)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(4)] [RED("waitForAnimEnd")] public CBool WaitForAnimEnd { get; set; }

		public questCharacterWorkspot_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
