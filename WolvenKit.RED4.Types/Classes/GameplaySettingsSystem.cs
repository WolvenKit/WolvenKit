using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplaySettingsSystem : gameScriptableSystem
	{
		private CHandle<GameplaySettingsListener> _gameplaySettingsListener;
		private CBool _wasEverJohnny;

		[Ordinal(0)] 
		[RED("gameplaySettingsListener")] 
		public CHandle<GameplaySettingsListener> GameplaySettingsListener
		{
			get => GetProperty(ref _gameplaySettingsListener);
			set => SetProperty(ref _gameplaySettingsListener, value);
		}

		[Ordinal(1)] 
		[RED("wasEverJohnny")] 
		public CBool WasEverJohnny
		{
			get => GetProperty(ref _wasEverJohnny);
			set => SetProperty(ref _wasEverJohnny, value);
		}
	}
}
