using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotationLimit : animAnimNode_OnePoseInput
	{
		private animTransformIndex _constrainedTransform;
		private animSmoothFloatClamp _limitOnX;
		private animSmoothFloatClamp _limitOnY;
		private animSmoothFloatClamp _limitOnZ;
		private CBool _useEyesLookAtBlendWeight;
		private animFloatLink _weightLink;

		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetProperty(ref _constrainedTransform);
			set => SetProperty(ref _constrainedTransform, value);
		}

		[Ordinal(13)] 
		[RED("limitOnX")] 
		public animSmoothFloatClamp LimitOnX
		{
			get => GetProperty(ref _limitOnX);
			set => SetProperty(ref _limitOnX, value);
		}

		[Ordinal(14)] 
		[RED("limitOnY")] 
		public animSmoothFloatClamp LimitOnY
		{
			get => GetProperty(ref _limitOnY);
			set => SetProperty(ref _limitOnY, value);
		}

		[Ordinal(15)] 
		[RED("limitOnZ")] 
		public animSmoothFloatClamp LimitOnZ
		{
			get => GetProperty(ref _limitOnZ);
			set => SetProperty(ref _limitOnZ, value);
		}

		[Ordinal(16)] 
		[RED("useEyesLookAtBlendWeight")] 
		public CBool UseEyesLookAtBlendWeight
		{
			get => GetProperty(ref _useEyesLookAtBlendWeight);
			set => SetProperty(ref _useEyesLookAtBlendWeight, value);
		}

		[Ordinal(17)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetProperty(ref _weightLink);
			set => SetProperty(ref _weightLink, value);
		}

		public animAnimNode_RotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
