using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StartedUsingHealingItemOrCyberwarePrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listenerInfo")] 
		public CHandle<redCallbackObject> ListenerInfo
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public StartedUsingHealingItemOrCyberwarePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
