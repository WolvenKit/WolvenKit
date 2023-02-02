using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIGuardAreaConnectedCommunity : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("communityArea")] 
		public gameEntityReference CommunityArea
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPrimary")] 
		public CBool IsPrimary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIGuardAreaConnectedCommunity()
		{
			CommunityArea = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
