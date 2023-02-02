using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackpackEquipSlotChooserPopup : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rairtyBar")] 
		public inkWidgetReference RairtyBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("weaponSlotsContainer")] 
		public inkCompoundWidgetReference WeaponSlotsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(10)] 
		[RED("gameData")] 
		public CHandle<gameItemData> GameData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(11)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<BackpackEquipSlotChooserData> Data
		{
			get => GetPropertyValue<CHandle<BackpackEquipSlotChooserData>>();
			set => SetPropertyValue<CHandle<BackpackEquipSlotChooserData>>(value);
		}

		[Ordinal(14)] 
		[RED("selectedSlotIndex")] 
		public CInt32 SelectedSlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(16)] 
		[RED("comparisonResolver")] 
		public CHandle<InventoryItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(17)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(18)] 
		[RED("closeData")] 
		public CHandle<BackpackEquipSlotChooserCloseData> CloseData
		{
			get => GetPropertyValue<CHandle<BackpackEquipSlotChooserCloseData>>();
			set => SetPropertyValue<CHandle<BackpackEquipSlotChooserCloseData>>(value);
		}

		public BackpackEquipSlotChooserPopup()
		{
			TitleText = new();
			ButtonHintsRoot = new();
			RairtyBar = new();
			Root = new();
			Background = new();
			WeaponSlotsContainer = new();
			TooltipsManagerRef = new();
			ButtonOk = new();
			ButtonCancel = new();
			LibraryPath = new() { WidgetLibrary = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
