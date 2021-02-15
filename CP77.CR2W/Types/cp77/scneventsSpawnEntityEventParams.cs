using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsSpawnEntityEventParams : CVariable
	{
		[Ordinal(0)] [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(1)] [RED("referencePerformer")] public scnPerformerId ReferencePerformer { get; set; }
		[Ordinal(2)] [RED("referencePerformerSlotId")] public TweakDBID ReferencePerformerSlotId { get; set; }
		[Ordinal(3)] [RED("referencePerformerItemId")] public TweakDBID ReferencePerformerItemId { get; set; }
		[Ordinal(4)] [RED("fallbackCachedBones", 2)] public CStatic<scneventsSpawnEntityEventCachedFallbackBone> FallbackCachedBones { get; set; }
		[Ordinal(5)] [RED("fallbackAnimset")] public rRef<animAnimSet> FallbackAnimset { get; set; }
		[Ordinal(6)] [RED("fallbackAnimationName")] public CName FallbackAnimationName { get; set; }
		[Ordinal(7)] [RED("fallbackAnimTime")] public CFloat FallbackAnimTime { get; set; }

		public scneventsSpawnEntityEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
