using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sharedMenuCollection : CVariable
	{
		private CArray<sharedMenuItem> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<sharedMenuItem> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<sharedMenuItem>) CR2WTypeManager.Create("array:sharedMenuItem", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		public sharedMenuCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
