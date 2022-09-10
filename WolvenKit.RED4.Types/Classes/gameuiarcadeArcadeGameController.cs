using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("minigame")] 
		public CEnum<gameuiarcadeArcadeMinigame> Minigame
		{
			get => GetPropertyValue<CEnum<gameuiarcadeArcadeMinigame>>();
			set => SetPropertyValue<CEnum<gameuiarcadeArcadeMinigame>>(value);
		}

		[Ordinal(3)] 
		[RED("defaultScreenTransitionTotalTime")] 
		public CFloat DefaultScreenTransitionTotalTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("screenTransitionWidget")] 
		public inkImageWidgetReference ScreenTransitionWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("menu")] 
		public inkWidgetReference Menu
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("gameplay")] 
		public inkWidgetReference Gameplay
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("scoreboard")] 
		public inkWidgetReference Scoreboard
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeArcadeGameController()
		{
			DefaultScreenTransitionTotalTime = 1.000000F;
			ScreenTransitionWidget = new();
			Menu = new();
			Gameplay = new();
			Scoreboard = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
