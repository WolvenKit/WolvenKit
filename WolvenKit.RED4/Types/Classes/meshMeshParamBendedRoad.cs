using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamBendedRoad : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("occInds")] 
		public CArray<CUInt16> OccInds
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(1)] 
		[RED("occVerts")] 
		public CArray<Vector4> OccVerts
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(2)] 
		[RED("occSkinWeights")] 
		public CArray<Vector4> OccSkinWeights
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(3)] 
		[RED("occSkinInds")] 
		public CArray<CColor> OccSkinInds
		{
			get => GetPropertyValue<CArray<CColor>>();
			set => SetPropertyValue<CArray<CColor>>(value);
		}

		[Ordinal(4)] 
		[RED("collInds")] 
		public CArray<CArray<CUInt16>> CollInds
		{
			get => GetPropertyValue<CArray<CArray<CUInt16>>>();
			set => SetPropertyValue<CArray<CArray<CUInt16>>>(value);
		}

		[Ordinal(5)] 
		[RED("collVerts")] 
		public CArray<CArray<Vector3>> CollVerts
		{
			get => GetPropertyValue<CArray<CArray<Vector3>>>();
			set => SetPropertyValue<CArray<CArray<Vector3>>>(value);
		}

		[Ordinal(6)] 
		[RED("collSkinWeights")] 
		public CArray<CArray<Vector4>> CollSkinWeights
		{
			get => GetPropertyValue<CArray<CArray<Vector4>>>();
			set => SetPropertyValue<CArray<CArray<Vector4>>>(value);
		}

		[Ordinal(7)] 
		[RED("collSkinInds")] 
		public CArray<CArray<CColor>> CollSkinInds
		{
			get => GetPropertyValue<CArray<CArray<CColor>>>();
			set => SetPropertyValue<CArray<CArray<CColor>>>(value);
		}

		[Ordinal(8)] 
		[RED("collMaterialName")] 
		public CArray<CString> CollMaterialName
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(9)] 
		[RED("collFilterPresetName")] 
		public CArray<CString> CollFilterPresetName
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(10)] 
		[RED("collFaceMatInds")] 
		public CArray<CArray<CUInt16>> CollFaceMatInds
		{
			get => GetPropertyValue<CArray<CArray<CUInt16>>>();
			set => SetPropertyValue<CArray<CArray<CUInt16>>>(value);
		}

		[Ordinal(11)] 
		[RED("collFaceMaterialNames")] 
		public CArray<CArray<CString>> CollFaceMaterialNames
		{
			get => GetPropertyValue<CArray<CArray<CString>>>();
			set => SetPropertyValue<CArray<CArray<CString>>>(value);
		}

		public meshMeshParamBendedRoad()
		{
			OccInds = new();
			OccVerts = new();
			OccSkinWeights = new();
			OccSkinInds = new();
			CollInds = new();
			CollVerts = new();
			CollSkinWeights = new();
			CollSkinInds = new();
			CollMaterialName = new();
			CollFilterPresetName = new();
			CollFaceMatInds = new();
			CollFaceMaterialNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
