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
			get => GetProperty(ref _itemDisplayController);
			set => SetProperty(ref _itemDisplayController, value);
		}

		public InventorySlotWrapperTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
