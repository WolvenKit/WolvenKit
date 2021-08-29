using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerMainMenuWidgetController : inkWidgetLogicController
	{
		private inkWidgetReference _menuButtonsListWidget;
		private CBool _isInitialized;
		private CArray<SComputerMenuButtonWidgetPackage> _computerMenuButtonWidgetsData;

		[Ordinal(1)] 
		[RED("menuButtonsListWidget")] 
		public inkWidgetReference MenuButtonsListWidget
		{
			get => GetProperty(ref _menuButtonsListWidget);
			set => SetProperty(ref _menuButtonsListWidget, value);
		}

		[Ordinal(2)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(3)] 
		[RED("computerMenuButtonWidgetsData")] 
		public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData
		{
			get => GetProperty(ref _computerMenuButtonWidgetsData);
			set => SetProperty(ref _computerMenuButtonWidgetsData, value);
		}
	}
}
