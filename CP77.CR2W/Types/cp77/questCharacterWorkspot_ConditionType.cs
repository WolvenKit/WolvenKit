using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterWorkspot_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(3)]  [RED("spotRef")] public NodeRef SpotRef { get; set; }
		[Ordinal(4)]  [RED("waitForAnimEnd")] public CBool WaitForAnimEnd { get; set; }

		public questCharacterWorkspot_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
