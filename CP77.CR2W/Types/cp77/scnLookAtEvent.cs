using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnLookAtEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("basicData")] public scnLookAtBasicEventData BasicData { get; set; }

		public scnLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
