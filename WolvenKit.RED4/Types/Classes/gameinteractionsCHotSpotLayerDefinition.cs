using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCHotSpotLayerDefinition : gameinteractionsNodeDefinition
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("group")] 
		public CEnum<gameinteractionsEGroupType> Group
		{
			get => GetPropertyValue<CEnum<gameinteractionsEGroupType>>();
			set => SetPropertyValue<CEnum<gameinteractionsEGroupType>>(value);
		}

		[Ordinal(3)] 
		[RED("priorityMultiplier")] 
		public CFloat PriorityMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("areaFilterDefinition")] 
		public CHandle<gameinteractionsCHotSpotAreaFilterDefinition> AreaFilterDefinition
		{
			get => GetPropertyValue<CHandle<gameinteractionsCHotSpotAreaFilterDefinition>>();
			set => SetPropertyValue<CHandle<gameinteractionsCHotSpotAreaFilterDefinition>>(value);
		}

		[Ordinal(5)] 
		[RED("gameLogicFilterDefinition")] 
		public CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> GameLogicFilterDefinition
		{
			get => GetPropertyValue<CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition>>();
			set => SetPropertyValue<CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition>>(value);
		}

		public gameinteractionsCHotSpotLayerDefinition()
		{
			PriorityMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
