using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SWeaponPlaneParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weaponNearPlaneCM")] 
		public CFloat WeaponNearPlaneCM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("blurIntensity")] 
		public CFloat BlurIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SWeaponPlaneParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
