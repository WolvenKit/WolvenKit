using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneForceWeaponSafe : redEvent
	{
		private CFloat _weaponLoweringSpeedOverride;

		[Ordinal(0)] 
		[RED("weaponLoweringSpeedOverride")] 
		public CFloat WeaponLoweringSpeedOverride
		{
			get => GetProperty(ref _weaponLoweringSpeedOverride);
			set => SetProperty(ref _weaponLoweringSpeedOverride, value);
		}
	}
}
