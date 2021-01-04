using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BodyPartHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("attackSubtype")] public CEnum<gamedataAttackSubtype> AttackSubtype { get; set; }
		[Ordinal(1)]  [RED("bodyPart")] public CName BodyPart { get; set; }

		public BodyPartHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
