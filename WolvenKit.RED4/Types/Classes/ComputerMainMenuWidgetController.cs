using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerMainMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("menuButtonsListWidget")] 
		public inkWidgetReference MenuButtonsListWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("computerMenuButtonWidgetsData")] 
		public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData
		{
			get => GetPropertyValue<CArray<SComputerMenuButtonWidgetPackage>>();
			set => SetPropertyValue<CArray<SComputerMenuButtonWidgetPackage>>(value);
		}

		public ComputerMainMenuWidgetController()
		{
			MenuButtonsListWidget = new inkWidgetReference();
			ComputerMenuButtonWidgetsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
