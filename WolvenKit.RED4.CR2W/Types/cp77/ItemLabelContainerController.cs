using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLabelContainerController : inkWidgetLogicController
	{
		private CArray<wCHandle<ItemLabelController>> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<wCHandle<ItemLabelController>> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<wCHandle<ItemLabelController>>) CR2WTypeManager.Create("array:whandle:ItemLabelController", "items", cr2w, this);
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

		public ItemLabelContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
