using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputContextTransitionEvents : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("gameplaySettings")] 
		public CWeakHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetPropertyValue<CWeakHandle<GameplaySettingsSystem>>();
			set => SetPropertyValue<CWeakHandle<GameplaySettingsSystem>>(value);
		}
	}
}
