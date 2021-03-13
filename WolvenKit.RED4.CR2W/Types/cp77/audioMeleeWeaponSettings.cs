using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("quickAttackSettings")] public audioMeleeAttackSettings QuickAttackSettings { get; set; }
		[Ordinal(2)] [RED("strongAttackSettings")] public audioMeleeAttackSettings StrongAttackSettings { get; set; }
		[Ordinal(3)] [RED("weaponHandlingSettings")] public audioWeaponHandlingSettings WeaponHandlingSettings { get; set; }

		public audioMeleeWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
