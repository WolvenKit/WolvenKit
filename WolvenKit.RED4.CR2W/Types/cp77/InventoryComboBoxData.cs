using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryComboBoxData : CVariable
	{
		private CString _message;
		private CArray<InventoryItemData> _itemsToDisplay;
		private CBool _showUnequipButton;
		private InventoryItemData _showcaseItem;
		private CBool _displayShowcase;
		private CBool _forceDouble;

		[Ordinal(0)] 
		[RED("Message")] 
		public CString Message
		{
			get
			{
				if (_message == null)
				{
					_message = (CString) CR2WTypeManager.Create("String", "Message", cr2w, this);
				}
				return _message;
			}
			set
			{
				if (_message == value)
				{
					return;
				}
				_message = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ItemsToDisplay")] 
		public CArray<InventoryItemData> ItemsToDisplay
		{
			get
			{
				if (_itemsToDisplay == null)
				{
					_itemsToDisplay = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "ItemsToDisplay", cr2w, this);
				}
				return _itemsToDisplay;
			}
			set
			{
				if (_itemsToDisplay == value)
				{
					return;
				}
				_itemsToDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ShowUnequipButton")] 
		public CBool ShowUnequipButton
		{
			get
			{
				if (_showUnequipButton == null)
				{
					_showUnequipButton = (CBool) CR2WTypeManager.Create("Bool", "ShowUnequipButton", cr2w, this);
				}
				return _showUnequipButton;
			}
			set
			{
				if (_showUnequipButton == value)
				{
					return;
				}
				_showUnequipButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ShowcaseItem")] 
		public InventoryItemData ShowcaseItem
		{
			get
			{
				if (_showcaseItem == null)
				{
					_showcaseItem = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "ShowcaseItem", cr2w, this);
				}
				return _showcaseItem;
			}
			set
			{
				if (_showcaseItem == value)
				{
					return;
				}
				_showcaseItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("DisplayShowcase")] 
		public CBool DisplayShowcase
		{
			get
			{
				if (_displayShowcase == null)
				{
					_displayShowcase = (CBool) CR2WTypeManager.Create("Bool", "DisplayShowcase", cr2w, this);
				}
				return _displayShowcase;
			}
			set
			{
				if (_displayShowcase == value)
				{
					return;
				}
				_displayShowcase = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ForceDouble")] 
		public CBool ForceDouble
		{
			get
			{
				if (_forceDouble == null)
				{
					_forceDouble = (CBool) CR2WTypeManager.Create("Bool", "ForceDouble", cr2w, this);
				}
				return _forceDouble;
			}
			set
			{
				if (_forceDouble == value)
				{
					return;
				}
				_forceDouble = value;
				PropertySet(this);
			}
		}

		public InventoryComboBoxData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
