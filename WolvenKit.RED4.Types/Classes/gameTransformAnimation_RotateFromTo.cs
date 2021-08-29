using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_RotateFromTo : gameTransformAnimationTrackItemImpl
	{
		private CHandle<gameTransformAnimation_Rotation> _startRotationEvaluator;
		private CHandle<gameTransformAnimation_Rotation> _targetRotationEvaluator;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("startRotationEvaluator")] 
		public CHandle<gameTransformAnimation_Rotation> StartRotationEvaluator
		{
			get => GetProperty(ref _startRotationEvaluator);
			set => SetProperty(ref _startRotationEvaluator, value);
		}

		[Ordinal(1)] 
		[RED("targetRotationEvaluator")] 
		public CHandle<gameTransformAnimation_Rotation> TargetRotationEvaluator
		{
			get => GetProperty(ref _targetRotationEvaluator);
			set => SetProperty(ref _targetRotationEvaluator, value);
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
