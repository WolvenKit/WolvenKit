using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class WeaponEventsTransition : WeaponTransition
	{
		[Ordinal(3)] 
		[RED("scriptInterface")] 
		public CHandle<gamestateMachineGameScriptInterface> ScriptInterface
		{
			get => GetPropertyValue<CHandle<gamestateMachineGameScriptInterface>>();
			set => SetPropertyValue<CHandle<gamestateMachineGameScriptInterface>>(value);
		}

		[Ordinal(4)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>(value);
		}

		public WeaponEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
