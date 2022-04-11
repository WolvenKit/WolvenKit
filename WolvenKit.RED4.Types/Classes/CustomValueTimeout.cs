using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomValueTimeout : AITimeoutCondition
	{
		[Ordinal(1)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CustomValueTimeout()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
