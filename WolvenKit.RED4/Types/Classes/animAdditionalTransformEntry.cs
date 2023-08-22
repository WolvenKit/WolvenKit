using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAdditionalTransformEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("transformInfo")] 
		public animTransformInfo TransformInfo
		{
			get => GetPropertyValue<animTransformInfo>();
			set => SetPropertyValue<animTransformInfo>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public QsTransform Value
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animAdditionalTransformEntry()
		{
			TransformInfo = new animTransformInfo { ReferenceTransformLs = new QsTransform { Translation = new Vector4 { W = 1.000000F }, Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } } };
			Value = new QsTransform { Translation = new Vector4(), Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
