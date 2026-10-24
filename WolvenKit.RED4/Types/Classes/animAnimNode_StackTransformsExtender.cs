using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StackTransformsExtender : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("transformInfos")] 
		public CArray<animTransformInfo> TransformInfos
		{
			get => GetPropertyValue<CArray<animTransformInfo>>();
			set => SetPropertyValue<CArray<animTransformInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("snapMethods")] 
		public CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>> SnapMethods
		{
			get => GetPropertyValue<CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>>>();
			set => SetPropertyValue<CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>>>(value);
		}

		[Ordinal(5)] 
		[RED("snapToReferenceValues")] 
		public CArray<CBool> SnapToReferenceValues
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(6)] 
		[RED("snapTargetBones")] 
		public CArray<animTransformIndex> SnapTargetBones
		{
			get => GetPropertyValue<CArray<animTransformIndex>>();
			set => SetPropertyValue<CArray<animTransformIndex>>(value);
		}

		[Ordinal(7)] 
		[RED("offsetToReferenceValues")] 
		public CArray<CBool> OffsetToReferenceValues
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(8)] 
		[RED("offsetSpaceBones")] 
		public CArray<animTransformIndex> OffsetSpaceBones
		{
			get => GetPropertyValue<CArray<animTransformIndex>>();
			set => SetPropertyValue<CArray<animTransformIndex>>(value);
		}

		[Ordinal(9)] 
		[RED("offsets")] 
		public CArray<QsTransform> Offsets
		{
			get => GetPropertyValue<CArray<QsTransform>>();
			set => SetPropertyValue<CArray<QsTransform>>(value);
		}

		public animAnimNode_StackTransformsExtender()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			TransformInfos = new();
			SnapMethods = new();
			SnapToReferenceValues = new();
			SnapTargetBones = new();
			OffsetToReferenceValues = new();
			OffsetSpaceBones = new();
			Offsets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
