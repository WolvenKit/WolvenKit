using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamDestructionBoneChunkMapping : meshMeshParameter
	{
		private CArray<CUInt64> _boneChunkMasks;

		[Ordinal(0)] 
		[RED("boneChunkMasks")] 
		public CArray<CUInt64> BoneChunkMasks
		{
			get => GetProperty(ref _boneChunkMasks);
			set => SetProperty(ref _boneChunkMasks, value);
		}
	}
}
