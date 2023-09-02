using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareInventoryMiniGrid : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkUniformGridWidgetReference GridContainer
		{
			get => GetPropertyValue<inkUniformGridWidgetReference>();
			set => SetPropertyValue<inkUniformGridWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("sublabel")] 
		public inkTextWidgetReference Sublabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("number")] 
		public inkTextWidgetReference Number
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("numberPanel")] 
		public inkWidgetReference NumberPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("gridWidth")] 
		public CInt32 GridWidth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("selectedSlotIndex")] 
		public CInt32 SelectedSlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(9)] 
		[RED("parentObject")] 
		public CHandle<IScriptable> ParentObject
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(10)] 
		[RED("onRealeaseCallbackName")] 
		public CName OnRealeaseCallbackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("gridData")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> GridData
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		public CyberwareInventoryMiniGrid()
		{
			GridContainer = new inkUniformGridWidgetReference();
			Label = new inkTextWidgetReference();
			Sublabel = new inkTextWidgetReference();
			Number = new inkTextWidgetReference();
			NumberPanel = new inkWidgetReference();
			GridData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
