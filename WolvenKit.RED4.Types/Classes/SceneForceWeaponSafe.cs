using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneForceWeaponSafe : redEvent
	{
		[Ordinal(0)] 
		[RED("weaponLoweringSpeedOverride")] 
		public CFloat WeaponLoweringSpeedOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
