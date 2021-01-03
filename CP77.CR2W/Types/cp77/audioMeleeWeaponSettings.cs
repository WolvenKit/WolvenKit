using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("quickAttackSettings")] public audioMeleeAttackSettings QuickAttackSettings { get; set; }
		[Ordinal(1)]  [RED("strongAttackSettings")] public audioMeleeAttackSettings StrongAttackSettings { get; set; }
		[Ordinal(2)]  [RED("weaponHandlingSettings")] public audioWeaponHandlingSettings WeaponHandlingSettings { get; set; }

		public audioMeleeWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
