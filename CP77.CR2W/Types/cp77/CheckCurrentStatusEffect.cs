using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentStatusEffect : AIStatusEffectCondition
	{
		[Ordinal(0)] [RED("statusEffectTypeToCompare")] public CEnum<gamedataStatusEffectType> StatusEffectTypeToCompare { get; set; }
		[Ordinal(1)] [RED("statusEffectTagToCompare")] public CName StatusEffectTagToCompare { get; set; }

		public CheckCurrentStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
