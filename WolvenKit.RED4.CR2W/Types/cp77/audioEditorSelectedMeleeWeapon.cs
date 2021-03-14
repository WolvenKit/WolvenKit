using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEditorSelectedMeleeWeapon : audioAudioMetadata
	{
		[Ordinal(1)] [RED("selectedWeaponConfigurationName")] public CName SelectedWeaponConfigurationName { get; set; }

		public audioEditorSelectedMeleeWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
