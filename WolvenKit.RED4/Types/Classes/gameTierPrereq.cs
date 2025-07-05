using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTierPrereq : gameIComparisonPrereq
	{
		[Ordinal(1)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		public gameTierPrereq()
		{
			Tier = Enums.GameplayTier.Tier1_FullGameplay;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
