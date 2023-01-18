using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReflectorSFX : VendingMachineSFX
	{
		[Ordinal(2)] 
		[RED("distraction")] 
		public CName Distraction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("turnOn")] 
		public CName TurnOn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("turnOff")] 
		public CName TurnOff
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ReflectorSFX()
		{
			Distraction = "dev_reflector_distraction";
			TurnOn = "dev_reflector_turn_on_loop";
			TurnOff = "dev_reflector_turn_on_loop_stop";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
