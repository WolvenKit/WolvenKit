using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshRegionData : CVariable
	{
		private CArray<meshChunkOffset> _chunkDataIntact;
		private CArray<meshChunkOffset> _chunkDataFractured;
		private CUInt64 _chunkMaskIntact;
		private CUInt64 _chunkMaskFractured;
		private CBool _isStaticRemains;

		[Ordinal(0)] 
		[RED("chunkDataIntact")] 
		public CArray<meshChunkOffset> ChunkDataIntact
		{
			get
			{
				if (_chunkDataIntact == null)
				{
					_chunkDataIntact = (CArray<meshChunkOffset>) CR2WTypeManager.Create("array:meshChunkOffset", "chunkDataIntact", cr2w, this);
				}
				return _chunkDataIntact;
			}
			set
			{
				if (_chunkDataIntact == value)
				{
					return;
				}
				_chunkDataIntact = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("chunkDataFractured")] 
		public CArray<meshChunkOffset> ChunkDataFractured
		{
			get
			{
				if (_chunkDataFractured == null)
				{
					_chunkDataFractured = (CArray<meshChunkOffset>) CR2WTypeManager.Create("array:meshChunkOffset", "chunkDataFractured", cr2w, this);
				}
				return _chunkDataFractured;
			}
			set
			{
				if (_chunkDataFractured == value)
				{
					return;
				}
				_chunkDataFractured = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("chunkMaskIntact")] 
		public CUInt64 ChunkMaskIntact
		{
			get
			{
				if (_chunkMaskIntact == null)
				{
					_chunkMaskIntact = (CUInt64) CR2WTypeManager.Create("Uint64", "chunkMaskIntact", cr2w, this);
				}
				return _chunkMaskIntact;
			}
			set
			{
				if (_chunkMaskIntact == value)
				{
					return;
				}
				_chunkMaskIntact = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("chunkMaskFractured")] 
		public CUInt64 ChunkMaskFractured
		{
			get
			{
				if (_chunkMaskFractured == null)
				{
					_chunkMaskFractured = (CUInt64) CR2WTypeManager.Create("Uint64", "chunkMaskFractured", cr2w, this);
				}
				return _chunkMaskFractured;
			}
			set
			{
				if (_chunkMaskFractured == value)
				{
					return;
				}
				_chunkMaskFractured = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isStaticRemains")] 
		public CBool IsStaticRemains
		{
			get
			{
				if (_isStaticRemains == null)
				{
					_isStaticRemains = (CBool) CR2WTypeManager.Create("Bool", "isStaticRemains", cr2w, this);
				}
				return _isStaticRemains;
			}
			set
			{
				if (_isStaticRemains == value)
				{
					return;
				}
				_isStaticRemains = value;
				PropertySet(this);
			}
		}

		public meshRegionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
