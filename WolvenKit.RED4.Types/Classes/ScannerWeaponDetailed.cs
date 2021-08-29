using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerWeaponDetailed : ScannerWeaponBasic
	{
		private CName _damage;

		[Ordinal(1)] 
		[RED("damage")] 
		public CName Damage
		{
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}
	}
}
