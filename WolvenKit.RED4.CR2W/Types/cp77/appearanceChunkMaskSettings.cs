using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceChunkMaskSettings : CVariable
	{
		private CArray<CUInt64> _chunksIds;
		private CArray<CUInt32> _meshLayout;
		private CUInt64 _meshGeometryHash;

		[Ordinal(0)] 
		[RED("chunksIds")] 
		public CArray<CUInt64> ChunksIds
		{
			get
			{
				if (_chunksIds == null)
				{
					_chunksIds = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "chunksIds", cr2w, this);
				}
				return _chunksIds;
			}
			set
			{
				if (_chunksIds == value)
				{
					return;
				}
				_chunksIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("meshLayout")] 
		public CArray<CUInt32> MeshLayout
		{
			get
			{
				if (_meshLayout == null)
				{
					_meshLayout = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "meshLayout", cr2w, this);
				}
				return _meshLayout;
			}
			set
			{
				if (_meshLayout == value)
				{
					return;
				}
				_meshLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("meshGeometryHash")] 
		public CUInt64 MeshGeometryHash
		{
			get
			{
				if (_meshGeometryHash == null)
				{
					_meshGeometryHash = (CUInt64) CR2WTypeManager.Create("Uint64", "meshGeometryHash", cr2w, this);
				}
				return _meshGeometryHash;
			}
			set
			{
				if (_meshGeometryHash == value)
				{
					return;
				}
				_meshGeometryHash = value;
				PropertySet(this);
			}
		}

		public appearanceChunkMaskSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
