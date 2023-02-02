using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendingMachineSFX : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("glitchingStart")] 
		public CName GlitchingStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("glitchingStop")] 
		public CName GlitchingStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public VendingMachineSFX()
		{
			GlitchingStart = "amb_int_custom_megabuilding_01_adverts_interactive_nicola_01_select_q110";
			GlitchingStop = "amb_int_custom_megabuilding_01_adverts_interactive_nicola_01_select_q110_stop";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
