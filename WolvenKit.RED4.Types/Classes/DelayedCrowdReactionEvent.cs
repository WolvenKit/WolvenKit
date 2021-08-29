using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedCrowdReactionEvent : redEvent
	{
		private CHandle<senseStimuliEvent> _stimEvent;
		private CInt32 _vehicleFearPhase;

		[Ordinal(0)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetProperty(ref _stimEvent);
			set => SetProperty(ref _stimEvent, value);
		}

		[Ordinal(1)] 
		[RED("vehicleFearPhase")] 
		public CInt32 VehicleFearPhase
		{
			get => GetProperty(ref _vehicleFearPhase);
			set => SetProperty(ref _vehicleFearPhase, value);
		}
	}
}
