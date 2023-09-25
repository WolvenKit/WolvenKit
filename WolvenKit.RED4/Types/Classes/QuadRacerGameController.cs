using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuadRacerGameController : gameuiSideScrollerMiniGameController
	{
		[Ordinal(4)] 
		[RED("gameMenu")] 
		public inkWidgetReference GameMenu
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("scoreboardMenu")] 
		public inkWidgetReference ScoreboardMenu
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public QuadRacerGameController()
		{
			GameMenu = new inkWidgetReference();
			ScoreboardMenu = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
