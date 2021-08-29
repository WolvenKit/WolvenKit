using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryEquipmentSlot : inkWidgetLogicController
	{
		private inkWidgetReference _equipSlotRef;
		private inkWidgetReference _emptySlotButtonRef;
		private inkImageWidgetReference _backgroundShape;
		private inkImageWidgetReference _backgroundHighlight;
		private inkImageWidgetReference _backgroundFrame;
		private inkWidgetReference _unavailableIcon;
		private inkImageWidgetReference _toggleHighlight;
		private CWeakHandle<InventoryItemDisplayController> _currentItemView;
		private CBool _empty;
		private InventoryItemData _itemData;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CString _slotName;
		private CInt32 _slotIndex;
		private CBool _disableSlot;
		private Vector2 _smallSize;
		private Vector2 _bigSize;

		[Ordinal(1)] 
		[RED("EquipSlotRef")] 
		public inkWidgetReference EquipSlotRef
		{
			get => GetProperty(ref _equipSlotRef);
			set => SetProperty(ref _equipSlotRef, value);
		}

		[Ordinal(2)] 
		[RED("EmptySlotButtonRef")] 
		public inkWidgetReference EmptySlotButtonRef
		{
			get => GetProperty(ref _emptySlotButtonRef);
			set => SetProperty(ref _emptySlotButtonRef, value);
		}

		[Ordinal(3)] 
		[RED("BackgroundShape")] 
		public inkImageWidgetReference BackgroundShape
		{
			get => GetProperty(ref _backgroundShape);
			set => SetProperty(ref _backgroundShape, value);
		}

		[Ordinal(4)] 
		[RED("BackgroundHighlight")] 
		public inkImageWidgetReference BackgroundHighlight
		{
			get => GetProperty(ref _backgroundHighlight);
			set => SetProperty(ref _backgroundHighlight, value);
		}

		[Ordinal(5)] 
		[RED("BackgroundFrame")] 
		public inkImageWidgetReference BackgroundFrame
		{
			get => GetProperty(ref _backgroundFrame);
			set => SetProperty(ref _backgroundFrame, value);
		}

		[Ordinal(6)] 
		[RED("unavailableIcon")] 
		public inkWidgetReference UnavailableIcon
		{
			get => GetProperty(ref _unavailableIcon);
			set => SetProperty(ref _unavailableIcon, value);
		}

		[Ordinal(7)] 
		[RED("toggleHighlight")] 
		public inkImageWidgetReference ToggleHighlight
		{
			get => GetProperty(ref _toggleHighlight);
			set => SetProperty(ref _toggleHighlight, value);
		}

		[Ordinal(8)] 
		[RED("CurrentItemView")] 
		public CWeakHandle<InventoryItemDisplayController> CurrentItemView
		{
			get => GetProperty(ref _currentItemView);
			set => SetProperty(ref _currentItemView, value);
		}

		[Ordinal(9)] 
		[RED("Empty")] 
		public CBool Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		[Ordinal(10)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(11)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(12)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(13)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(14)] 
		[RED("DisableSlot")] 
		public CBool DisableSlot
		{
			get => GetProperty(ref _disableSlot);
			set => SetProperty(ref _disableSlot, value);
		}

		[Ordinal(15)] 
		[RED("smallSize")] 
		public Vector2 SmallSize
		{
			get => GetProperty(ref _smallSize);
			set => SetProperty(ref _smallSize, value);
		}

		[Ordinal(16)] 
		[RED("bigSize")] 
		public Vector2 BigSize
		{
			get => GetProperty(ref _bigSize);
			set => SetProperty(ref _bigSize, value);
		}
	}
}
