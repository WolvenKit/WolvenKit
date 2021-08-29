using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsCHotSpotLayerDefinition : gameinteractionsNodeDefinition
	{
		private CBool _enabled;
		private CName _tag;
		private CEnum<gameinteractionsEGroupType> _group;
		private CFloat _priorityMultiplier;
		private CHandle<gameinteractionsCHotSpotAreaFilterDefinition> _areaFilterDefinition;
		private CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> _gameLogicFilterDefinition;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(2)] 
		[RED("group")] 
		public CEnum<gameinteractionsEGroupType> Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(3)] 
		[RED("priorityMultiplier")] 
		public CFloat PriorityMultiplier
		{
			get => GetProperty(ref _priorityMultiplier);
			set => SetProperty(ref _priorityMultiplier, value);
		}

		[Ordinal(4)] 
		[RED("areaFilterDefinition")] 
		public CHandle<gameinteractionsCHotSpotAreaFilterDefinition> AreaFilterDefinition
		{
			get => GetProperty(ref _areaFilterDefinition);
			set => SetProperty(ref _areaFilterDefinition, value);
		}

		[Ordinal(5)] 
		[RED("gameLogicFilterDefinition")] 
		public CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> GameLogicFilterDefinition
		{
			get => GetProperty(ref _gameLogicFilterDefinition);
			set => SetProperty(ref _gameLogicFilterDefinition, value);
		}
	}
}
