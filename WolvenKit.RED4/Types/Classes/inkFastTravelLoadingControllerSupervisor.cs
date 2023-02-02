using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkFastTravelLoadingControllerSupervisor : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("glitchEffect")] 
		public CResourceReference<worldEffect> GlitchEffect
		{
			get => GetPropertyValue<CResourceReference<worldEffect>>();
			set => SetPropertyValue<CResourceReference<worldEffect>>(value);
		}

		public inkFastTravelLoadingControllerSupervisor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
