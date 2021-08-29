using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDyngConstraintLink : animIDyngConstraint
	{
		private animTransformIndex _bone1;
		private animTransformIndex _bone2;
		private CEnum<animDyngConstraintLinkType> _linkType;
		private CFloat _lengthLowerBoundRatioPercentage;
		private CFloat _lengthUpperBoundRatioPercentage;
		private Vector3 _lookAtAxis;

		[Ordinal(1)] 
		[RED("bone1")] 
		public animTransformIndex Bone1
		{
			get => GetProperty(ref _bone1);
			set => SetProperty(ref _bone1, value);
		}

		[Ordinal(2)] 
		[RED("bone2")] 
		public animTransformIndex Bone2
		{
			get => GetProperty(ref _bone2);
			set => SetProperty(ref _bone2, value);
		}

		[Ordinal(3)] 
		[RED("linkType")] 
		public CEnum<animDyngConstraintLinkType> LinkType
		{
			get => GetProperty(ref _linkType);
			set => SetProperty(ref _linkType, value);
		}

		[Ordinal(4)] 
		[RED("lengthLowerBoundRatioPercentage")] 
		public CFloat LengthLowerBoundRatioPercentage
		{
			get => GetProperty(ref _lengthLowerBoundRatioPercentage);
			set => SetProperty(ref _lengthLowerBoundRatioPercentage, value);
		}

		[Ordinal(5)] 
		[RED("lengthUpperBoundRatioPercentage")] 
		public CFloat LengthUpperBoundRatioPercentage
		{
			get => GetProperty(ref _lengthUpperBoundRatioPercentage);
			set => SetProperty(ref _lengthUpperBoundRatioPercentage, value);
		}

		[Ordinal(6)] 
		[RED("lookAtAxis")] 
		public Vector3 LookAtAxis
		{
			get => GetProperty(ref _lookAtAxis);
			set => SetProperty(ref _lookAtAxis, value);
		}
	}
}
