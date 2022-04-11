using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddStatusEffectListenerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<StatusEffectTriggerListener> Listener
		{
			get => GetPropertyValue<CHandle<StatusEffectTriggerListener>>();
			set => SetPropertyValue<CHandle<StatusEffectTriggerListener>>(value);
		}

		public AddStatusEffectListenerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
