using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LocomotionAdjuster : animAnimNode_OnePoseInput
	{
		private animVectorLink _targetPosition;
		private animVectorLink _targetDirection;
		private Vector4 _initialForwardVector;
		private CFloat _blendSpeedPos;
		private CFloat _blendSpeedPosMin;
		private CFloat _blendSpeedRot;
		private CFloat _maxDistance;

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
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get => GetProperty(ref _initialForwardVector);
			set => SetProperty(ref _initialForwardVector, value);
		}

		[Ordinal(15)] 
		[RED("blendSpeedPos")] 
		public CFloat BlendSpeedPos
		{
			get => GetProperty(ref _blendSpeedPos);
			set => SetProperty(ref _blendSpeedPos, value);
		}

		[Ordinal(16)] 
		[RED("blendSpeedPosMin")] 
		public CFloat BlendSpeedPosMin
		{
			get => GetProperty(ref _blendSpeedPosMin);
			set => SetProperty(ref _blendSpeedPosMin, value);
		}

		[Ordinal(17)] 
		[RED("blendSpeedRot")] 
		public CFloat BlendSpeedRot
		{
			get => GetProperty(ref _blendSpeedRot);
			set => SetProperty(ref _blendSpeedRot, value);
		}

		[Ordinal(18)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		public animAnimNode_LocomotionAdjuster()
		{
			_blendSpeedPos = 8.000000F;
			_blendSpeedPosMin = 2.000000F;
			_blendSpeedRot = 180.000000F;
			_maxDistance = 1.000000F;
		}
	}
}
