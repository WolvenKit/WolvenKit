using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKCommonData : CVariable
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

		public animSBehaviorConstraintNodeFloorIKCommonData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
