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
			get => GetProperty(ref _selectedWeaponConfigurationName);
			set => SetProperty(ref _selectedWeaponConfigurationName, value);
		}

		[Ordinal(2)] 
		[RED("selectedFootstepsEventName")] 
		public CName SelectedFootstepsEventName
		{
			get => GetProperty(ref _selectedFootstepsEventName);
			set => SetProperty(ref _selectedFootstepsEventName, value);
		}

		public audioEditorSelectedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
