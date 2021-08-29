using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_Move : gameTransformAnimationTrackItemImpl
	{
		private CHandle<gameTransformAnimation_Position> _startPositionEvaluator;
		private CHandle<gameTransformAnimation_Position> _targetPositionEvaluator;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("startPositionEvaluator")] 
		public CHandle<gameTransformAnimation_Position> StartPositionEvaluator
		{
			get => GetProperty(ref _startPositionEvaluator);
			set => SetProperty(ref _startPositionEvaluator, value);
		}

		[Ordinal(1)] 
		[RED("targetPositionEvaluator")] 
		public CHandle<gameTransformAnimation_Position> TargetPositionEvaluator
		{
			get => GetProperty(ref _targetPositionEvaluator);
			set => SetProperty(ref _targetPositionEvaluator, value);
		}

		[Ordinal(2)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetProperty(ref _movement);
			set => SetProperty(ref _movement, value);
		}
	}
}
