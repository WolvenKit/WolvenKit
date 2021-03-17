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
			get => GetProperty(ref _tooltipContainer);
			set => SetProperty(ref _tooltipContainer, value);
		}

		[Ordinal(3)] 
		[RED("craftIcon")] 
		public inkImageWidgetReference CraftIcon
		{
			get => GetProperty(ref _craftIcon);
			set => SetProperty(ref _craftIcon, value);
		}

		[Ordinal(4)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(5)] 
		[RED("itemTopName")] 
		public inkTextWidgetReference ItemTopName
		{
			get => GetProperty(ref _itemTopName);
			set => SetProperty(ref _itemTopName, value);
		}

		[Ordinal(6)] 
		[RED("itemQuality")] 
		public inkTextWidgetReference ItemQuality
		{
			get => GetProperty(ref _itemQuality);
			set => SetProperty(ref _itemQuality, value);
		}

		[Ordinal(7)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get => GetProperty(ref _headerText);
			set => SetProperty(ref _headerText, value);
		}

		[Ordinal(8)] 
		[RED("closeButton")] 
		public inkWidgetReference CloseButton
		{
			get => GetProperty(ref _closeButton);
			set => SetProperty(ref _closeButton, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetProperty(ref _buttonHintsRoot);
			set => SetProperty(ref _buttonHintsRoot, value);
		}

		[Ordinal(10)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(11)] 
		[RED("itemTooltip")] 
		public wCHandle<AGenericTooltipController> ItemTooltip
		{
			get => GetProperty(ref _itemTooltip);
			set => SetProperty(ref _itemTooltip, value);
		}

		[Ordinal(12)] 
		[RED("closeButtonController")] 
		public wCHandle<inkButtonController> CloseButtonController
		{
			get => GetProperty(ref _closeButtonController);
			set => SetProperty(ref _closeButtonController, value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<CraftingPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public CraftingPopupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
