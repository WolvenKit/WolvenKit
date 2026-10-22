using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIHumanComponentPS : AICommandQueuePS
	{
		[Ordinal(2)] 
		[RED("spotUsageToken")] 
		public AISpotUsageToken SpotUsageToken
		{
			get => GetPropertyValue<AISpotUsageToken>();
			set => SetPropertyValue<AISpotUsageToken>(value);
		}

		public AIHumanComponentPS()
		{
			SpotUsageToken = new AISpotUsageToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
