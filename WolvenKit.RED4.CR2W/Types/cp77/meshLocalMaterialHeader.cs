using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshLocalMaterialHeader : CVariable
	{
		private CUInt32 _offset;
		private CUInt32 _size;

		[Ordinal(0)] 
		[RED("offset")] 
		public CUInt32 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CUInt32) CR2WTypeManager.Create("Uint32", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CUInt32) CR2WTypeManager.Create("Uint32", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		public meshLocalMaterialHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
