using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryGenericItemChooser : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("itemContainer")] 
		public inkCompoundWidgetReference ItemContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("slotsCategory")] 
		public inkWidgetReference SlotsCategory
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("slotsRootContainer")] 
		public inkWidgetReference SlotsRootContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("slotsRootLabel")] 
		public inkTextWidgetReference SlotsRootLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("slotsContainer")] 
		public inkCompoundWidgetReference SlotsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(7)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(8)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(9)] 
		[RED("itemDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> ItemDisplay
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(10)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("selectedItem")] 
		public CWeakHandle<InventoryItemDisplayController> SelectedItem
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(12)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(13)] 
		[RED("transmogCtrlsContainer")] 
		public inkCompoundWidgetReference TransmogCtrlsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("transmogIndicatorCtrl")] 
		public CWeakHandle<TransmogButtonView> TransmogIndicatorCtrl
		{
			get => GetPropertyValue<CWeakHandle<TransmogButtonView>>();
			set => SetPropertyValue<CWeakHandle<TransmogButtonView>>(value);
		}

		[Ordinal(15)] 
		[RED("transmogIndicator")] 
		public CWeakHandle<inkWidget> TransmogIndicator
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public InventoryGenericItemChooser()
		{
			ItemContainer = new inkCompoundWidgetReference();
			SlotsCategory = new inkWidgetReference();
			SlotsRootContainer = new inkWidgetReference();
			SlotsRootLabel = new inkTextWidgetReference();
			SlotsContainer = new inkCompoundWidgetReference();
			TransmogCtrlsContainer = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
