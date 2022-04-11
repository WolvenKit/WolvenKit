using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animStackTransformsExtender_Entry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transformInfo")] 
		public animTransformInfo TransformInfo
		{
			get => GetPropertyValue<animTransformInfo>();
			set => SetPropertyValue<animTransformInfo>(value);
		}

		[Ordinal(1)] 
		[RED("snapMethod")] 
		public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod
		{
			get => GetPropertyValue<CEnum<animStackTransformsExtender_SnapToBoneMethod>>();
			set => SetPropertyValue<CEnum<animStackTransformsExtender_SnapToBoneMethod>>(value);
		}

		[Ordinal(2)] 
		[RED("snapToReference")] 
		public CBool SnapToReference
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("snapTargetBone")] 
		public animTransformIndex SnapTargetBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("offsetToReference")] 
		public CBool OffsetToReference
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("offsetSpaceBone")] 
		public animTransformIndex OffsetSpaceBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animStackTransformsExtender_Entry()
		{
			TransformInfo = new() { ReferenceTransformLs = new() { Translation = new() { W = 1.000000F }, Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } } };
			SnapTargetBone = new();
			OffsetSpaceBone = new();
			Offset = new() { Translation = new() { W = 1.000000F }, Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };
		}
	}
}
