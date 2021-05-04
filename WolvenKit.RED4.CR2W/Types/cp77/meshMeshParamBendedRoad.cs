using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamBendedRoad : meshMeshParameter
	{
		private CArray<CUInt16> _occInds;
		private CArray<Vector4> _occVerts;
		private CArray<Vector4> _occSkinWeights;
		private CArray<CColor> _occSkinInds;
		private CArray<CArray<CUInt16>> _collInds;
		private CArray<CArray<Vector3>> _collVerts;
		private CArray<CArray<Vector4>> _collSkinWeights;
		private CArray<CArray<CColor>> _collSkinInds;
		private CArray<CString> _collMaterialName;
		private CArray<CString> _collFilterPresetName;
		private CArray<CArray<CUInt16>> _collFaceMatInds;
		private CArray<CArray<CString>> _collFaceMaterialNames;

		[Ordinal(0)] 
		[RED("occInds")] 
		public CArray<CUInt16> OccInds
		{
			get => GetProperty(ref _occInds);
			set => SetProperty(ref _occInds, value);
		}

		[Ordinal(1)] 
		[RED("occVerts")] 
		public CArray<Vector4> OccVerts
		{
			get => GetProperty(ref _occVerts);
			set => SetProperty(ref _occVerts, value);
		}

		[Ordinal(2)] 
		[RED("occSkinWeights")] 
		public CArray<Vector4> OccSkinWeights
		{
			get => GetProperty(ref _occSkinWeights);
			set => SetProperty(ref _occSkinWeights, value);
		}

		[Ordinal(3)] 
		[RED("occSkinInds")] 
		public CArray<CColor> OccSkinInds
		{
			get => GetProperty(ref _occSkinInds);
			set => SetProperty(ref _occSkinInds, value);
		}

		[Ordinal(4)] 
		[RED("collInds")] 
		public CArray<CArray<CUInt16>> CollInds
		{
			get => GetProperty(ref _collInds);
			set => SetProperty(ref _collInds, value);
		}

		[Ordinal(5)] 
		[RED("collVerts")] 
		public CArray<CArray<Vector3>> CollVerts
		{
			get => GetProperty(ref _collVerts);
			set => SetProperty(ref _collVerts, value);
		}

		[Ordinal(6)] 
		[RED("collSkinWeights")] 
		public CArray<CArray<Vector4>> CollSkinWeights
		{
			get => GetProperty(ref _collSkinWeights);
			set => SetProperty(ref _collSkinWeights, value);
		}

		[Ordinal(7)] 
		[RED("collSkinInds")] 
		public CArray<CArray<CColor>> CollSkinInds
		{
			get => GetProperty(ref _collSkinInds);
			set => SetProperty(ref _collSkinInds, value);
		}

		[Ordinal(8)] 
		[RED("collMaterialName")] 
		public CArray<CString> CollMaterialName
		{
			get => GetProperty(ref _collMaterialName);
			set => SetProperty(ref _collMaterialName, value);
		}

		[Ordinal(9)] 
		[RED("collFilterPresetName")] 
		public CArray<CString> CollFilterPresetName
		{
			get => GetProperty(ref _collFilterPresetName);
			set => SetProperty(ref _collFilterPresetName, value);
		}

		[Ordinal(10)] 
		[RED("collFaceMatInds")] 
		public CArray<CArray<CUInt16>> CollFaceMatInds
		{
			get => GetProperty(ref _collFaceMatInds);
			set => SetProperty(ref _collFaceMatInds, value);
		}

		[Ordinal(11)] 
		[RED("collFaceMaterialNames")] 
		public CArray<CArray<CString>> CollFaceMaterialNames
		{
			get => GetProperty(ref _collFaceMaterialNames);
			set => SetProperty(ref _collFaceMaterialNames, value);
		}

		public meshMeshParamBendedRoad(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
