using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSBehaviorConstraintNodeFloorIKCommonData : RedBaseClass
	{
		private animTransformIndex _gravityCentreBone;
		private CFloat _rootRotationBlendTime;
		private CFloat _verticalVelocityOffsetUpBlendTime;
		private CFloat _verticalVelocityOffsetDownBlendTime;
		private CFloat _slidingOnSlopeBlendTime;

		[Ordinal(0)] 
		[RED("gravityCentreBone")] 
		public animTransformIndex GravityCentreBone
		{
			get => GetProperty(ref _gravityCentreBone);
			set => SetProperty(ref _gravityCentreBone, value);
		}

		[Ordinal(1)] 
		[RED("rootRotationBlendTime")] 
		public CFloat RootRotationBlendTime
		{
			get => GetProperty(ref _rootRotationBlendTime);
			set => SetProperty(ref _rootRotationBlendTime, value);
		}

		[Ordinal(2)] 
		[RED("verticalVelocityOffsetUpBlendTime")] 
		public CFloat VerticalVelocityOffsetUpBlendTime
		{
			get => GetProperty(ref _verticalVelocityOffsetUpBlendTime);
			set => SetProperty(ref _verticalVelocityOffsetUpBlendTime, value);
		}

		[Ordinal(3)] 
		[RED("verticalVelocityOffsetDownBlendTime")] 
		public CFloat VerticalVelocityOffsetDownBlendTime
		{
			get => GetProperty(ref _verticalVelocityOffsetDownBlendTime);
			set => SetProperty(ref _verticalVelocityOffsetDownBlendTime, value);
		}

		[Ordinal(4)] 
		[RED("slidingOnSlopeBlendTime")] 
		public CFloat SlidingOnSlopeBlendTime
		{
			get => GetProperty(ref _slidingOnSlopeBlendTime);
			set => SetProperty(ref _slidingOnSlopeBlendTime, value);
		}
	}
}
