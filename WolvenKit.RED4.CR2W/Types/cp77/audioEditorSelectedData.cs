using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEditorSelectedData : audioAudioMetadata
	{
		private CName _selectedWeaponConfigurationName;
		private CName _selectedFootstepsEventName;

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

		[Ordinal(2)] 
		[RED("selectedFootstepsEventName")] 
		public CName SelectedFootstepsEventName
		{
			get
			{
				if (_selectedFootstepsEventName == null)
				{
					_selectedFootstepsEventName = (CName) CR2WTypeManager.Create("CName", "selectedFootstepsEventName", cr2w, this);
				}
				return _selectedFootstepsEventName;
			}
			set
			{
				if (_selectedFootstepsEventName == value)
				{
					return;
				}
				_selectedFootstepsEventName = value;
				PropertySet(this);
			}
		}

		public audioEditorSelectedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
