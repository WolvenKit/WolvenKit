using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGuardAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("communityEntries")] 
		public CArray<AIGuardAreaConnectedCommunity> CommunityEntries
		{
			get => GetPropertyValue<CArray<AIGuardAreaConnectedCommunity>>();
			set => SetPropertyValue<CArray<AIGuardAreaConnectedCommunity>>(value);
		}

		[Ordinal(5)] 
		[RED("combatCommunityEntries")] 
		public CArray<AICombatGuardAreaConnectedCommunity> CombatCommunityEntries
		{
			get => GetPropertyValue<CArray<AICombatGuardAreaConnectedCommunity>>();
			set => SetPropertyValue<CArray<AICombatGuardAreaConnectedCommunity>>(value);
		}

		[Ordinal(6)] 
		[RED("pursuitArea")] 
		public NodeRef PursuitArea
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(7)] 
		[RED("pursuitRange")] 
		public CFloat PursuitRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldGuardAreaNode()
		{
			Color = new CColor { Red = 255, Green = 127, Blue = 255, Alpha = 128 };
			CommunityEntries = new();
			CombatCommunityEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
