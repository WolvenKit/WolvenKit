using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WeaponBlur : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("weaponNearPlane")] 
		public CFloat WeaponNearPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("weaponFarPlane")] 
		public CFloat WeaponFarPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("weaponEdgesSharpness")] 
		public CFloat WeaponEdgesSharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("weaponVignetteIntensity")] 
		public CFloat WeaponVignetteIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("weaponVignetteRadius")] 
		public CFloat WeaponVignetteRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("weaponVignetteCircular")] 
		public CFloat WeaponVignetteCircular
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("weaponBlurIntensity")] 
		public CFloat WeaponBlurIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("weaponNearPlane_aim")] 
		public CFloat WeaponNearPlane_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("weaponFarPlane_aim")] 
		public CFloat WeaponFarPlane_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("weaponEdgesSharpness_aim")] 
		public CFloat WeaponEdgesSharpness_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("weaponVignetteIntensity_aim")] 
		public CFloat WeaponVignetteIntensity_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("weaponVignetteRadius_aim")] 
		public CFloat WeaponVignetteRadius_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("weaponVignetteCircular_aim")] 
		public CFloat WeaponVignetteCircular_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("weaponBlurIntensity_aim")] 
		public CFloat WeaponBlurIntensity_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_WeaponBlur()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
