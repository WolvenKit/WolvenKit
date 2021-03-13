using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponVariations : audioAudioMetadata
	{
		[Ordinal(1)] [RED("playerWeaponConfigurationName")] public CName PlayerWeaponConfigurationName { get; set; }
		[Ordinal(2)] [RED("NPCWeaponConfigurationName")] public CName NPCWeaponConfigurationName { get; set; }

		public audioMeleeWeaponVariations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
