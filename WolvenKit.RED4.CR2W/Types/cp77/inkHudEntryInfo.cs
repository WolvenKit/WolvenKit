using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHudEntryInfo : inkUserData
	{
		private Vector2 _size;
		private Vector2 _offset;

		[Ordinal(0)] 
		[RED("size")] 
		public Vector2 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector2) CR2WTypeManager.Create("Vector2", "size", cr2w, this);
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

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector2) CR2WTypeManager.Create("Vector2", "offset", cr2w, this);
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

		public inkHudEntryInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
