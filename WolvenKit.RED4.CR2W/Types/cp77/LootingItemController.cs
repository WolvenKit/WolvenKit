using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingItemController : inkWidgetLogicController
	{
		private CHandle<inkTextWidget> _itemNameText;
		private CBool _isCurrentlySelected;
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _itemType;
		private inkTextWidgetReference _itemWeight;
		private inkTextWidgetReference _itemQuantity;
		private inkWidgetReference _itemQualityBar;
		private inkWidgetReference _itemSelection;
		private inkImageWidgetReference _itemIcon;

		[Ordinal(1)] 
		[RED("itemNameText")] 
		public CHandle<inkTextWidget> ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(2)] 
		[RED("isCurrentlySelected")] 
		public CBool IsCurrentlySelected
		{
			get => GetProperty(ref _isCurrentlySelected);
			set => SetProperty(ref _isCurrentlySelected, value);
		}

		[Ordinal(3)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(4)] 
		[RED("itemType")] 
		public inkTextWidgetReference ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(5)] 
		[RED("itemWeight")] 
		public inkTextWidgetReference ItemWeight
		{
			get => GetProperty(ref _itemWeight);
			set => SetProperty(ref _itemWeight, value);
		}

		[Ordinal(6)] 
		[RED("itemQuantity")] 
		public inkTextWidgetReference ItemQuantity
		{
			get => GetProperty(ref _itemQuantity);
			set => SetProperty(ref _itemQuantity, value);
		}

		[Ordinal(7)] 
		[RED("itemQualityBar")] 
		public inkWidgetReference ItemQualityBar
		{
			get => GetProperty(ref _itemQualityBar);
			set => SetProperty(ref _itemQualityBar, value);
		}

		[Ordinal(8)] 
		[RED("itemSelection")] 
		public inkWidgetReference ItemSelection
		{
			get => GetProperty(ref _itemSelection);
			set => SetProperty(ref _itemSelection, value);
		}

		[Ordinal(9)] 
		[RED("itemIcon")] 
		public inkImageWidgetReference ItemIcon
		{
			get => GetProperty(ref _itemIcon);
			set => SetProperty(ref _itemIcon, value);
		}

		public LootingItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
