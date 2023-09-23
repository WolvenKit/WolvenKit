using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponJammedAction : StatusEffectActions
	{
		[Ordinal(0)] 
		[RED("jammedWeaponDuration")] 
		public CFloat JammedWeaponDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("jammedWeaponStartTimeStamp")] 
		public CFloat JammedWeaponStartTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public WeaponJammedAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
