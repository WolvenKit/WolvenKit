using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponBlur : animAnimFeature
	{
		private CFloat _weaponNearPlane;
		private CFloat _weaponFarPlane;
		private CFloat _weaponEdgesSharpness;
		private CFloat _weaponVignetteIntensity;
		private CFloat _weaponVignetteRadius;
		private CFloat _weaponVignetteCircular;
		private CFloat _weaponBlurIntensity;
		private CFloat _weaponNearPlane_aim;
		private CFloat _weaponFarPlane_aim;
		private CFloat _weaponEdgesSharpness_aim;
		private CFloat _weaponVignetteIntensity_aim;
		private CFloat _weaponVignetteRadius_aim;
		private CFloat _weaponVignetteCircular_aim;
		private CFloat _weaponBlurIntensity_aim;

		[Ordinal(0)] 
		[RED("weaponNearPlane")] 
		public CFloat WeaponNearPlane
		{
			get => GetProperty(ref _weaponNearPlane);
			set => SetProperty(ref _weaponNearPlane, value);
		}

		[Ordinal(1)] 
		[RED("weaponFarPlane")] 
		public CFloat WeaponFarPlane
		{
			get => GetProperty(ref _weaponFarPlane);
			set => SetProperty(ref _weaponFarPlane, value);
		}

		[Ordinal(2)] 
		[RED("weaponEdgesSharpness")] 
		public CFloat WeaponEdgesSharpness
		{
			get => GetProperty(ref _weaponEdgesSharpness);
			set => SetProperty(ref _weaponEdgesSharpness, value);
		}

		[Ordinal(3)] 
		[RED("weaponVignetteIntensity")] 
		public CFloat WeaponVignetteIntensity
		{
			get => GetProperty(ref _weaponVignetteIntensity);
			set => SetProperty(ref _weaponVignetteIntensity, value);
		}

		[Ordinal(4)] 
		[RED("weaponVignetteRadius")] 
		public CFloat WeaponVignetteRadius
		{
			get => GetProperty(ref _weaponVignetteRadius);
			set => SetProperty(ref _weaponVignetteRadius, value);
		}

		[Ordinal(5)] 
		[RED("weaponVignetteCircular")] 
		public CFloat WeaponVignetteCircular
		{
			get => GetProperty(ref _weaponVignetteCircular);
			set => SetProperty(ref _weaponVignetteCircular, value);
		}

		[Ordinal(6)] 
		[RED("weaponBlurIntensity")] 
		public CFloat WeaponBlurIntensity
		{
			get => GetProperty(ref _weaponBlurIntensity);
			set => SetProperty(ref _weaponBlurIntensity, value);
		}

		[Ordinal(7)] 
		[RED("weaponNearPlane_aim")] 
		public CFloat WeaponNearPlane_aim
		{
			get => GetProperty(ref _weaponNearPlane_aim);
			set => SetProperty(ref _weaponNearPlane_aim, value);
		}

		[Ordinal(8)] 
		[RED("weaponFarPlane_aim")] 
		public CFloat WeaponFarPlane_aim
		{
			get => GetProperty(ref _weaponFarPlane_aim);
			set => SetProperty(ref _weaponFarPlane_aim, value);
		}

		[Ordinal(9)] 
		[RED("weaponEdgesSharpness_aim")] 
		public CFloat WeaponEdgesSharpness_aim
		{
			get => GetProperty(ref _weaponEdgesSharpness_aim);
			set => SetProperty(ref _weaponEdgesSharpness_aim, value);
		}

		[Ordinal(10)] 
		[RED("weaponVignetteIntensity_aim")] 
		public CFloat WeaponVignetteIntensity_aim
		{
			get => GetProperty(ref _weaponVignetteIntensity_aim);
			set => SetProperty(ref _weaponVignetteIntensity_aim, value);
		}

		[Ordinal(11)] 
		[RED("weaponVignetteRadius_aim")] 
		public CFloat WeaponVignetteRadius_aim
		{
			get => GetProperty(ref _weaponVignetteRadius_aim);
			set => SetProperty(ref _weaponVignetteRadius_aim, value);
		}

		[Ordinal(12)] 
		[RED("weaponVignetteCircular_aim")] 
		public CFloat WeaponVignetteCircular_aim
		{
			get => GetProperty(ref _weaponVignetteCircular_aim);
			set => SetProperty(ref _weaponVignetteCircular_aim, value);
		}

		[Ordinal(13)] 
		[RED("weaponBlurIntensity_aim")] 
		public CFloat WeaponBlurIntensity_aim
		{
			get => GetProperty(ref _weaponBlurIntensity_aim);
			set => SetProperty(ref _weaponBlurIntensity_aim, value);
		}

		public AnimFeature_WeaponBlur(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
