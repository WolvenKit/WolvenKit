using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterAttack_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
		[Ordinal(1)]  [RED("isTargetPlayer")] public CBool IsTargetPlayer { get; set; }

		public questCharacterAttack_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
