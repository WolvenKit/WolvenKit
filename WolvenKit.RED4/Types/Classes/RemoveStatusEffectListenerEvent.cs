using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveStatusEffectListenerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<StatusEffectTriggerListener> Listener
		{
			get => GetPropertyValue<CHandle<StatusEffectTriggerListener>>();
			set => SetPropertyValue<CHandle<StatusEffectTriggerListener>>(value);
		}

		public RemoveStatusEffectListenerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
