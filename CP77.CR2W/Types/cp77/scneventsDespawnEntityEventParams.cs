using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsDespawnEntityEventParams : CVariable
	{
		[Ordinal(0)] [RED("performer")] public scnPerformerId Performer { get; set; }

		public scneventsDespawnEntityEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
