using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadialMenuGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _containerRef;
		private inkWidgetReference _highlightRef;
		private CArray<inkWidgetReference> _itemListRef;
		private CWeakHandle<gameIBlackboard> _quickSlotsBoard;
		private CHandle<UI_QuickSlotsDataDef> _quickSlotsDef;
		private CHandle<redCallbackObject> _inputAxisCallbackId;

		[Ordinal(9)] 
		[RED("containerRef")] 
		public inkCompoundWidgetReference ContainerRef
		{
			get => GetProperty(ref _containerRef);
			set => SetProperty(ref _containerRef, value);
		}

		[Ordinal(10)] 
		[RED("highlightRef")] 
		public inkWidgetReference HighlightRef
		{
			get => GetProperty(ref _highlightRef);
			set => SetProperty(ref _highlightRef, value);
		}

		[Ordinal(11)] 
		[RED("itemListRef")] 
		public CArray<inkWidgetReference> ItemListRef
		{
			get => GetProperty(ref _itemListRef);
			set => SetProperty(ref _itemListRef, value);
		}

		[Ordinal(12)] 
		[RED("quickSlotsBoard")] 
		public CWeakHandle<gameIBlackboard> QuickSlotsBoard
		{
			get => GetProperty(ref _quickSlotsBoard);
			set => SetProperty(ref _quickSlotsBoard, value);
		}

		[Ordinal(13)] 
		[RED("quickSlotsDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickSlotsDef
		{
			get => GetProperty(ref _quickSlotsDef);
			set => SetProperty(ref _quickSlotsDef, value);
		}

		[Ordinal(14)] 
		[RED("inputAxisCallbackId")] 
		public CHandle<redCallbackObject> InputAxisCallbackId
		{
			get => GetProperty(ref _inputAxisCallbackId);
			set => SetProperty(ref _inputAxisCallbackId, value);
		}
	}
}
