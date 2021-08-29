using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeRigTypeMeleeWeaponConfigurationMapItem : RedBaseClass
	{
		private CName _name;
		private CName _meleeWeaponConfiguration;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("meleeWeaponConfiguration")] 
		public CName MeleeWeaponConfiguration
		{
			get => GetProperty(ref _meleeWeaponConfiguration);
			set => SetProperty(ref _meleeWeaponConfiguration, value);
		}
	}
}
