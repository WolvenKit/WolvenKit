using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSetBoneTransform_JsonEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transformToChange")] 
		public CName TransformToChange
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		public CName SourceBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		public CName OffsetSpaceBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animSetBoneTransform_JsonEntry()
		{
			SetMethod = Enums.animSetBoneTransformEntry_SetMethod.WholeTransform;
			Offset = new() { Translation = new() { W = 1.000000F }, Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
