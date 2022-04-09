using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetTier_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(1)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("forceEmptyHands")] 
		public CBool ForceEmptyHands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("motionConstrainedTierDataParams")] 
		public gameMotionConstrainedTierDataParams MotionConstrainedTierDataParams
		{
			get => GetPropertyValue<gameMotionConstrainedTierDataParams>();
			set => SetPropertyValue<gameMotionConstrainedTierDataParams>(value);
		}

		public questSetTier_NodeType()
		{
			Tier = Enums.GameplayTier.Tier1_FullGameplay;
			ForceEmptyHands = true;
			MotionConstrainedTierDataParams = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
