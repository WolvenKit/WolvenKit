using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemModSlotDisplay : inkWidgetLogicController
	{
		private inkWidgetReference _slotBorder;
		private inkWidgetReference _slotBackground;

		[Ordinal(1)] 
		[RED("slotBorder")] 
		public inkWidgetReference SlotBorder
		{
			get => GetProperty(ref _slotBorder);
			set => SetProperty(ref _slotBorder, value);
		}

		[Ordinal(2)] 
		[RED("slotBackground")] 
		public inkWidgetReference SlotBackground
		{
			get => GetProperty(ref _slotBackground);
			set => SetProperty(ref _slotBackground, value);
		}

		public InventoryItemModSlotDisplay(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
