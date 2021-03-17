using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpacePoint : CVariable
	{
		private CName _animationName;
		private CBool _useFixedCoordinates;
		private CArray<CFloat> _fixedCoordinates;
		private CBool _useStaticPose;
		private CFloat _staticPoseTime;
		private CFloat _staticPoseProgress;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("useFixedCoordinates")] 
		public CBool UseFixedCoordinates
		{
			get => GetProperty(ref _useFixedCoordinates);
			set => SetProperty(ref _useFixedCoordinates, value);
		}

		[Ordinal(2)] 
		[RED("fixedCoordinates")] 
		public CArray<CFloat> FixedCoordinates
		{
			get => GetProperty(ref _fixedCoordinates);
			set => SetProperty(ref _fixedCoordinates, value);
		}

		[Ordinal(3)] 
		[RED("useStaticPose")] 
		public CBool UseStaticPose
		{
			get => GetProperty(ref _useStaticPose);
			set => SetProperty(ref _useStaticPose, value);
		}

		[Ordinal(4)] 
		[RED("staticPoseTime")] 
		public CFloat StaticPoseTime
		{
			get => GetProperty(ref _staticPoseTime);
			set => SetProperty(ref _staticPoseTime, value);
		}

		[Ordinal(5)] 
		[RED("staticPoseProgress")] 
		public CFloat StaticPoseProgress
		{
			get => GetProperty(ref _staticPoseProgress);
			set => SetProperty(ref _staticPoseProgress, value);
		}

		public animAnimNode_BlendSpace_InternalsBlendSpacePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
