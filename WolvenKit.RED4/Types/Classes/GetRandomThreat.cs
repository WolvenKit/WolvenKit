using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GetRandomThreat : AIRandomTasks
	{
		[Ordinal(0)] 
		[RED("outThreatArgument")] 
		public CHandle<AIArgumentMapping> OutThreatArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public GetRandomThreat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
