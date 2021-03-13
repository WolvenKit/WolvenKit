using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ForcedVisibilityInAnimSystemData : IScriptable
	{
		[Ordinal(0)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(1)] [RED("delayID")] public gameDelayID DelayID { get; set; }
		[Ordinal(2)] [RED("forcedVisibleOnlyInFrustum")] public CBool ForcedVisibleOnlyInFrustum { get; set; }

		public ForcedVisibilityInAnimSystemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
