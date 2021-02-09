using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SprintEvents : LocomotionGroundEvents
	{
		[Ordinal(0)]  [RED("previousStimTimeStamp")] public CFloat PreviousStimTimeStamp { get; set; }
		[Ordinal(1)]  [RED("reloadModifier")] public CHandle<gameStatModifierData> ReloadModifier { get; set; }
		[Ordinal(2)]  [RED("isInSecondSprint")] public CBool IsInSecondSprint { get; set; }
		[Ordinal(3)]  [RED("sprintModifier")] public CHandle<gameStatModifierData> SprintModifier { get; set; }

		public SprintEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
