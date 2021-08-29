using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HealthStatListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<PlayerPuppet> _ownerPuppet;
		private CHandle<HealthUpdateEvent> _healthEvent;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<PlayerPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		[Ordinal(1)] 
		[RED("healthEvent")] 
		public CHandle<HealthUpdateEvent> HealthEvent
		{
			get => GetProperty(ref _healthEvent);
			set => SetProperty(ref _healthEvent, value);
		}
	}
}
