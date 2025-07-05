using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SandevistanEvents : TimeDilationEventsTransitions
	{
		[Ordinal(0)] 
		[RED("lastTimeDilation")] 
		public CFloat LastTimeDilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SandevistanEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
