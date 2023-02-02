using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeRigTypeMeleeWeaponConfigurationMapItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("meleeWeaponConfiguration")] 
		public CName MeleeWeaponConfiguration
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioMeleeRigTypeMeleeWeaponConfigurationMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
