using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionNode : worldNode
	{
		private DataBuffer _compiledData;
		private CUInt16 _numActors;
		private CUInt16 _numShapeInfos;
		private CUInt16 _numShapePositions;
		private CUInt16 _numShapeRotations;
		private CUInt16 _numScales;
		private CUInt16 _numMaterials;
		private CUInt16 _numPresets;
		private CUInt16 _numMaterialIndices;
		private CUInt16 _numShapeIndices;
		private CUInt64 _sectorHash;
		private Vector4 _extents;
		private CUInt8 _lod;
		private CUInt8 _resourceVersion;

		[Ordinal(4)] 
		[RED("compiledData")] 
		public DataBuffer CompiledData
		{
			get => GetProperty(ref _compiledData);
			set => SetProperty(ref _compiledData, value);
		}

		[Ordinal(5)] 
		[RED("numActors")] 
		public CUInt16 NumActors
		{
			get => GetProperty(ref _numActors);
			set => SetProperty(ref _numActors, value);
		}

		[Ordinal(6)] 
		[RED("numShapeInfos")] 
		public CUInt16 NumShapeInfos
		{
			get => GetProperty(ref _numShapeInfos);
			set => SetProperty(ref _numShapeInfos, value);
		}

		[Ordinal(7)] 
		[RED("numShapePositions")] 
		public CUInt16 NumShapePositions
		{
			get => GetProperty(ref _numShapePositions);
			set => SetProperty(ref _numShapePositions, value);
		}

		[Ordinal(8)] 
		[RED("numShapeRotations")] 
		public CUInt16 NumShapeRotations
		{
			get => GetProperty(ref _numShapeRotations);
			set => SetProperty(ref _numShapeRotations, value);
		}

		[Ordinal(9)] 
		[RED("numScales")] 
		public CUInt16 NumScales
		{
			get => GetProperty(ref _numScales);
			set => SetProperty(ref _numScales, value);
		}

		[Ordinal(10)] 
		[RED("numMaterials")] 
		public CUInt16 NumMaterials
		{
			get => GetProperty(ref _numMaterials);
			set => SetProperty(ref _numMaterials, value);
		}

		[Ordinal(11)] 
		[RED("numPresets")] 
		public CUInt16 NumPresets
		{
			get => GetProperty(ref _numPresets);
			set => SetProperty(ref _numPresets, value);
		}

		[Ordinal(12)] 
		[RED("numMaterialIndices")] 
		public CUInt16 NumMaterialIndices
		{
			get => GetProperty(ref _numMaterialIndices);
			set => SetProperty(ref _numMaterialIndices, value);
		}

		[Ordinal(13)] 
		[RED("numShapeIndices")] 
		public CUInt16 NumShapeIndices
		{
			get => GetProperty(ref _numShapeIndices);
			set => SetProperty(ref _numShapeIndices, value);
		}

		[Ordinal(14)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get => GetProperty(ref _sectorHash);
			set => SetProperty(ref _sectorHash, value);
		}

		[Ordinal(15)] 
		[RED("extents")] 
		public Vector4 Extents
		{
			get => GetProperty(ref _extents);
			set => SetProperty(ref _extents, value);
		}

		[Ordinal(16)] 
		[RED("lod")] 
		public CUInt8 Lod
		{
			get => GetProperty(ref _lod);
			set => SetProperty(ref _lod, value);
		}

		[Ordinal(17)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetProperty(ref _resourceVersion);
			set => SetProperty(ref _resourceVersion, value);
		}

		public worldCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
