using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentStatusEffect : AIStatusEffectCondition
	{
		[Ordinal(0)] [RED("statusEffectTypeToCompare")] public CEnum<gamedataStatusEffectType> StatusEffectTypeToCompare { get; set; }
		[Ordinal(1)] [RED("statusEffectTagToCompare")] public CName StatusEffectTagToCompare { get; set; }

		public CheckCurrentStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
