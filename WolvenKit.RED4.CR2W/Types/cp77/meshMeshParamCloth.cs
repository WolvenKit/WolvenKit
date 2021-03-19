using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCloth : meshMeshParameter
	{
		private CArray<CArray<CUInt16>> _lodChunkIndices;
		private CArray<meshPhxClothChunkData> _chunks;
		private CArray<CArray<CUInt16>> _drivers;
		private CHandle<physicsclothClothCapsuleExportData> _capsules;

		[Ordinal(0)] 
		[RED("lodChunkIndices")] 
		public CArray<CArray<CUInt16>> LodChunkIndices
		{
			get => GetProperty(ref _lodChunkIndices);
			set => SetProperty(ref _lodChunkIndices, value);
		}

		[Ordinal(1)] 
		[RED("chunks")] 
		public CArray<meshPhxClothChunkData> Chunks
		{
			get => GetProperty(ref _chunks);
			set => SetProperty(ref _chunks, value);
		}

		[Ordinal(2)] 
		[RED("drivers")] 
		public CArray<CArray<CUInt16>> Drivers
		{
			get => GetProperty(ref _drivers);
			set => SetProperty(ref _drivers, value);
		}

		[Ordinal(3)] 
		[RED("capsules")] 
		public CHandle<physicsclothClothCapsuleExportData> Capsules
		{
			get => GetProperty(ref _capsules);
			set => SetProperty(ref _capsules, value);
		}

		public meshMeshParamCloth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
