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
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(1)] 
		[RED("ItemsToDisplay")] 
		public CArray<InventoryItemData> ItemsToDisplay
		{
			get => GetProperty(ref _itemsToDisplay);
			set => SetProperty(ref _itemsToDisplay, value);
		}

		[Ordinal(2)] 
		[RED("ShowUnequipButton")] 
		public CBool ShowUnequipButton
		{
			get => GetProperty(ref _showUnequipButton);
			set => SetProperty(ref _showUnequipButton, value);
		}

		[Ordinal(3)] 
		[RED("ShowcaseItem")] 
		public InventoryItemData ShowcaseItem
		{
			get => GetProperty(ref _showcaseItem);
			set => SetProperty(ref _showcaseItem, value);
		}

		[Ordinal(4)] 
		[RED("DisplayShowcase")] 
		public CBool DisplayShowcase
		{
			get => GetProperty(ref _displayShowcase);
			set => SetProperty(ref _displayShowcase, value);
		}

		[Ordinal(5)] 
		[RED("ForceDouble")] 
		public CBool ForceDouble
		{
			get => GetProperty(ref _forceDouble);
			set => SetProperty(ref _forceDouble, value);
		}

		public InventoryComboBoxData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
