using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddItemsEffector : gameEffector
	{
		private CArray<wCHandle<gamedataInventoryItem_Record>> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<wCHandle<gamedataInventoryItem_Record>> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<wCHandle<gamedataInventoryItem_Record>>) CR2WTypeManager.Create("array:whandle:gamedataInventoryItem_Record", "items", cr2w, this);
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

		public AddItemsEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
