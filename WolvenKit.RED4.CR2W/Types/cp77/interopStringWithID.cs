using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopStringWithID : CVariable
	{
		private CString _text;
		private CUInt64 _id;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt64) CR2WTypeManager.Create("Uint64", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public interopStringWithID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
