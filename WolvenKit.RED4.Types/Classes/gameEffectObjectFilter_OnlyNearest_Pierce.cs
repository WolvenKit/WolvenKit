using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_OnlyNearest_Pierce : gameEffectObjectFilter_OnlyNearest
	{
		private CBool _alwaysApplyFullWeaponCharge;

		[Ordinal(1)] 
		[RED("alwaysApplyFullWeaponCharge")] 
		public CBool AlwaysApplyFullWeaponCharge
		{
			get => GetProperty(ref _alwaysApplyFullWeaponCharge);
			set => SetProperty(ref _alwaysApplyFullWeaponCharge, value);
		}
	}
}
