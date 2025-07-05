using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSetBoneTransformEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transformToChange")] 
		public animTransformIndex TransformToChange
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("setMethod")] 
		public CEnum<animSetBoneTransformEntry_SetMethod> SetMethod
		{
			get => GetPropertyValue<CEnum<animSetBoneTransformEntry_SetMethod>>();
			set => SetPropertyValue<CEnum<animSetBoneTransformEntry_SetMethod>>(value);
		}

		[Ordinal(2)] 
		[RED("snapToReference")] 
		public CBool SnapToReference
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("sourceBone")] 
		public animTransformIndex SourceBone
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

		public animSetBoneTransformEntry()
		{
			TransformToChange = new animTransformIndex();
			SetMethod = Enums.animSetBoneTransformEntry_SetMethod.WholeTransform;
			SourceBone = new animTransformIndex();
			OffsetSpaceBone = new animTransformIndex();
			Offset = new QsTransform { Translation = new Vector4 { W = 1.000000F }, Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
