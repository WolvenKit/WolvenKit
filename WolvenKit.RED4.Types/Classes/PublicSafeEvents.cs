using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PublicSafeEvents : WeaponEventsTransition
	{
		private CBool _weaponUnequipRequestSent;

		[Ordinal(3)] 
		[RED("weaponUnequipRequestSent")] 
		public CBool WeaponUnequipRequestSent
		{
			get => GetProperty(ref _weaponUnequipRequestSent);
			set => SetProperty(ref _weaponUnequipRequestSent, value);
		}
	}
}
