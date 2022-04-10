using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TCSInputYAxisEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TCSInputYAxisEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
