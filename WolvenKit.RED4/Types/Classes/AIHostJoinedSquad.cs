using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIHostJoinedSquad : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("squad")] 
		public CName Squad
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIHostJoinedSquad()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
