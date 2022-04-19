using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetBountyObjectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bounty")] 
		public Bounty Bounty
		{
			get => GetPropertyValue<Bounty>();
			set => SetPropertyValue<Bounty>(value);
		}

		public SetBountyObjectEvent()
		{
			Bounty = new() { Transgressions = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
