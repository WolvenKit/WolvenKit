using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootObject : gameObject
	{
		[Ordinal(40)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(41)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
