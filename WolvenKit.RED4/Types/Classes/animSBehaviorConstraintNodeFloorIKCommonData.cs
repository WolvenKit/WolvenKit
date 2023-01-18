using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSBehaviorConstraintNodeFloorIKCommonData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("gravityCentreBone")] 
		public animTransformIndex GravityCentreBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("rootRotationBlendTime")] 
		public CFloat RootRotationBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("verticalVelocityOffsetUpBlendTime")] 
		public CFloat VerticalVelocityOffsetUpBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("verticalVelocityOffsetDownBlendTime")] 
		public CFloat VerticalVelocityOffsetDownBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("slidingOnSlopeBlendTime")] 
		public CFloat SlidingOnSlopeBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animSBehaviorConstraintNodeFloorIKCommonData()
		{
			GravityCentreBone = new();
			RootRotationBlendTime = 0.200000F;
			VerticalVelocityOffsetUpBlendTime = 0.080000F;
			VerticalVelocityOffsetDownBlendTime = 0.030000F;
			SlidingOnSlopeBlendTime = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
