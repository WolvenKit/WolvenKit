using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class InputContextTransitionEvents : InputContextTransition
	{
		[Ordinal(0)] 
		[RED("gameplaySettings")] 
		public CWeakHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetPropertyValue<CWeakHandle<GameplaySettingsSystem>>();
			set => SetPropertyValue<CWeakHandle<GameplaySettingsSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("onInputSchemeUpdatedCallback")] 
		public CHandle<redCallbackObject> OnInputSchemeUpdatedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("OnInputHintManagerInitializedChangedCallback")] 
		public CHandle<redCallbackObject> OnInputHintManagerInitializedChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("onInputSchemeChanged")] 
		public CBool OnInputSchemeChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hasControllerChanged")] 
		public CBool HasControllerChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hasControllerSchemeChanged")] 
		public CBool HasControllerSchemeChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isGameplayInputHintManagerInitialized")] 
		public CBool IsGameplayInputHintManagerInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isGameplayInputHintRefreshRequired")] 
		public CBool IsGameplayInputHintRefreshRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InputContextTransitionEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
