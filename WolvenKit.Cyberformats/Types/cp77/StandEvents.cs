using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StandEvents : LocomotionGroundEvents
	{
		[Ordinal(0)] [RED("previousStimTimeStamp")] public CFloat PreviousStimTimeStamp { get; set; }

		public StandEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
