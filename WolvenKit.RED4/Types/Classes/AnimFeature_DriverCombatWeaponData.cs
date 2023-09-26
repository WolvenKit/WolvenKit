using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DriverCombatWeaponData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("weaponType")] 
		public CInt32 WeaponType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_DriverCombatWeaponData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
