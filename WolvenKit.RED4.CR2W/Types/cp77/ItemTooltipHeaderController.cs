using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipHeaderController : ItemTooltipModuleController
	{
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemRarityText;
		private inkTextWidgetReference _itemTypeText;

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
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get
			{
				if (_itemRarityText == null)
				{
					_itemRarityText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemRarityText", cr2w, this);
				}
				return _itemRarityText;
			}
			set
			{
				if (_itemRarityText == value)
				{
					return;
				}
				_itemRarityText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get
			{
				if (_itemTypeText == null)
				{
					_itemTypeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemTypeText", cr2w, this);
				}
				return _itemTypeText;
			}
			set
			{
				if (_itemTypeText == value)
				{
					return;
				}
				_itemTypeText = value;
				PropertySet(this);
			}
		}

		public ItemTooltipHeaderController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
