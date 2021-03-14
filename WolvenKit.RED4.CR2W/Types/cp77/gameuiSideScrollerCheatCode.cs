using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerCheatCode : CVariable
	{
		private CName _name;
		private CArray<CName> _keys;

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
		[RED("keys")] 
		public CArray<CName> Keys
		{
			get
			{
				if (_keys == null)
				{
					_keys = (CArray<CName>) CR2WTypeManager.Create("array:CName", "keys", cr2w, this);
				}
				return _keys;
			}
			set
			{
				if (_keys == value)
				{
					return;
				}
				_keys = value;
				PropertySet(this);
			}
		}

		public gameuiSideScrollerCheatCode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
