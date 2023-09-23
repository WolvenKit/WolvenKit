using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterGameplayController : gameuiarcadeArcadeGameplayController
	{
		[Ordinal(3)] 
		[RED("player")] 
		public inkWidgetReference Player
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("hud")] 
		public inkWidgetReference Hud
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("levelContainer")] 
		public inkWidgetReference LevelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeShooterGameplayController()
		{
			Score = new inkWidgetReference();
			PauseText = new inkWidgetReference();
			Player = new inkWidgetReference();
			Hud = new inkWidgetReference();
			LevelContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
