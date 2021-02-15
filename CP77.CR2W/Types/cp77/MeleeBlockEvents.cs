using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeBlockEvents : MeleeEventsTransition
	{
		[Ordinal(0)] [RED("blockStatFlag")] public CHandle<gameStatModifierData> BlockStatFlag { get; set; }

		public MeleeBlockEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
