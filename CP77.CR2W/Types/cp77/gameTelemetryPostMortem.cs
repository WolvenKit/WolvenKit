using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryPostMortem : CVariable
	{
		[Ordinal(0)]  [RED("crashVersion")] public CString CrashVersion { get; set; }
		[Ordinal(1)]  [RED("crashVisitId")] public CString CrashVisitId { get; set; }
		[Ordinal(2)]  [RED("isOom")] public CBool IsOom { get; set; }
		[Ordinal(3)]  [RED("location")] public Vector3 Location { get; set; }
		[Ordinal(4)]  [RED("playthroughId")] public CString PlaythroughId { get; set; }
		[Ordinal(5)]  [RED("sessionLength")] public CFloat SessionLength { get; set; }
		[Ordinal(6)]  [RED("timeCrash")] public CString TimeCrash { get; set; }
		[Ordinal(7)]  [RED("trackedQuest")] public gameTelemetryTrackedQuest TrackedQuest { get; set; }

		public gameTelemetryPostMortem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
