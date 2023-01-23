using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StackTransformsExtender : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("transformInfos")] 
		public CArray<animTransformInfo> TransformInfos
		{
			get => GetPropertyValue<CArray<animTransformInfo>>();
			set => SetPropertyValue<CArray<animTransformInfo>>(value);
		}

		[Ordinal(14)] 
		[RED("snapMethods")] 
		public CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>> SnapMethods
		{
			get => GetPropertyValue<CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>>>();
			set => SetPropertyValue<CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>>>(value);
		}

		[Ordinal(15)] 
		[RED("snapToReferenceValues")] 
		public CArray<CBool> SnapToReferenceValues
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(16)] 
		[RED("snapTargetBones")] 
		public CArray<animTransformIndex> SnapTargetBones
		{
			get => GetPropertyValue<CArray<animTransformIndex>>();
			set => SetPropertyValue<CArray<animTransformIndex>>(value);
		}

		[Ordinal(17)] 
		[RED("offsetToReferenceValues")] 
		public CArray<CBool> OffsetToReferenceValues
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(18)] 
		[RED("offsetSpaceBones")] 
		public CArray<animTransformIndex> OffsetSpaceBones
		{
			get => GetPropertyValue<CArray<animTransformIndex>>();
			set => SetPropertyValue<CArray<animTransformIndex>>(value);
		}

		[Ordinal(19)] 
		[RED("offsets")] 
		public CArray<QsTransform> Offsets
		{
			get => GetPropertyValue<CArray<QsTransform>>();
			set => SetPropertyValue<CArray<QsTransform>>(value);
		}

		public animAnimNode_StackTransformsExtender()
		{
			Id = 4294967295;
			InputLink = new();
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
