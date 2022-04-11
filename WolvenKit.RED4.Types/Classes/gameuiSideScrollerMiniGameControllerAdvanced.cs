using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSideScrollerMiniGameControllerAdvanced : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiSideScrollerMiniGameControllerAdvanced()
		{
			GameplayCanvas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
