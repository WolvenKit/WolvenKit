using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsDamageReceivedEvent : redEvent
	{
		private CHandle<gameeventsHitEvent> _hitEvent;
		private CFloat _totalDamageReceived;

		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetProperty(ref _hitEvent);
			set => SetProperty(ref _hitEvent, value);
		}

		[Ordinal(1)] 
		[RED("totalDamageReceived")] 
		public CFloat TotalDamageReceived
		{
			get => GetProperty(ref _totalDamageReceived);
			set => SetProperty(ref _totalDamageReceived, value);
		}
	}
}
