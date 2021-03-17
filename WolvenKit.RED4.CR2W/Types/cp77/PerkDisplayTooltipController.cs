using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayTooltipController : AGenericTooltipController
	{
		private inkWidgetReference _root_16;
		private inkTextWidgetReference _perkNameText;
		private inkWidgetReference _videoWrapper;
		private inkVideoWidgetReference _videoWidget;
		private inkTextWidgetReference _unlockStateText;
		private inkTextWidgetReference _perkTypeText;
		private inkWidgetReference _perkTypeWrapper;
		private inkWidgetReference _unlockInfoWrapper;
		private inkTextWidgetReference _unlockPointsText;
		private inkTextWidgetReference _unlockPointsDesc;
		private inkWidgetReference _unlockPerkWrapper;
		private inkTextWidgetReference _levelText;
		private inkTextWidgetReference _levelDescriptionText;
		private inkWidgetReference _nextLevelWrapper;
		private inkTextWidgetReference _nextLevelText;
		private inkTextWidgetReference _nextLevelDescriptionText;
		private inkTextWidgetReference _traitLevelGrowthText;
		private inkTextWidgetReference _unlockTraitPointsText;
		private inkWidgetReference _unlockTraitWrapper;
		private inkWidgetReference _holdToUpgradeHint;
		private CHandle<BasePerksMenuTooltipData> _data;

		[Ordinal(2)] 
		[RED("root")] 
		public inkWidgetReference Root_16
		{
			get => GetProperty(ref _root_16);
			set => SetProperty(ref _root_16, value);
		}

		[Ordinal(3)] 
		[RED("perkNameText")] 
		public inkTextWidgetReference PerkNameText
		{
			get => GetProperty(ref _perkNameText);
			set => SetProperty(ref _perkNameText, value);
		}

		[Ordinal(4)] 
		[RED("videoWrapper")] 
		public inkWidgetReference VideoWrapper
		{
			get => GetProperty(ref _videoWrapper);
			set => SetProperty(ref _videoWrapper, value);
		}

		[Ordinal(5)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(6)] 
		[RED("unlockStateText")] 
		public inkTextWidgetReference UnlockStateText
		{
			get => GetProperty(ref _unlockStateText);
			set => SetProperty(ref _unlockStateText, value);
		}

		[Ordinal(7)] 
		[RED("perkTypeText")] 
		public inkTextWidgetReference PerkTypeText
		{
			get => GetProperty(ref _perkTypeText);
			set => SetProperty(ref _perkTypeText, value);
		}

		[Ordinal(8)] 
		[RED("perkTypeWrapper")] 
		public inkWidgetReference PerkTypeWrapper
		{
			get => GetProperty(ref _perkTypeWrapper);
			set => SetProperty(ref _perkTypeWrapper, value);
		}

		[Ordinal(9)] 
		[RED("unlockInfoWrapper")] 
		public inkWidgetReference UnlockInfoWrapper
		{
			get => GetProperty(ref _unlockInfoWrapper);
			set => SetProperty(ref _unlockInfoWrapper, value);
		}

		[Ordinal(10)] 
		[RED("unlockPointsText")] 
		public inkTextWidgetReference UnlockPointsText
		{
			get => GetProperty(ref _unlockPointsText);
			set => SetProperty(ref _unlockPointsText, value);
		}

		[Ordinal(11)] 
		[RED("unlockPointsDesc")] 
		public inkTextWidgetReference UnlockPointsDesc
		{
			get => GetProperty(ref _unlockPointsDesc);
			set => SetProperty(ref _unlockPointsDesc, value);
		}

		[Ordinal(12)] 
		[RED("unlockPerkWrapper")] 
		public inkWidgetReference UnlockPerkWrapper
		{
			get => GetProperty(ref _unlockPerkWrapper);
			set => SetProperty(ref _unlockPerkWrapper, value);
		}

		[Ordinal(13)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(14)] 
		[RED("levelDescriptionText")] 
		public inkTextWidgetReference LevelDescriptionText
		{
			get => GetProperty(ref _levelDescriptionText);
			set => SetProperty(ref _levelDescriptionText, value);
		}

		[Ordinal(15)] 
		[RED("nextLevelWrapper")] 
		public inkWidgetReference NextLevelWrapper
		{
			get => GetProperty(ref _nextLevelWrapper);
			set => SetProperty(ref _nextLevelWrapper, value);
		}

		[Ordinal(16)] 
		[RED("nextLevelText")] 
		public inkTextWidgetReference NextLevelText
		{
			get => GetProperty(ref _nextLevelText);
			set => SetProperty(ref _nextLevelText, value);
		}

		[Ordinal(17)] 
		[RED("nextLevelDescriptionText")] 
		public inkTextWidgetReference NextLevelDescriptionText
		{
			get => GetProperty(ref _nextLevelDescriptionText);
			set => SetProperty(ref _nextLevelDescriptionText, value);
		}

		[Ordinal(18)] 
		[RED("traitLevelGrowthText")] 
		public inkTextWidgetReference TraitLevelGrowthText
		{
			get => GetProperty(ref _traitLevelGrowthText);
			set => SetProperty(ref _traitLevelGrowthText, value);
		}

		[Ordinal(19)] 
		[RED("unlockTraitPointsText")] 
		public inkTextWidgetReference UnlockTraitPointsText
		{
			get => GetProperty(ref _unlockTraitPointsText);
			set => SetProperty(ref _unlockTraitPointsText, value);
		}

		[Ordinal(20)] 
		[RED("unlockTraitWrapper")] 
		public inkWidgetReference UnlockTraitWrapper
		{
			get => GetProperty(ref _unlockTraitWrapper);
			set => SetProperty(ref _unlockTraitWrapper, value);
		}

		[Ordinal(21)] 
		[RED("holdToUpgradeHint")] 
		public inkWidgetReference HoldToUpgradeHint
		{
			get => GetProperty(ref _holdToUpgradeHint);
			set => SetProperty(ref _holdToUpgradeHint, value);
		}

		[Ordinal(22)] 
		[RED("data")] 
		public CHandle<BasePerksMenuTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public PerkDisplayTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
