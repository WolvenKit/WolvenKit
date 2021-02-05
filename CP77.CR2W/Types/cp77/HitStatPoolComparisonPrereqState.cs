using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitStatPoolComparisonPrereqState : GenericHitPrereqState
	{
		[Ordinal(0)]  [RED("listener")] public CHandle<HitCallback> Listener { get; set; }
		[Ordinal(1)]  [RED("hitEvent")] public CHandle<gameeventsHitEvent> HitEvent { get; set; }

		public HitStatPoolComparisonPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
