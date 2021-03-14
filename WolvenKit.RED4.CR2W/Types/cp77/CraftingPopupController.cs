using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingPopupController : gameuiWidgetGameController
	{
		private inkWidgetReference _tooltipContainer;
		private inkImageWidgetReference _craftIcon;
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _itemTopName;
		private inkTextWidgetReference _itemQuality;
		private inkTextWidgetReference _headerText;
		private inkWidgetReference _closeButton;
		private inkWidgetReference _buttonHintsRoot;
		private inkWidgetLibraryReference _libraryPath;
		private wCHandle<AGenericTooltipController> _itemTooltip;
		private wCHandle<inkButtonController> _closeButtonController;
		private CHandle<CraftingPopupData> _data;

		[Ordinal(2)] 
		[RED("tooltipContainer")] 
		public inkWidgetReference TooltipContainer
		{
			get
			{
				if (_tooltipContainer == null)
				{
					_tooltipContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipContainer", cr2w, this);
				}
				return _tooltipContainer;
			}
			set
			{
				if (_tooltipContainer == value)
				{
					return;
				}
				_tooltipContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("craftIcon")] 
		public inkImageWidgetReference CraftIcon
		{
			get
			{
				if (_craftIcon == null)
				{
					_craftIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "craftIcon", cr2w, this);
				}
				return _craftIcon;
			}
			set
			{
				if (_craftIcon == value)
				{
					return;
				}
				_craftIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemTopName")] 
		public inkTextWidgetReference ItemTopName
		{
			get
			{
				if (_itemTopName == null)
				{
					_itemTopName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemTopName", cr2w, this);
				}
				return _itemTopName;
			}
			set
			{
				if (_itemTopName == value)
				{
					return;
				}
				_itemTopName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemQuality")] 
		public inkTextWidgetReference ItemQuality
		{
			get
			{
				if (_itemQuality == null)
				{
					_itemQuality = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemQuality", cr2w, this);
				}
				return _itemQuality;
			}
			set
			{
				if (_itemQuality == value)
				{
					return;
				}
				_itemQuality = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get
			{
				if (_headerText == null)
				{
					_headerText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "headerText", cr2w, this);
				}
				return _headerText;
			}
			set
			{
				if (_headerText == value)
				{
					return;
				}
				_headerText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("closeButton")] 
		public inkWidgetReference CloseButton
		{
			get
			{
				if (_closeButton == null)
				{
					_closeButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "closeButton", cr2w, this);
				}
				return _closeButton;
			}
			set
			{
				if (_closeButton == value)
				{
					return;
				}
				_closeButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("itemTooltip")] 
		public wCHandle<AGenericTooltipController> ItemTooltip
		{
			get
			{
				if (_itemTooltip == null)
				{
					_itemTooltip = (wCHandle<AGenericTooltipController>) CR2WTypeManager.Create("whandle:AGenericTooltipController", "itemTooltip", cr2w, this);
				}
				return _itemTooltip;
			}
			set
			{
				if (_itemTooltip == value)
				{
					return;
				}
				_itemTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("closeButtonController")] 
		public wCHandle<inkButtonController> CloseButtonController
		{
			get
			{
				if (_closeButtonController == null)
				{
					_closeButtonController = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "closeButtonController", cr2w, this);
				}
				return _closeButtonController;
			}
			set
			{
				if (_closeButtonController == value)
				{
					return;
				}
				_closeButtonController = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<CraftingPopupData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<CraftingPopupData>) CR2WTypeManager.Create("handle:CraftingPopupData", "data", cr2w, this);
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

		public CraftingPopupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
