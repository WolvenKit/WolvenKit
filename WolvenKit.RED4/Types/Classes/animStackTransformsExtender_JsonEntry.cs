using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animStackTransformsExtender_JsonEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("parentName")] 
		public CName ParentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("referenceTransformLs")] 
		public QsTransform ReferenceTransformLs
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		[Ordinal(3)] 
		[RED("snapMethod")] 
		public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod
		{
			get => GetPropertyValue<CEnum<animStackTransformsExtender_SnapToBoneMethod>>();
			set => SetPropertyValue<CEnum<animStackTransformsExtender_SnapToBoneMethod>>(value);
		}

		[Ordinal(4)] 
		[RED("snapToReference")] 
		public CBool SnapToReference
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("snapTargetBone")] 
		public CName SnapTargetBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("offsetToReference")] 
		public CBool OffsetToReference
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("offsetSpaceBone")] 
		public CName OffsetSpaceBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animStackTransformsExtender_JsonEntry()
		{
			ReferenceTransformLs = new QsTransform { Translation = new Vector4 { W = 1.000000F }, Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };
			Offset = new QsTransform { Translation = new Vector4 { W = 1.000000F }, Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
