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
			get
			{
				if (_quantityTextMin == null)
				{
					_quantityTextMin = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quantityTextMin", cr2w, this);
				}
				return _quantityTextMin;
			}
			set
			{
				if (_quantityTextMin == value)
				{
					return;
				}
				_quantityTextMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("quantityTextMax")] 
		public inkTextWidgetReference QuantityTextMax
		{
			get
			{
				if (_quantityTextMax == null)
				{
					_quantityTextMax = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quantityTextMax", cr2w, this);
				}
				return _quantityTextMax;
			}
			set
			{
				if (_quantityTextMax == value)
				{
					return;
				}
				_quantityTextMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quantityTextChoosen")] 
		public inkTextWidgetReference QuantityTextChoosen
		{
			get
			{
				if (_quantityTextChoosen == null)
				{
					_quantityTextChoosen = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quantityTextChoosen", cr2w, this);
				}
				return _quantityTextChoosen;
			}
			set
			{
				if (_quantityTextChoosen == value)
				{
					return;
				}
				_quantityTextChoosen = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get
			{
				if (_priceText == null)
				{
					_priceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "priceText", cr2w, this);
				}
				return _priceText;
			}
			set
			{
				if (_priceText == value)
				{
					return;
				}
				_priceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get
			{
				if (_priceWrapper == null)
				{
					_priceWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "priceWrapper", cr2w, this);
				}
				return _priceWrapper;
			}
			set
			{
				if (_priceWrapper == value)
				{
					return;
				}
				_priceWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("weightText")] 
		public inkTextWidgetReference WeightText
		{
			get
			{
				if (_weightText == null)
				{
					_weightText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weightText", cr2w, this);
				}
				return _weightText;
			}
			set
			{
				if (_weightText == value)
				{
					return;
				}
				_weightText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get
			{
				if (_itemNameText == null)
				{
					_itemNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemNameText", cr2w, this);
				}
				return _itemNameText;
			}
			set
			{
				if (_itemNameText == value)
				{
					return;
				}
				_itemNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemQuantityText")] 
		public inkTextWidgetReference ItemQuantityText
		{
			get
			{
				if (_itemQuantityText == null)
				{
					_itemQuantityText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemQuantityText", cr2w, this);
				}
				return _itemQuantityText;
			}
			set
			{
				if (_itemQuantityText == value)
				{
					return;
				}
				_itemQuantityText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("rairtyBar")] 
		public inkWidgetReference RairtyBar
		{
			get
			{
				if (_rairtyBar == null)
				{
					_rairtyBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rairtyBar", cr2w, this);
				}
				return _rairtyBar;
			}
			set
			{
				if (_rairtyBar == value)
				{
					return;
				}
				_rairtyBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get
			{
				if (_buttonHintsRoot == null)
				{
					_buttonHintsRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsRoot", cr2w, this);
				}
				return _buttonHintsRoot;
			}
			set
			{
				if (_buttonHintsRoot == value)
				{
					return;
				}
				_buttonHintsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("slider")] 
		public inkWidgetReference Slider
		{
			get
			{
				if (_slider == null)
				{
					_slider = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slider", cr2w, this);
				}
				return _slider;
			}
			set
			{
				if (_slider == value)
				{
					return;
				}
				_slider = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get
			{
				if (_buttonOk == null)
				{
					_buttonOk = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonOk", cr2w, this);
				}
				return _buttonOk;
			}
			set
			{
				if (_buttonOk == value)
				{
					return;
				}
				_buttonOk = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get
			{
				if (_buttonCancel == null)
				{
					_buttonCancel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonCancel", cr2w, this);
				}
				return _buttonCancel;
			}
			set
			{
				if (_buttonCancel == value)
				{
					return;
				}
				_buttonCancel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("buttonOkText")] 
		public inkTextWidgetReference ButtonOkText
		{
			get
			{
				if (_buttonOkText == null)
				{
					_buttonOkText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "buttonOkText", cr2w, this);
				}
				return _buttonOkText;
			}
			set
			{
				if (_buttonOkText == value)
				{
					return;
				}
				_buttonOkText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("buttonLess")] 
		public inkWidgetReference ButtonLess
		{
			get
			{
				if (_buttonLess == null)
				{
					_buttonLess = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonLess", cr2w, this);
				}
				return _buttonLess;
			}
			set
			{
				if (_buttonLess == value)
				{
					return;
				}
				_buttonLess = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("buttonMore")] 
		public inkWidgetReference ButtonMore
		{
			get
			{
				if (_buttonMore == null)
				{
					_buttonMore = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonMore", cr2w, this);
				}
				return _buttonMore;
			}
			set
			{
				if (_buttonMore == value)
				{
					return;
				}
				_buttonMore = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get
			{
				if (_libraryPath == null)
				{
					_libraryPath = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "libraryPath", cr2w, this);
				}
				return _libraryPath;
			}
			set
			{
				if (_libraryPath == value)
				{
					return;
				}
				_libraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CInt32) CR2WTypeManager.Create("Int32", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("gameData")] 
		public InventoryItemData GameData
		{
			get
			{
				if (_gameData == null)
				{
					_gameData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "gameData", cr2w, this);
				}
				return _gameData;
			}
			set
			{
				if (_gameData == value)
				{
					return;
				}
				_gameData = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("actionType")] 
		public CEnum<QuantityPickerActionType> ActionType
		{
			get
			{
				if (_actionType == null)
				{
					_actionType = (CEnum<QuantityPickerActionType>) CR2WTypeManager.Create("QuantityPickerActionType", "actionType", cr2w, this);
				}
				return _actionType;
			}
			set
			{
				if (_actionType == value)
				{
					return;
				}
				_actionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("sliderController")] 
		public CHandle<inkSliderController> SliderController
		{
			get
			{
				if (_sliderController == null)
				{
					_sliderController = (CHandle<inkSliderController>) CR2WTypeManager.Create("handle:inkSliderController", "sliderController", cr2w, this);
				}
				return _sliderController;
			}
			set
			{
				if (_sliderController == value)
				{
					return;
				}
				_sliderController = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get
			{
				if (_choosenQuantity == null)
				{
					_choosenQuantity = (CInt32) CR2WTypeManager.Create("Int32", "choosenQuantity", cr2w, this);
				}
				return _choosenQuantity;
			}
			set
			{
				if (_choosenQuantity == value)
				{
					return;
				}
				_choosenQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("itemPrice")] 
		public CInt32 ItemPrice
		{
			get
			{
				if (_itemPrice == null)
				{
					_itemPrice = (CInt32) CR2WTypeManager.Create("Int32", "itemPrice", cr2w, this);
				}
				return _itemPrice;
			}
			set
			{
				if (_itemPrice == value)
				{
					return;
				}
				_itemPrice = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("itemWeight")] 
		public CFloat ItemWeight
		{
			get
			{
				if (_itemWeight == null)
				{
					_itemWeight = (CFloat) CR2WTypeManager.Create("Float", "itemWeight", cr2w, this);
				}
				return _itemWeight;
			}
			set
			{
				if (_itemWeight == value)
				{
					return;
				}
				_itemWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get
			{
				if (_isBuyback == null)
				{
					_isBuyback = (CBool) CR2WTypeManager.Create("Bool", "isBuyback", cr2w, this);
				}
				return _isBuyback;
			}
			set
			{
				if (_isBuyback == value)
				{
					return;
				}
				_isBuyback = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("data")] 
		public CHandle<QuantityPickerPopupData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<QuantityPickerPopupData>) CR2WTypeManager.Create("handle:QuantityPickerPopupData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("closeData")] 
		public CHandle<QuantityPickerPopupCloseData> CloseData
		{
			get
			{
				if (_closeData == null)
				{
					_closeData = (CHandle<QuantityPickerPopupCloseData>) CR2WTypeManager.Create("handle:QuantityPickerPopupCloseData", "closeData", cr2w, this);
				}
				return _closeData;
			}
			set
			{
				if (_closeData == value)
				{
					return;
				}
				_closeData = value;
				PropertySet(this);
			}
		}

		public ItemQuantityPickerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
