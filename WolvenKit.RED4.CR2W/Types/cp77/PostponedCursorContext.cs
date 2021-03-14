using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PostponedCursorContext : CVariable
	{
		private CName _context;
		private CHandle<inkUserData> _data;

		[Ordinal(0)] 
		[RED("context")] 
		public CName Context
		{
			get
			{
				if (_context == null)
				{
					_context = (CName) CR2WTypeManager.Create("CName", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<inkUserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<inkUserData>) CR2WTypeManager.Create("handle:inkUserData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public PostponedCursorContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
