using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_WeaponHandlingStats : animAnimFeature
	{
		private CFloat _weaponRecoil;
		private CFloat _weaponSpread;

		[Ordinal(0)] 
		[RED("weaponRecoil")] 
		public CFloat WeaponRecoil
		{
			get => GetProperty(ref _weaponRecoil);
			set => SetProperty(ref _weaponRecoil, value);
		}

		[Ordinal(1)] 
		[RED("weaponSpread")] 
		public CFloat WeaponSpread
		{
			get => GetProperty(ref _weaponSpread);
			set => SetProperty(ref _weaponSpread, value);
		}
	}
}
