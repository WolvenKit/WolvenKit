using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGuardAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("communityEntries")] 
		public CArray<AIGuardAreaConnectedCommunity> CommunityEntries
		{
			get => GetPropertyValue<CArray<AIGuardAreaConnectedCommunity>>();
			set => SetPropertyValue<CArray<AIGuardAreaConnectedCommunity>>(value);
		}

		[Ordinal(7)] 
		[RED("combatCommunityEntries")] 
		public CArray<AICombatGuardAreaConnectedCommunity> CombatCommunityEntries
		{
			get => GetPropertyValue<CArray<AICombatGuardAreaConnectedCommunity>>();
			set => SetPropertyValue<CArray<AICombatGuardAreaConnectedCommunity>>(value);
		}

		[Ordinal(8)] 
		[RED("pursuitArea")] 
		public NodeRef PursuitArea
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(9)] 
		[RED("pursuitRange")] 
		public CFloat PursuitRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldGuardAreaNode()
		{
			CommunityEntries = new();
			CombatCommunityEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
