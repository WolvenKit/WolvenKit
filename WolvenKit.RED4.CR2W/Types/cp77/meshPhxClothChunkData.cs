using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshPhxClothChunkData : CVariable
	{
		private DataBuffer _positions;
		private DataBuffer _indices;
		private DataBuffer _skinWeights;
		private DataBuffer _skinIndices;
		private DataBuffer _skinWeightsExt;
		private DataBuffer _skinIndicesExt;
		private DataBuffer _cookedData;
		private DataBuffer _normals;

		[Ordinal(0)] 
		[RED("positions")] 
		public DataBuffer Positions
		{
			get => GetProperty(ref _positions);
			set => SetProperty(ref _positions, value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		[Ordinal(2)] 
		[RED("skinWeights")] 
		public DataBuffer SkinWeights
		{
			get => GetProperty(ref _skinWeights);
			set => SetProperty(ref _skinWeights, value);
		}

		[Ordinal(3)] 
		[RED("skinIndices")] 
		public DataBuffer SkinIndices
		{
			get => GetProperty(ref _skinIndices);
			set => SetProperty(ref _skinIndices, value);
		}

		[Ordinal(4)] 
		[RED("skinWeightsExt")] 
		public DataBuffer SkinWeightsExt
		{
			get => GetProperty(ref _skinWeightsExt);
			set => SetProperty(ref _skinWeightsExt, value);
		}

		[Ordinal(5)] 
		[RED("skinIndicesExt")] 
		public DataBuffer SkinIndicesExt
		{
			get => GetProperty(ref _skinIndicesExt);
			set => SetProperty(ref _skinIndicesExt, value);
		}

		[Ordinal(6)] 
		[RED("cookedData")] 
		public DataBuffer CookedData
		{
			get => GetProperty(ref _cookedData);
			set => SetProperty(ref _cookedData, value);
		}

		[Ordinal(7)] 
		[RED("normals")] 
		public DataBuffer Normals
		{
			get => GetProperty(ref _normals);
			set => SetProperty(ref _normals, value);
		}

		public meshPhxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
