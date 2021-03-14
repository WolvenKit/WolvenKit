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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("itemDisplayRef")] 
		public inkWidgetReference ItemDisplayRef
		{
			get
			{
				if (_itemDisplayRef == null)
				{
					_itemDisplayRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemDisplayRef", cr2w, this);
				}
				return _itemDisplayRef;
			}
			set
			{
				if (_itemDisplayRef == value)
				{
					return;
				}
				_itemDisplayRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("eqippedItemContainer")] 
		public inkWidgetReference EqippedItemContainer
		{
			get
			{
				if (_eqippedItemContainer == null)
				{
					_eqippedItemContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "eqippedItemContainer", cr2w, this);
				}
				return _eqippedItemContainer;
			}
			set
			{
				if (_eqippedItemContainer == value)
				{
					return;
				}
				_eqippedItemContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemPriceContainer")] 
		public inkWidgetReference ItemPriceContainer
		{
			get
			{
				if (_itemPriceContainer == null)
				{
					_itemPriceContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemPriceContainer", cr2w, this);
				}
				return _itemPriceContainer;
			}
			set
			{
				if (_itemPriceContainer == value)
				{
					return;
				}
				_itemPriceContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemPriceText")] 
		public inkTextWidgetReference ItemPriceText
		{
			get
			{
				if (_itemPriceText == null)
				{
					_itemPriceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemPriceText", cr2w, this);
				}
				return _itemPriceText;
			}
			set
			{
				if (_itemPriceText == value)
				{
					return;
				}
				_itemPriceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("sellItemsFullQuantity")] 
		public inkTextWidgetReference SellItemsFullQuantity
		{
			get
			{
				if (_sellItemsFullQuantity == null)
				{
					_sellItemsFullQuantity = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "sellItemsFullQuantity", cr2w, this);
				}
				return _sellItemsFullQuantity;
			}
			set
			{
				if (_sellItemsFullQuantity == value)
				{
					return;
				}
				_sellItemsFullQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sellItemsLimitedQuantity")] 
		public inkTextWidgetReference SellItemsLimitedQuantity
		{
			get
			{
				if (_sellItemsLimitedQuantity == null)
				{
					_sellItemsLimitedQuantity = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "sellItemsLimitedQuantity", cr2w, this);
				}
				return _sellItemsLimitedQuantity;
			}
			set
			{
				if (_sellItemsLimitedQuantity == value)
				{
					return;
				}
				_sellItemsLimitedQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("gameData")] 
		public CHandle<gameItemData> GameData
		{
			get
			{
				if (_gameData == null)
				{
					_gameData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "gameData", cr2w, this);
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
		[RED("closeAnimProxy")] 
		public CHandle<inkanimProxy> CloseAnimProxy
		{
			get
			{
				if (_closeAnimProxy == null)
				{
					_closeAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "closeAnimProxy", cr2w, this);
				}
				return _closeAnimProxy;
			}
			set
			{
				if (_closeAnimProxy == value)
				{
					return;
				}
				_closeAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<VendorSellJunkPopupData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<VendorSellJunkPopupData>) CR2WTypeManager.Create("handle:VendorSellJunkPopupData", "data", cr2w, this);
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("closeData")] 
		public CHandle<VendorSellJunkPopupCloseData> CloseData
		{
			get
			{
				if (_closeData == null)
				{
					_closeData = (CHandle<VendorSellJunkPopupCloseData>) CR2WTypeManager.Create("handle:VendorSellJunkPopupCloseData", "closeData", cr2w, this);
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

		public VendorSellJunkPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
