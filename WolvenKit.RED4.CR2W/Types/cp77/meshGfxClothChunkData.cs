using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshGfxClothChunkData : CVariable
	{
		private DataBuffer _positions;
		private DataBuffer _indices;
		private DataBuffer _skinWeights;
		private DataBuffer _skinIndices;
		private DataBuffer _skinWeightsExt;
		private DataBuffer _skinIndicesExt;
		private CArray<CUInt16> _simulation;

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
		[RED("simulation")] 
		public CArray<CUInt16> Simulation
		{
			get => GetProperty(ref _simulation);
			set => SetProperty(ref _simulation, value);
		}

		public meshGfxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
