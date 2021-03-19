using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWeaponPlaneParams : CVariable
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

		public SWeaponPlaneParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
