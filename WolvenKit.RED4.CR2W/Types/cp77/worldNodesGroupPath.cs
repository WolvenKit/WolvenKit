using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNodesGroupPath : CVariable
	{
		private CArray<CName> _elements;

		[Ordinal(0)] 
		[RED("elements")] 
		public CArray<CName> Elements
		{
			get
			{
				if (_elements == null)
				{
					_elements = (CArray<CName>) CR2WTypeManager.Create("array:CName", "elements", cr2w, this);
				}
				return _elements;
			}
			set
			{
				if (_elements == value)
				{
					return;
				}
				_elements = value;
				PropertySet(this);
			}
		}

		public worldNodesGroupPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
