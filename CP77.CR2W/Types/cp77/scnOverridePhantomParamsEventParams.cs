using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnOverridePhantomParamsEventParams : CVariable
	{
		[Ordinal(0)] [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(1)] [RED("overrideSpawnEffect")] public CName OverrideSpawnEffect { get; set; }
		[Ordinal(2)] [RED("overrideIdleEffect")] public CName OverrideIdleEffect { get; set; }

		public scnOverridePhantomParamsEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
