using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectManagerComponent : AIMandatoryComponents
	{
		private CBool _weaponDropedInWounded;

		[Ordinal(5)] 
		[RED("weaponDropedInWounded")] 
		public CBool WeaponDropedInWounded
		{
			get => GetProperty(ref _weaponDropedInWounded);
			set => SetProperty(ref _weaponDropedInWounded, value);
		}
	}
}
