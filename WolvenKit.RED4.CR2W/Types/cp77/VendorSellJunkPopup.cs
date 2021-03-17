using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopup : gameuiWidgetGameController
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
		private inkTextWidgetReference _sellItemsFullQuantity;
		private inkTextWidgetReference _sellItemsLimitedQuantity;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<gameItemData> _gameData;
		private inkWidgetReference _buttonOk;
		private inkWidgetReference _buttonCancel;
		private CHandle<inkanimProxy> _closeAnimProxy;
		private CHandle<VendorSellJunkPopupData> _data;
		private inkWidgetLibraryReference _libraryPath;
		private CHandle<VendorSellJunkPopupCloseData> _closeData;

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
		[RED("sellItemsFullQuantity")] 
		public inkTextWidgetReference SellItemsFullQuantity
		{
			get => GetProperty(ref _sellItemsFullQuantity);
			set => SetProperty(ref _sellItemsFullQuantity, value);
		}

		[Ordinal(12)] 
		[RED("sellItemsLimitedQuantity")] 
		public inkTextWidgetReference SellItemsLimitedQuantity
		{
			get => GetProperty(ref _sellItemsLimitedQuantity);
			set => SetProperty(ref _sellItemsLimitedQuantity, value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(14)] 
		[RED("gameData")] 
		public CHandle<gameItemData> GameData
		{
			get => GetProperty(ref _gameData);
			set => SetProperty(ref _gameData, value);
		}

		[Ordinal(15)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get => GetProperty(ref _buttonOk);
			set => SetProperty(ref _buttonOk, value);
		}

		[Ordinal(16)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetProperty(ref _buttonCancel);
			set => SetProperty(ref _buttonCancel, value);
		}

		[Ordinal(17)] 
		[RED("closeAnimProxy")] 
		public CHandle<inkanimProxy> CloseAnimProxy
		{
			get => GetProperty(ref _closeAnimProxy);
			set => SetProperty(ref _closeAnimProxy, value);
		}

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<VendorSellJunkPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(19)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(20)] 
		[RED("closeData")] 
		public CHandle<VendorSellJunkPopupCloseData> CloseData
		{
			get => GetProperty(ref _closeData);
			set => SetProperty(ref _closeData, value);
		}

		public VendorSellJunkPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
