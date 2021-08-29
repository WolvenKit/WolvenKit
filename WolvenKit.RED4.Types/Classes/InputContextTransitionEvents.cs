using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputContextTransitionEvents : DefaultTransition
	{
		private CWeakHandle<GameplaySettingsSystem> _gameplaySettings;

		[Ordinal(0)] 
		[RED("gameplaySettings")] 
		public CWeakHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetProperty(ref _gameplaySettings);
			set => SetProperty(ref _gameplaySettings, value);
		}
	}
}
