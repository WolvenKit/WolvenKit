using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterWorkspot_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("spotRef")] public NodeRef SpotRef { get; set; }
		[Ordinal(1)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(2)]  [RED("waitForAnimEnd")] public CBool WaitForAnimEnd { get; set; }

        [Ordinal(998)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
        [Ordinal(999)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questCharacterWorkspot_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
