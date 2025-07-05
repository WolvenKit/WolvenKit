using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckLastHitReaction : HitConditions
	{
		[Ordinal(0)] 
		[RED("hitReactionToCheck")] 
		public CEnum<animHitReactionType> HitReactionToCheck
		{
			get => GetPropertyValue<CEnum<animHitReactionType>>();
			set => SetPropertyValue<CEnum<animHitReactionType>>(value);
		}

		public CheckLastHitReaction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
