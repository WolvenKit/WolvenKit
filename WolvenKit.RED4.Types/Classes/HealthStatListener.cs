using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HealthStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<PlayerPuppet> OwnerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("healthEvent")] 
		public CHandle<HealthUpdateEvent> HealthEvent
		{
			get => GetPropertyValue<CHandle<HealthUpdateEvent>>();
			set => SetPropertyValue<CHandle<HealthUpdateEvent>>(value);
		}

		public HealthStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
