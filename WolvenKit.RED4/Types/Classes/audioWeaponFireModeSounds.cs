using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWeaponFireModeSounds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("burst")] 
		public CName Burst
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("charge")] 
		public CName Charge
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("fullAuto")] 
		public CName FullAuto
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("semiAuto")] 
		public CName SemiAuto
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("windup")] 
		public CName Windup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioWeaponFireModeSounds()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
