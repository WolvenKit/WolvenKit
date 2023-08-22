using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkDisplayTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("root")] 
		public inkWidgetReference Root_16
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("perkNameText")] 
		public inkTextWidgetReference PerkNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("videoWrapper")] 
		public inkWidgetReference VideoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("unlockStateText")] 
		public inkTextWidgetReference UnlockStateText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("perkTypeText")] 
		public inkTextWidgetReference PerkTypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("perkTypeWrapper")] 
		public inkWidgetReference PerkTypeWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("unlockInfoWrapper")] 
		public inkWidgetReference UnlockInfoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("unlockPointsText")] 
		public inkTextWidgetReference UnlockPointsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("unlockPointsDesc")] 
		public inkTextWidgetReference UnlockPointsDesc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("unlockPerkWrapper")] 
		public inkWidgetReference UnlockPerkWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("levelDescriptionText")] 
		public inkTextWidgetReference LevelDescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("nextLevelWrapper")] 
		public inkWidgetReference NextLevelWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("nextLevelText")] 
		public inkTextWidgetReference NextLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("nextLevelDescriptionText")] 
		public inkTextWidgetReference NextLevelDescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("traitLevelGrowthText")] 
		public inkTextWidgetReference TraitLevelGrowthText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("unlockTraitPointsText")] 
		public inkTextWidgetReference UnlockTraitPointsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("unlockTraitWrapper")] 
		public inkWidgetReference UnlockTraitWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("holdToUpgradeHint")] 
		public inkWidgetReference HoldToUpgradeHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("data")] 
		public CHandle<BasePerksMenuTooltipData> Data
		{
			get => GetPropertyValue<CHandle<BasePerksMenuTooltipData>>();
			set => SetPropertyValue<CHandle<BasePerksMenuTooltipData>>(value);
		}

		public PerkDisplayTooltipController()
		{
			Root_16 = new inkWidgetReference();
			PerkNameText = new inkTextWidgetReference();
			VideoWrapper = new inkWidgetReference();
			VideoWidget = new inkVideoWidgetReference();
			UnlockStateText = new inkTextWidgetReference();
			PerkTypeText = new inkTextWidgetReference();
			PerkTypeWrapper = new inkWidgetReference();
			UnlockInfoWrapper = new inkWidgetReference();
			UnlockPointsText = new inkTextWidgetReference();
			UnlockPointsDesc = new inkTextWidgetReference();
			UnlockPerkWrapper = new inkWidgetReference();
			LevelText = new inkTextWidgetReference();
			LevelDescriptionText = new inkTextWidgetReference();
			NextLevelWrapper = new inkWidgetReference();
			NextLevelText = new inkTextWidgetReference();
			NextLevelDescriptionText = new inkTextWidgetReference();
			TraitLevelGrowthText = new inkTextWidgetReference();
			UnlockTraitPointsText = new inkTextWidgetReference();
			UnlockTraitWrapper = new inkWidgetReference();
			HoldToUpgradeHint = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
