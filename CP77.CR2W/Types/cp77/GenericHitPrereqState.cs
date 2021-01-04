using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericHitPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("hitEvent")] public CHandle<gameeventsHitEvent> HitEvent { get; set; }
		[Ordinal(1)]  [RED("listener")] public CHandle<HitCallback> Listener { get; set; }

		public GenericHitPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
