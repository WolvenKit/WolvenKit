using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingPopupController : gameuiWidgetGameController
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
		private CWeakHandle<AGenericTooltipController> _itemTooltip;
		private CWeakHandle<inkButtonController> _closeButtonController;
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
		public CWeakHandle<AGenericTooltipController> ItemTooltip
		{
			get => GetProperty(ref _itemTooltip);
			set => SetProperty(ref _itemTooltip, value);
		}

		[Ordinal(12)] 
		[RED("closeButtonController")] 
		public CWeakHandle<inkButtonController> CloseButtonController
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
	}
}
