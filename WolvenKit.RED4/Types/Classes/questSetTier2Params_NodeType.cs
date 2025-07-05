using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetTier2Params_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("playerWalkType")] 
		public CEnum<Tier2WalkType> PlayerWalkType
		{
			get => GetPropertyValue<CEnum<Tier2WalkType>>();
			set => SetPropertyValue<CEnum<Tier2WalkType>>(value);
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

		public questSetTier2Params_NodeType()
		{
			PlayerWalkType = Enums.Tier2WalkType.Normal;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
