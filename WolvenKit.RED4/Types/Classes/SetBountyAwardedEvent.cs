using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetBountyAwardedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("awarded")] 
		public CBool Awarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetBountyAwardedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
