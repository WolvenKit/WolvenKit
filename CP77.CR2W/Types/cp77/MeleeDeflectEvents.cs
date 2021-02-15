using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeDeflectEvents : MeleeEventsTransition
	{
		[Ordinal(0)] [RED("deflectStatFlag")] public CHandle<gameStatModifierData> DeflectStatFlag { get; set; }

		public MeleeDeflectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
