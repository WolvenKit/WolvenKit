using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOptionsGroup : CVariable
	{
		private CName _name;
		private CArray<CName> _options;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("options")] 
		public CArray<CName> Options
		{
			get
			{
				if (_options == null)
				{
					_options = (CArray<CName>) CR2WTypeManager.Create("array:CName", "options", cr2w, this);
				}
				return _options;
			}
			set
			{
				if (_options == value)
				{
					return;
				}
				_options = value;
				PropertySet(this);
			}
		}

		public gameuiOptionsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
