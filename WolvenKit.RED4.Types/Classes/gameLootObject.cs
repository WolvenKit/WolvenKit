using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootObject : gameObject
	{
		private TweakDBID _lootID;
		private CBool _isInIconForcedVisibilityRange;
		private CName _activeQualityRangeInteraction;

		[Ordinal(40)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetProperty(ref _lootID);
			set => SetProperty(ref _lootID, value);
		}

		[Ordinal(41)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetProperty(ref _isInIconForcedVisibilityRange);
			set => SetProperty(ref _isInIconForcedVisibilityRange, value);
		}

		[Ordinal(42)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetProperty(ref _activeQualityRangeInteraction);
			set => SetProperty(ref _activeQualityRangeInteraction, value);
		}
	}
}
