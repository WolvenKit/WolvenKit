using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorConfirmationPopup : gameuiWidgetGameController
	{
		private inkTextWidgetReference _itemNameText;
		private inkWidgetReference _buttonHintsRoot;
		private inkWidgetReference _itemDisplayRef;
		private inkWidgetReference _rairtyBar;
		private inkWidgetReference _eqippedItemContainer;
		private inkWidgetReference _itemPriceContainer;
		private inkTextWidgetReference _itemPriceText;
		private inkWidgetReference _root;
		private inkWidgetReference _background;
		private CHandle<VendorConfirmationPopupCloseData> _closeData;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CHandle<gameItemData> _gameData;
		private inkWidgetReference _buttonOk;
		private inkWidgetReference _buttonCancel;
		private CHandle<VendorConfirmationPopupData> _data;
		private CWeakHandle<InventoryItemDisplayController> _itemDisplayController;
		private inkWidgetLibraryReference _libraryPath;

		[Ordinal(2)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(3)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetProperty(ref _buttonHintsRoot);
			set => SetProperty(ref _buttonHintsRoot, value);
		}

		[Ordinal(4)] 
		[RED("itemDisplayRef")] 
		public inkWidgetReference ItemDisplayRef
		{
			get => GetProperty(ref _itemDisplayRef);
			set => SetProperty(ref _itemDisplayRef, value);
		}

		[Ordinal(5)] 
		[RED("rairtyBar")] 
		public inkWidgetReference RairtyBar
		{
			get => GetProperty(ref _rairtyBar);
			set => SetProperty(ref _rairtyBar, value);
		}

		[Ordinal(6)] 
		[RED("eqippedItemContainer")] 
		public inkWidgetReference EqippedItemContainer
		{
			get => GetProperty(ref _eqippedItemContainer);
			set => SetProperty(ref _eqippedItemContainer, value);
		}

		[Ordinal(7)] 
		[RED("itemPriceContainer")] 
		public inkWidgetReference ItemPriceContainer
		{
			get => GetProperty(ref _itemPriceContainer);
			set => SetProperty(ref _itemPriceContainer, value);
		}

		[Ordinal(8)] 
		[RED("itemPriceText")] 
		public inkTextWidgetReference ItemPriceText
		{
			get => GetProperty(ref _itemPriceText);
			set => SetProperty(ref _itemPriceText, value);
		}

		[Ordinal(9)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(11)] 
		[RED("closeData")] 
		public CHandle<VendorConfirmationPopupCloseData> CloseData
		{
			get => GetProperty(ref _closeData);
			set => SetProperty(ref _closeData, value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(13)] 
		[RED("gameData")] 
		public CHandle<gameItemData> GameData
		{
			get => GetProperty(ref _gameData);
			set => SetProperty(ref _gameData, value);
		}

		[Ordinal(14)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get => GetProperty(ref _buttonOk);
			set => SetProperty(ref _buttonOk, value);
		}

		[Ordinal(15)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetProperty(ref _buttonCancel);
			set => SetProperty(ref _buttonCancel, value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<VendorConfirmationPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(17)] 
		[RED("itemDisplayController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemDisplayController
		{
			get => GetProperty(ref _itemDisplayController);
			set => SetProperty(ref _itemDisplayController, value);
		}

		[Ordinal(18)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}
	}
}
