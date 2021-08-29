using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeRigTypeMeleeWeaponConfigurationMap : RedBaseClass
	{
		private CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> _mapItems;

		[Ordinal(0)] 
		[RED("mapItems")] 
		public CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> MapItems
		{
			get => GetProperty(ref _mapItems);
			set => SetProperty(ref _mapItems, value);
		}
	}
}
