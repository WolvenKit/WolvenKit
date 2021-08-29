using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_MotionAdjuster : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animVectorLink _targetPosition;
		private animVectorLink _targetDirection;
		private animFloatLink _totalTimeToAdjust;
		private Vector4 _forwardVector;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(12)] 
		[RED("targetPosition")] 
		public animVectorLink TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(13)] 
		[RED("targetDirection")] 
		public animVectorLink TargetDirection
		{
			get => GetProperty(ref _targetDirection);
			set => SetProperty(ref _targetDirection, value);
		}

		[Ordinal(14)] 
		[RED("totalTimeToAdjust")] 
		public animFloatLink TotalTimeToAdjust
		{
			get => GetProperty(ref _totalTimeToAdjust);
			set => SetProperty(ref _totalTimeToAdjust, value);
		}

		[Ordinal(15)] 
		[RED("forwardVector")] 
		public Vector4 ForwardVector
		{
			get => GetProperty(ref _forwardVector);
			set => SetProperty(ref _forwardVector, value);
		}
	}
}
