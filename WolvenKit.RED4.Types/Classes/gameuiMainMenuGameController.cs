using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMainMenuGameController : gameuiMenuItemListGameController
	{
		[Ordinal(6)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public gameuiMainMenuGameController()
		{
			BackgroundContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
