using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorSellJunkPopup : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
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
		[RED("itemDisplayRef")] 
		public inkWidgetReference ItemDisplayRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("rairtyBar")] 
		public inkWidgetReference RairtyBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("eqippedItemContainer")] 
		public inkWidgetReference EqippedItemContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemPriceContainer")] 
		public inkWidgetReference ItemPriceContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("itemPriceText")] 
		public inkTextWidgetReference ItemPriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("sellItemsFullQuantity")] 
		public inkTextWidgetReference SellItemsFullQuantity
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("sellItemsLimitedQuantity")] 
		public inkTextWidgetReference SellItemsLimitedQuantity
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(15)] 
		[RED("gameData")] 
		public CHandle<gameItemData> GameData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(16)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("closeAnimProxy")] 
		public CHandle<inkanimProxy> CloseAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("data")] 
		public CHandle<VendorSellJunkPopupData> Data
		{
			get => GetPropertyValue<CHandle<VendorSellJunkPopupData>>();
			set => SetPropertyValue<CHandle<VendorSellJunkPopupData>>(value);
		}

		[Ordinal(20)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(21)] 
		[RED("closeData")] 
		public CHandle<VendorSellJunkPopupCloseData> CloseData
		{
			get => GetPropertyValue<CHandle<VendorSellJunkPopupCloseData>>();
			set => SetPropertyValue<CHandle<VendorSellJunkPopupCloseData>>(value);
		}

		public VendorSellJunkPopup()
		{
			ItemNameText = new inkTextWidgetReference();
			ButtonHintsRoot = new inkWidgetReference();
			ItemDisplayRef = new inkWidgetReference();
			RairtyBar = new inkWidgetReference();
			EqippedItemContainer = new inkWidgetReference();
			ItemPriceContainer = new inkWidgetReference();
			ItemPriceText = new inkTextWidgetReference();
			Root = new inkWidgetReference();
			Background = new inkWidgetReference();
			HeaderText = new inkTextWidgetReference();
			SellItemsFullQuantity = new inkTextWidgetReference();
			SellItemsLimitedQuantity = new inkTextWidgetReference();
			ButtonOk = new inkWidgetReference();
			ButtonCancel = new inkWidgetReference();
			LibraryPath = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
