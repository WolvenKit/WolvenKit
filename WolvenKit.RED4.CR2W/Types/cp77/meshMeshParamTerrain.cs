using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamTerrain : meshMeshParameter
	{
		private CArray<Box> _chunkBoundingBoxes;

		[Ordinal(0)] 
		[RED("chunkBoundingBoxes")] 
		public CArray<Box> ChunkBoundingBoxes
		{
			get
			{
				if (_chunkBoundingBoxes == null)
				{
					_chunkBoundingBoxes = (CArray<Box>) CR2WTypeManager.Create("array:Box", "chunkBoundingBoxes", cr2w, this);
				}
				return _chunkBoundingBoxes;
			}
			set
			{
				if (_chunkBoundingBoxes == value)
				{
					return;
				}
				_chunkBoundingBoxes = value;
				PropertySet(this);
			}
		}

		public meshMeshParamTerrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
