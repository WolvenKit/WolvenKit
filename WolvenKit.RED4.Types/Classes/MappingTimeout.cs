using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MappingTimeout : AITimeoutCondition
	{
		[Ordinal(1)] 
		[RED("timeoutMapping")] 
		public CHandle<AIArgumentMapping> TimeoutMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MappingTimeout()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
