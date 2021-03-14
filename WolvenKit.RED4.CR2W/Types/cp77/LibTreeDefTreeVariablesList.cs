using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariablesList : CVariable
	{
		private CArray<CHandle<LibTreeDefTreeVariable>> _list;

		[Ordinal(0)] 
		[RED("list")] 
		public CArray<CHandle<LibTreeDefTreeVariable>> List
		{
			get
			{
				if (_list == null)
				{
					_list = (CArray<CHandle<LibTreeDefTreeVariable>>) CR2WTypeManager.Create("array:handle:LibTreeDefTreeVariable", "list", cr2w, this);
				}
				return _list;
			}
			set
			{
				if (_list == value)
				{
					return;
				}
				_list = value;
				PropertySet(this);
			}
		}

		public LibTreeDefTreeVariablesList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
