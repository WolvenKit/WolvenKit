using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionSlideToWorldPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		private CHandle<AIArgumentMapping> _worldPosition;
		private CBool _useMovePlanner;

		[Ordinal(4)] 
		[RED("worldPosition")] 
		public CHandle<AIArgumentMapping> WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(5)] 
		[RED("useMovePlanner")] 
		public CBool UseMovePlanner
		{
			get => GetProperty(ref _useMovePlanner);
			set => SetProperty(ref _useMovePlanner, value);
		}

		public AIbehaviorActionSlideToWorldPositionNodeDefinition()
		{
			_useMovePlanner = true;
		}
	}
}
