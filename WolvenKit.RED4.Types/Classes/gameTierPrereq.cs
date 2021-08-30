using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTierPrereq : gameIComparisonPrereq
	{
		private CEnum<GameplayTier> _tier;

		[Ordinal(1)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		public gameTierPrereq()
		{
			_tier = new() { Value = Enums.GameplayTier.Tier1_FullGameplay };
		}
	}
}
