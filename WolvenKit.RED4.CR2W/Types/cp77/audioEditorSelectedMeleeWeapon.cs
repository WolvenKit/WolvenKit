using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEditorSelectedMeleeWeapon : audioAudioMetadata
	{
		private CName _selectedWeaponConfigurationName;

		[Ordinal(1)] 
		[RED("selectedWeaponConfigurationName")] 
		public CName SelectedWeaponConfigurationName
		{
			get => GetProperty(ref _selectedWeaponConfigurationName);
			set => SetProperty(ref _selectedWeaponConfigurationName, value);
		}

		public audioEditorSelectedMeleeWeapon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
