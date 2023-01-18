using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSceneTier_ConditionType : questISceneConditionType
	{
		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(1)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSceneTier_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
