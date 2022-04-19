using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeAttackSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CName HitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("penetratingHitEvent")] 
		public CName PenetratingHitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("criticalHitEvent")] 
		public CName CriticalHitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("killingHitEvent")] 
		public CName KillingHitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioMeleeAttackSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
