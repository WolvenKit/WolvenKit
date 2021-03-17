using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemChooserItemHoverOver : redEvent
	{
		private CHandle<inkPointerEvent> _sourceEvent;
		private wCHandle<InventoryItemDisplayController> _targetItem;

		[Ordinal(0)] 
		[RED("sourceEvent")] 
		public CHandle<inkPointerEvent> SourceEvent
		{
			get => GetProperty(ref _sourceEvent);
			set => SetProperty(ref _sourceEvent, value);
		}

		[Ordinal(1)] 
		[RED("targetItem")] 
		public wCHandle<InventoryItemDisplayController> TargetItem
		{
			get => GetProperty(ref _targetItem);
			set => SetProperty(ref _targetItem, value);
		}

		public ItemChooserItemHoverOver(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
