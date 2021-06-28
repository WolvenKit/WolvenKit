using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedCrowdReactionEvent : redEvent
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

		public DelayedCrowdReactionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
