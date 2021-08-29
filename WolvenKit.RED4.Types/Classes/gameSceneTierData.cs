using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSceneTierData : IScriptable
	{
		private CEnum<GameplayTier> _tier;
		private CBool _emptyHands;

		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(1)] 
		[RED("emptyHands")] 
		public CBool EmptyHands
		{
			get => GetProperty(ref _emptyHands);
			set => SetProperty(ref _emptyHands, value);
		}
	}
}
