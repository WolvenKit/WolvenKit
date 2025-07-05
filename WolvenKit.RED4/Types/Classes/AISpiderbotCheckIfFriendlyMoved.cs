using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISpiderbotCheckIfFriendlyMoved : AIAutonomousConditions
	{
		[Ordinal(0)] 
		[RED("maxAllowedDelta")] 
		public CHandle<AIArgumentMapping> MaxAllowedDelta
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AISpiderbotCheckIfFriendlyMoved()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
