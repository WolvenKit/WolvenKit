using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCollisionRoundedShape : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("transformLS")] 
		public QsTransform TransformLS
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		[Ordinal(2)] 
		[RED("roundedCornerRadius")] 
		public CFloat RoundedCornerRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("xBoxExtent")] 
		public CFloat XBoxExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("yBoxExtent")] 
		public CFloat YBoxExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("zBoxExtent")] 
		public CFloat ZBoxExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animCollisionRoundedShape()
		{
			Bone = new animTransformIndex();
			TransformLS = new QsTransform { Translation = new Vector4 { W = 1.000000F }, Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
