using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedCrowdReactionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetPropertyValue<CHandle<senseStimuliEvent>>();
			set => SetPropertyValue<CHandle<senseStimuliEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleFearPhase")] 
		public CInt32 VehicleFearPhase
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
