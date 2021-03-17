using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemQuantityPickerController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _quantityTextMin;
		private inkTextWidgetReference _quantityTextMax;
		private inkTextWidgetReference _quantityTextChoosen;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _priceWrapper;
		private inkTextWidgetReference _weightText;
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemQuantityText;
		private inkWidgetReference _rairtyBar;
		private inkWidgetReference _root;
		private inkWidgetReference _background;
		private inkWidgetReference _buttonHintsRoot;
		private inkWidgetReference _slider;
		private inkWidgetReference _buttonOk;
		private inkWidgetReference _buttonCancel;
		private inkTextWidgetReference _buttonOkText;
		private inkWidgetReference _buttonLess;
		private inkWidgetReference _buttonMore;
		private inkWidgetLibraryReference _libraryPath;
		private CInt32 _maxValue;
		private InventoryItemData _gameData;
		private CEnum<QuantityPickerActionType> _actionType;
		private CHandle<inkSliderController> _sliderController;
		private CInt32 _choosenQuantity;
		private CInt32 _itemPrice;
		private CFloat _itemWeight;
		private CBool _isBuyback;
		private CHandle<QuantityPickerPopupData> _data;
		private CHandle<QuantityPickerPopupCloseData> _closeData;

		[Ordinal(2)] 
		[RED("quantityTextMin")] 
		public inkTextWidgetReference QuantityTextMin
		{
			get => GetProperty(ref _quantityTextMin);
			set => SetProperty(ref _quantityTextMin, value);
		}

		[Ordinal(3)] 
		[RED("quantityTextMax")] 
		public inkTextWidgetReference QuantityTextMax
		{
			get => GetProperty(ref _quantityTextMax);
			set => SetProperty(ref _quantityTextMax, value);
		}

		[Ordinal(4)] 
		[RED("quantityTextChoosen")] 
		public inkTextWidgetReference QuantityTextChoosen
		{
			get => GetProperty(ref _quantityTextChoosen);
			set => SetProperty(ref _quantityTextChoosen, value);
		}

		[Ordinal(5)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(6)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get => GetProperty(ref _priceWrapper);
			set => SetProperty(ref _priceWrapper, value);
		}

		[Ordinal(7)] 
		[RED("weightText")] 
		public inkTextWidgetReference WeightText
		{
			get => GetProperty(ref _weightText);
			set => SetProperty(ref _weightText, value);
		}

		[Ordinal(8)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(9)] 
		[RED("itemQuantityText")] 
		public inkTextWidgetReference ItemQuantityText
		{
			get => GetProperty(ref _itemQuantityText);
			set => SetProperty(ref _itemQuantityText, value);
		}

		[Ordinal(10)] 
		[RED("rairtyBar")] 
		public inkWidgetReference RairtyBar
		{
			get => GetProperty(ref _rairtyBar);
			set => SetProperty(ref _rairtyBar, value);
		}

		[Ordinal(11)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(12)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetProperty(ref _buttonHintsRoot);
			set => SetProperty(ref _buttonHintsRoot, value);
		}

		[Ordinal(14)] 
		[RED("slider")] 
		public inkWidgetReference Slider
		{
			get => GetProperty(ref _slider);
			set => SetProperty(ref _slider, value);
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
		[RED("buttonOkText")] 
		public inkTextWidgetReference ButtonOkText
		{
			get => GetProperty(ref _buttonOkText);
			set => SetProperty(ref _buttonOkText, value);
		}

		[Ordinal(18)] 
		[RED("buttonLess")] 
		public inkWidgetReference ButtonLess
		{
			get => GetProperty(ref _buttonLess);
			set => SetProperty(ref _buttonLess, value);
		}

		[Ordinal(19)] 
		[RED("buttonMore")] 
		public inkWidgetReference ButtonMore
		{
			get => GetProperty(ref _buttonMore);
			set => SetProperty(ref _buttonMore, value);
		}

		[Ordinal(20)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(21)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(22)] 
		[RED("gameData")] 
		public InventoryItemData GameData
		{
			get => GetProperty(ref _gameData);
			set => SetProperty(ref _gameData, value);
		}

		[Ordinal(23)] 
		[RED("actionType")] 
		public CEnum<QuantityPickerActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(24)] 
		[RED("sliderController")] 
		public CHandle<inkSliderController> SliderController
		{
			get => GetProperty(ref _sliderController);
			set => SetProperty(ref _sliderController, value);
		}

		[Ordinal(25)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get => GetProperty(ref _choosenQuantity);
			set => SetProperty(ref _choosenQuantity, value);
		}

		[Ordinal(26)] 
		[RED("itemPrice")] 
		public CInt32 ItemPrice
		{
			get => GetProperty(ref _itemPrice);
			set => SetProperty(ref _itemPrice, value);
		}

		[Ordinal(27)] 
		[RED("itemWeight")] 
		public CFloat ItemWeight
		{
			get => GetProperty(ref _itemWeight);
			set => SetProperty(ref _itemWeight, value);
		}

		[Ordinal(28)] 
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get => GetProperty(ref _isBuyback);
			set => SetProperty(ref _isBuyback, value);
		}

		[Ordinal(29)] 
		[RED("data")] 
		public CHandle<QuantityPickerPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(30)] 
		[RED("closeData")] 
		public CHandle<QuantityPickerPopupCloseData> CloseData
		{
			get => GetProperty(ref _closeData);
			set => SetProperty(ref _closeData, value);
		}

		public ItemQuantityPickerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
