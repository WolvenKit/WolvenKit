using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EyesLookAt : animAnimNode_OnePoseInput
	{
		private animVectorLink _targetALink;
		private animFloatLink _weightALink;
		private animVectorLink _targetBLink;
		private animFloatLink _weightBLink;
		private animFloatLink _transitionWeightLink;
		private animTransformIndex _leftEye;
		private animTransformIndex _rightEye;
		private animTransformIndex _head;
		private CEnum<animAxis> _forwardDirection;

		[Ordinal(12)] 
		[RED("targetALink")] 
		public animVectorLink TargetALink
		{
			get => GetProperty(ref _targetALink);
			set => SetProperty(ref _targetALink, value);
		}

		[Ordinal(13)] 
		[RED("weightALink")] 
		public animFloatLink WeightALink
		{
			get => GetProperty(ref _weightALink);
			set => SetProperty(ref _weightALink, value);
		}

		[Ordinal(14)] 
		[RED("targetBLink")] 
		public animVectorLink TargetBLink
		{
			get => GetProperty(ref _targetBLink);
			set => SetProperty(ref _targetBLink, value);
		}

		[Ordinal(15)] 
		[RED("weightBLink")] 
		public animFloatLink WeightBLink
		{
			get => GetProperty(ref _weightBLink);
			set => SetProperty(ref _weightBLink, value);
		}

		[Ordinal(16)] 
		[RED("transitionWeightLink")] 
		public animFloatLink TransitionWeightLink
		{
			get => GetProperty(ref _transitionWeightLink);
			set => SetProperty(ref _transitionWeightLink, value);
		}

		[Ordinal(17)] 
		[RED("leftEye")] 
		public animTransformIndex LeftEye
		{
			get => GetProperty(ref _leftEye);
			set => SetProperty(ref _leftEye, value);
		}

		[Ordinal(18)] 
		[RED("rightEye")] 
		public animTransformIndex RightEye
		{
			get => GetProperty(ref _rightEye);
			set => SetProperty(ref _rightEye, value);
		}

		[Ordinal(19)] 
		[RED("head")] 
		public animTransformIndex Head
		{
			get => GetProperty(ref _head);
			set => SetProperty(ref _head, value);
		}

		[Ordinal(20)] 
		[RED("forwardDirection")] 
		public CEnum<animAxis> ForwardDirection
		{
			get => GetProperty(ref _forwardDirection);
			set => SetProperty(ref _forwardDirection, value);
		}

		public animAnimNode_EyesLookAt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
