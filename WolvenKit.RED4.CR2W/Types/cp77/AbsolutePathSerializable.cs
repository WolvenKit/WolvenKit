using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AbsolutePathSerializable : CVariable
	{
		private CString _path;

		[Ordinal(0)] 
		[RED("Path")] 
		public CString Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CString) CR2WTypeManager.Create("String", "Path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		public AbsolutePathSerializable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
