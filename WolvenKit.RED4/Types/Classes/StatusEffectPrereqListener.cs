using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusEffectPrereqListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatusEffectPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<StatusEffectPrereqState>>();
			set => SetPropertyValue<CWeakHandle<StatusEffectPrereqState>>(value);
		}

		public StatusEffectPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
