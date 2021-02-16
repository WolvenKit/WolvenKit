using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ImmediateExitWithForceEvents : ExitingEventsBase
	{
		[Ordinal(3)] [RED("exitForce")] public gamestateMachineResultVector ExitForce { get; set; }
		[Ordinal(4)] [RED("bikeForce")] public gamestateMachineResultVector BikeForce { get; set; }
		[Ordinal(5)] [RED("knockOverBike")] public CHandle<KnockOverBikeEvent> KnockOverBike { get; set; }

		public ImmediateExitWithForceEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
