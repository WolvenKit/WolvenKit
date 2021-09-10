using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeRigTypeMeleeWeaponConfigurationMap : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mapItems")] 
		public CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> MapItems
		{
			get => GetPropertyValue<CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem>>();
			set => SetPropertyValue<CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem>>(value);
		}

		public audioMeleeRigTypeMeleeWeaponConfigurationMap()
		{
			MapItems = new();
		}
	}
}
