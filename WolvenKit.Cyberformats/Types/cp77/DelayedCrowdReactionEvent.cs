using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DelayedCrowdReactionEvent : redEvent
	{
		[Ordinal(0)] [RED("stimEvent")] public CHandle<senseStimuliEvent> StimEvent { get; set; }
		[Ordinal(1)] [RED("vehicleFearPhase")] public CInt32 VehicleFearPhase { get; set; }

		public DelayedCrowdReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
