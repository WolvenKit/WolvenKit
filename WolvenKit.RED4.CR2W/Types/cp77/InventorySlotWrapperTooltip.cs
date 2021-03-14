using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventorySlotWrapperTooltip : AGenericTooltipController
	{
		private wCHandle<InventoryItemDisplayController> _itemDisplayController;

		[Ordinal(2)] 
		[RED("itemDisplayController")] 
		public wCHandle<InventoryItemDisplayController> ItemDisplayController
		{
			get
			{
				if (_itemDisplayController == null)
				{
					_itemDisplayController = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "itemDisplayController", cr2w, this);
				}
				return _itemDisplayController;
			}
			set
			{
				if (_itemDisplayController == value)
				{
					return;
				}
				_itemDisplayController = value;
				PropertySet(this);
			}
		}

		public InventorySlotWrapperTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
