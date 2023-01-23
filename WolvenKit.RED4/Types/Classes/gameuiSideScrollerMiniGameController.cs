using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSideScrollerMiniGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("gameName")] 
		public CName GameName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiSideScrollerMiniGameController()
		{
			GameplayCanvas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
