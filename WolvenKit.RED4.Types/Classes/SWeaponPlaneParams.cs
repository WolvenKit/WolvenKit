using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SWeaponPlaneParams : RedBaseClass
	{
		private CFloat _weaponNearPlaneCM;
		private CFloat _blurIntensity;

		[Ordinal(0)] 
		[RED("weaponNearPlaneCM")] 
		public CFloat WeaponNearPlaneCM
		{
			get => GetProperty(ref _weaponNearPlaneCM);
			set => SetProperty(ref _weaponNearPlaneCM, value);
		}

		[Ordinal(1)] 
		[RED("blurIntensity")] 
		public CFloat BlurIntensity
		{
			get => GetProperty(ref _blurIntensity);
			set => SetProperty(ref _blurIntensity, value);
		}
	}
}
