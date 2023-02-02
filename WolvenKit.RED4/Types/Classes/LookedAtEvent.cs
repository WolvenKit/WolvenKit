using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LookedAtEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LookedAtEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
