using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDyngConstraintEllipsoid : animIDyngConstraint
	{
		[Ordinal(1)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("ellipsoidTransformLS")] 
		public QsTransform EllipsoidTransformLS
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		[Ordinal(3)] 
		[RED("constraintRadius")] 
		public CFloat ConstraintRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("constraintScale1")] 
		public CFloat ConstraintScale1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("constraintScale2")] 
		public CFloat ConstraintScale2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animDyngConstraintEllipsoid()
		{
			Bone = new animTransformIndex();
			EllipsoidTransformLS = new QsTransform { Translation = new Vector4 { W = 1.000000F }, Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };
			ConstraintRadius = 1.000000F;
			ConstraintScale1 = 1.000000F;
			ConstraintScale2 = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
