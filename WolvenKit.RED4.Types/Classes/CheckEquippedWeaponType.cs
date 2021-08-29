using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckEquippedWeaponType : AIItemHandlingCondition
	{
		private CName _weaponTypeToCheck;

		[Ordinal(0)] 
		[RED("weaponTypeToCheck")] 
		public CName WeaponTypeToCheck
		{
			get => GetProperty(ref _weaponTypeToCheck);
			set => SetProperty(ref _weaponTypeToCheck, value);
		}
	}
}
