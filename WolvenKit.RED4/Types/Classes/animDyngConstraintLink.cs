using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDyngConstraintLink : animIDyngConstraint
	{
		[Ordinal(1)] 
		[RED("bone1")] 
		public animTransformIndex Bone1
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("bone2")] 
		public animTransformIndex Bone2
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("linkType")] 
		public CEnum<animDyngConstraintLinkType> LinkType
		{
			get => GetPropertyValue<CEnum<animDyngConstraintLinkType>>();
			set => SetPropertyValue<CEnum<animDyngConstraintLinkType>>(value);
		}

		[Ordinal(4)] 
		[RED("lengthLowerBoundRatioPercentage")] 
		public CFloat LengthLowerBoundRatioPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("lengthUpperBoundRatioPercentage")] 
		public CFloat LengthUpperBoundRatioPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("lookAtAxis")] 
		public Vector3 LookAtAxis
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public animDyngConstraintLink()
		{
			Bone1 = new animTransformIndex();
			Bone2 = new animTransformIndex();
			LengthLowerBoundRatioPercentage = 100.000000F;
			LengthUpperBoundRatioPercentage = 100.000000F;
			LookAtAxis = new Vector3 { X = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
