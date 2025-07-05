using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamDestructionBoneChunkMapping : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("boneChunkMasks")] 
		public CArray<CUInt64> BoneChunkMasks
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		public meshMeshParamDestructionBoneChunkMapping()
		{
			BoneChunkMasks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
