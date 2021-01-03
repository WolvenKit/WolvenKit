using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponVariations : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("NPCWeaponConfigurationName")] public CName NPCWeaponConfigurationName { get; set; }
		[Ordinal(1)]  [RED("playerWeaponConfigurationName")] public CName PlayerWeaponConfigurationName { get; set; }

		public audioMeleeWeaponVariations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
