using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIVehicleAgent : AICAgent
	{
		[Ordinal(4)] 
		[RED("keepStrategyOnSearch")] 
		public CBool KeepStrategyOnSearch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("initCmd")] 
		public CHandle<AIVehicleCommand> InitCmd
		{
			get => GetPropertyValue<CHandle<AIVehicleCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleCommand>>(value);
		}

		public AIVehicleAgent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
