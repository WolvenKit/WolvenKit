using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckCurrentHitReaction : HitConditions
	{
		[Ordinal(0)] 
		[RED("HitReactionTypeToCompare")] 
		public CEnum<animHitReactionType> HitReactionTypeToCompare
		{
			get => GetPropertyValue<CEnum<animHitReactionType>>();
			set => SetPropertyValue<CEnum<animHitReactionType>>(value);
		}

		[Ordinal(1)] 
		[RED("CustomStimNameToCompare")] 
		public CName CustomStimNameToCompare
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("shouldCheckDeathStimName")] 
		public CBool ShouldCheckDeathStimName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CheckCurrentHitReaction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
