using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterListenerOnTargetHPEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<TargetedObjectDeathListener> Listener
		{
			get => GetPropertyValue<CHandle<TargetedObjectDeathListener>>();
			set => SetPropertyValue<CHandle<TargetedObjectDeathListener>>(value);
		}

		[Ordinal(1)] 
		[RED("isFromListenerEvent")] 
		public CBool IsFromListenerEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnregisterListenerOnTargetHPEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
