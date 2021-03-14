using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BodyPartHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("bodyPart")] public CName BodyPart { get; set; }
		[Ordinal(2)] [RED("attackSubtype")] public CEnum<gamedataAttackSubtype> AttackSubtype { get; set; }

		public BodyPartHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
