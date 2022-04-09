using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialCorrectivePoseDataDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<animImportFacialTransform> Transforms
		{
			get => GetPropertyValue<CArray<animImportFacialTransform>>();
			set => SetPropertyValue<CArray<animImportFacialTransform>>(value);
		}

		[Ordinal(1)] 
		[RED("transformsNoScale")] 
		public CArray<animImportFacialTransformNoScale> TransformsNoScale
		{
			get => GetPropertyValue<CArray<animImportFacialTransformNoScale>>();
			set => SetPropertyValue<CArray<animImportFacialTransformNoScale>>(value);
		}

		[Ordinal(2)] 
		[RED("transformIds")] 
		public CArray<CUInt16> TransformIds
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(3)] 
		[RED("transformNames")] 
		public CArray<CName> TransformNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("parentsWeights")] 
		public CArray<CFloat> ParentsWeights
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public animImportFacialCorrectivePoseDataDesc()
		{
			Transforms = new();
			TransformsNoScale = new();
			TransformIds = new();
			TransformNames = new();
			ParentsWeights = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
