using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetKeepStrategyOnSearch : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("keep")] 
		public CHandle<AIArgumentMapping> Keep
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public SetKeepStrategyOnSearch()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
