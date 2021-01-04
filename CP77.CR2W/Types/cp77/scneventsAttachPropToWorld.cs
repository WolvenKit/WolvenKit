using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToWorld : scnSceneEvent
	{
		[Ordinal(0)]  [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(1)]  [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }
		[Ordinal(2)]  [RED("fallbackAnimTime")] public CFloat FallbackAnimTime { get; set; }
		[Ordinal(3)]  [RED("fallbackAnimationName")] public CName FallbackAnimationName { get; set; }
		[Ordinal(4)]  [RED("fallbackAnimset")] public rRef<animAnimSet> FallbackAnimset { get; set; }
		[Ordinal(5)]  [RED("fallbackCachedBones", 2)] public CStatic<scneventsAttachPropToWorldCachedFallbackBone> FallbackCachedBones { get; set; }
		[Ordinal(6)]  [RED("offsetMode")] public CEnum<scnOffsetMode> OffsetMode { get; set; }
		[Ordinal(7)]  [RED("propId")] public scnPropId PropId { get; set; }
		[Ordinal(8)]  [RED("referencePerformer")] public scnPerformerId ReferencePerformer { get; set; }
		[Ordinal(9)]  [RED("referencePerformerItemId")] public TweakDBID ReferencePerformerItemId { get; set; }
		[Ordinal(10)]  [RED("referencePerformerSlotId")] public TweakDBID ReferencePerformerSlotId { get; set; }

		public scneventsAttachPropToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
