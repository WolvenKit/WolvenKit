using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemChooserItemHoverOver : redEvent
	{
		private CHandle<inkPointerEvent> _sourceEvent;
		private CWeakHandle<InventoryItemDisplayController> _targetItem;

		[Ordinal(0)] 
		[RED("sourceEvent")] 
		public CHandle<inkPointerEvent> SourceEvent
		{
			get => GetProperty(ref _sourceEvent);
			set => SetProperty(ref _sourceEvent, value);
		}

		[Ordinal(1)] 
		[RED("targetItem")] 
		public CWeakHandle<InventoryItemDisplayController> TargetItem
		{
			get => GetProperty(ref _targetItem);
			set => SetProperty(ref _targetItem, value);
		}
	}
}
