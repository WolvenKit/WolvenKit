using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkIndicesOffset : CVariable
	{
		private CUInt32 _start;
		private CUInt32 _count;
		private CUInt8 _boneIndex;

		[Ordinal(0)] 
		[RED("start")] 
		public CUInt32 Start
		{
			get
			{
				if (_start == null)
				{
					_start = (CUInt32) CR2WTypeManager.Create("Uint32", "start", cr2w, this);
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

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CUInt32) CR2WTypeManager.Create("Uint32", "count", cr2w, this);
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

		[Ordinal(2)] 
		[RED("boneIndex")] 
		public CUInt8 BoneIndex
		{
			get
			{
				if (_boneIndex == null)
				{
					_boneIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "boneIndex", cr2w, this);
				}
				return _boneIndex;
			}
			set
			{
				if (_boneIndex == value)
				{
					return;
				}
				_boneIndex = value;
				PropertySet(this);
			}
		}

		public meshChunkIndicesOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
