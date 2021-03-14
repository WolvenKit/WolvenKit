using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDebugPath : CVariable
	{
		private CString _str;

		[Ordinal(0)] 
		[RED("str")] 
		public CString Str
		{
			get
			{
				if (_str == null)
				{
					_str = (CString) CR2WTypeManager.Create("String", "str", cr2w, this);
				}
				return _str;
			}
			set
			{
				if (_str == value)
				{
					return;
				}
				_str = value;
				PropertySet(this);
			}
		}

		public gameDebugPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
