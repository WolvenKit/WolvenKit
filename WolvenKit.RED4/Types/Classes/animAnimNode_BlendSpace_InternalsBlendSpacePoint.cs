using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendSpace_InternalsBlendSpacePoint : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("useFixedCoordinates")] 
		public CBool UseFixedCoordinates
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("fixedCoordinates")] 
		public CArray<CFloat> FixedCoordinates
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("useStaticPose")] 
		public CBool UseStaticPose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("staticPoseTime")] 
		public CFloat StaticPoseTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("staticPoseProgress")] 
		public CFloat StaticPoseProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_BlendSpace_InternalsBlendSpacePoint()
		{
			UseFixedCoordinates = true;
			FixedCoordinates = new();
			StaticPoseProgress = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
