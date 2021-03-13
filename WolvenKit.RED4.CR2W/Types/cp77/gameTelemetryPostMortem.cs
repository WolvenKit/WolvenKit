using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryPostMortem : CVariable
	{
		[Ordinal(0)] [RED("crashVisitId")] public CString CrashVisitId { get; set; }
		[Ordinal(1)] [RED("playthroughId")] public CString PlaythroughId { get; set; }
		[Ordinal(2)] [RED("crashVersion")] public CString CrashVersion { get; set; }
		[Ordinal(3)] [RED("timeCrash")] public CString TimeCrash { get; set; }
		[Ordinal(4)] [RED("trackedQuest")] public gameTelemetryTrackedQuest TrackedQuest { get; set; }
		[Ordinal(5)] [RED("location")] public Vector3 Location { get; set; }
		[Ordinal(6)] [RED("sessionLength")] public CFloat SessionLength { get; set; }
		[Ordinal(7)] [RED("isOom")] public CBool IsOom { get; set; }

		public gameTelemetryPostMortem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
