using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplaySettingsSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("gameplaySettingsListener")] 
		public CHandle<GameplaySettingsListener> GameplaySettingsListener
		{
			get => GetPropertyValue<CHandle<GameplaySettingsListener>>();
			set => SetPropertyValue<CHandle<GameplaySettingsListener>>(value);
		}

		[Ordinal(1)] 
		[RED("wasEverJohnny")] 
		public CBool WasEverJohnny
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GameplaySettingsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
