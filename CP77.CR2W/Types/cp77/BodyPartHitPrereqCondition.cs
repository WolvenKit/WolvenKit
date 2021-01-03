using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BodyPartHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("attackSubtype")] public CEnum<gamedataAttackSubtype> AttackSubtype { get; set; }
		[Ordinal(1)]  [RED("bodyPart")] public CName BodyPart { get; set; }

		public BodyPartHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
