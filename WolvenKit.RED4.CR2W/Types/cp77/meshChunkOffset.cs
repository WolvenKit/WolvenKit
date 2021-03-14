using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkOffset : CVariable
	{
		private CUInt32 _chunkIndex;
		private CUInt16 _start;
		private CUInt16 _count;

		[Ordinal(0)] 
		[RED("chunkIndex")] 
		public CUInt32 ChunkIndex
		{
			get
			{
				if (_chunkIndex == null)
				{
					_chunkIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "chunkIndex", cr2w, this);
				}
				return _chunkIndex;
			}
			set
			{
				if (_chunkIndex == value)
				{
					return;
				}
				_chunkIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("start")] 
		public CUInt16 Start
		{
			get
			{
				if (_start == null)
				{
					_start = (CUInt16) CR2WTypeManager.Create("Uint16", "start", cr2w, this);
				}
				return _start;
			}
			set
			{
				if (_start == value)
				{
					return;
				}
				_start = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CUInt16 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CUInt16) CR2WTypeManager.Create("Uint16", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		public meshChunkOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
