using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionBoneChunkMapping : meshMeshParameter
	{
		private CArray<CUInt64> _boneChunkMasks;

		[Ordinal(0)] 
		[RED("boneChunkMasks")] 
		public CArray<CUInt64> BoneChunkMasks
		{
			get => GetProperty(ref _boneChunkMasks);
			set => SetProperty(ref _boneChunkMasks, value);
		}

		public meshMeshParamDestructionBoneChunkMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
