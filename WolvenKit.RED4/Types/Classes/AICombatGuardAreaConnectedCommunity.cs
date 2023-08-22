using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICombatGuardAreaConnectedCommunity : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("communityArea")] 
		public gameEntityReference CommunityArea
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<AIICombatGuardAreaCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<AIICombatGuardAreaCondition>>>();
			set => SetPropertyValue<CArray<CHandle<AIICombatGuardAreaCondition>>>(value);
		}

		public AICombatGuardAreaConnectedCommunity()
		{
			CommunityArea = new gameEntityReference { Names = new() };
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
