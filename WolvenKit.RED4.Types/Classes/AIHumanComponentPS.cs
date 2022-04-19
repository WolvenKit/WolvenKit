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
			SpotUsageToken = new() { UsedSpotId = new(), SpotUserId = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
