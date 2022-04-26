using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InputContextTransitionEvents : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("gameplaySettings")] 
		public CWeakHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetPropertyValue<CWeakHandle<GameplaySettingsSystem>>();
			set => SetPropertyValue<CWeakHandle<GameplaySettingsSystem>>(value);
		}

		public InputContextTransitionEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
