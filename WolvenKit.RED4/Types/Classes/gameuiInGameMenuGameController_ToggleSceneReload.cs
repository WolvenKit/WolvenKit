using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInGameMenuGameController_ToggleSceneReload : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldAutoReloadPuppets")] 
		public CBool ShouldAutoReloadPuppets
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("shouldReloadNow")] 
		public CBool ShouldReloadNow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiInGameMenuGameController_ToggleSceneReload()
		{
			ShouldAutoReloadPuppets = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
