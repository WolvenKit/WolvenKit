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
			get
			{
				if (_chunkCapVertices == null)
				{
					_chunkCapVertices = (CArray<CArray<CUInt32>>) CR2WTypeManager.Create("array:array:Uint32", "chunkCapVertices", cr2w, this);
				}
				return _chunkCapVertices;
			}
			set
			{
				if (_chunkCapVertices == value)
				{
					return;
				}
				_chunkCapVertices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("customMorph")] 
		public CBool CustomMorph
		{
			get
			{
				if (_customMorph == null)
				{
					_customMorph = (CBool) CR2WTypeManager.Create("Bool", "customMorph", cr2w, this);
				}
				return _customMorph;
			}
			set
			{
				if (_customMorph == value)
				{
					return;
				}
				_customMorph = value;
				PropertySet(this);
			}
		}

		public meshMeshParamGarmentSupport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
