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
			get
			{
				if (_selectedWeaponConfigurationName == null)
				{
					_selectedWeaponConfigurationName = (CName) CR2WTypeManager.Create("CName", "selectedWeaponConfigurationName", cr2w, this);
				}
				return _selectedWeaponConfigurationName;
			}
			set
			{
				if (_selectedWeaponConfigurationName == value)
				{
					return;
				}
				_selectedWeaponConfigurationName = value;
				PropertySet(this);
			}
		}

		public audioEditorSelectedMeleeWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
