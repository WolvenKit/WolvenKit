using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WeaponHandlingStats : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("weaponRecoil")] 
		public CFloat WeaponRecoil
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("weaponSpread")] 
		public CFloat WeaponSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_WeaponHandlingStats()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
