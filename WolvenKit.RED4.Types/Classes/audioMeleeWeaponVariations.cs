using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeWeaponVariations : audioAudioMetadata
	{
		private CName _playerWeaponConfigurationName;
		private CName _nPCWeaponConfigurationName;

		[Ordinal(1)] 
		[RED("playerWeaponConfigurationName")] 
		public CName PlayerWeaponConfigurationName
		{
			get => GetProperty(ref _playerWeaponConfigurationName);
			set => SetProperty(ref _playerWeaponConfigurationName, value);
		}

		[Ordinal(2)] 
		[RED("NPCWeaponConfigurationName")] 
		public CName NPCWeaponConfigurationName
		{
			get => GetProperty(ref _nPCWeaponConfigurationName);
			set => SetProperty(ref _nPCWeaponConfigurationName, value);
		}
	}
}
