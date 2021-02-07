using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterAim_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(1)]  [RED("preciseAiming")] public CBool PreciseAiming { get; set; }
		[Ordinal(2)]  [RED("targetRef")] public gameEntityReference TargetRef { get; set; }

		public questCharacterAim_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
