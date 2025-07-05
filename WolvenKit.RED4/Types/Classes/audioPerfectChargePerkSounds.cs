using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPerfectChargePerkSounds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("perfectChargeChargingSound")] 
		public CName PerfectChargeChargingSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("perfectChargeChargedSound")] 
		public CName PerfectChargeChargedSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("perfectChargeShootingSound")] 
		public CName PerfectChargeShootingSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioPerfectChargePerkSounds()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
