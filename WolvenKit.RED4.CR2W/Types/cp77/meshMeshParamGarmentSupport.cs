using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamGarmentSupport : meshMeshParameter
	{
		private CArray<CArray<CUInt32>> _chunkCapVertices;
		private CBool _customMorph;

		[Ordinal(0)] 
		[RED("chunkCapVertices")] 
		public CArray<CArray<CUInt32>> ChunkCapVertices
		{
			get => GetProperty(ref _chunkCapVertices);
			set => SetProperty(ref _chunkCapVertices, value);
		}

		[Ordinal(1)] 
		[RED("customMorph")] 
		public CBool CustomMorph
		{
			get => GetProperty(ref _customMorph);
			set => SetProperty(ref _customMorph, value);
		}

		public meshMeshParamGarmentSupport(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
