using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetBountyEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bountyID")] 
		public TweakDBID BountyID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SetBountyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
