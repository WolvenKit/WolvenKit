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
			get
			{
				if (_boneChunkMasks == null)
				{
					_boneChunkMasks = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "boneChunkMasks", cr2w, this);
				}
				return _boneChunkMasks;
			}
			set
			{
				if (_boneChunkMasks == value)
				{
					return;
				}
				_boneChunkMasks = value;
				PropertySet(this);
			}
		}

		public meshMeshParamDestructionBoneChunkMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
