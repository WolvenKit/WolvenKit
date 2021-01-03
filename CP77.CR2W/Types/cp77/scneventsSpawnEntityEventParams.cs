using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsSpawnEntityEventParams : CVariable
	{
		[Ordinal(0)]  [RED("fallbackAnimTime")] public CFloat FallbackAnimTime { get; set; }
		[Ordinal(1)]  [RED("fallbackAnimationName")] public CName FallbackAnimationName { get; set; }
		[Ordinal(2)]  [RED("fallbackAnimset")] public rRef<animAnimSet> FallbackAnimset { get; set; }
		[Ordinal(3)]  [RED("fallbackCachedBones", 2)] public CStatic<scneventsSpawnEntityEventCachedFallbackBone> FallbackCachedBones { get; set; }
		[Ordinal(4)]  [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(5)]  [RED("referencePerformer")] public scnPerformerId ReferencePerformer { get; set; }
		[Ordinal(6)]  [RED("referencePerformerItemId")] public TweakDBID ReferencePerformerItemId { get; set; }
		[Ordinal(7)]  [RED("referencePerformerSlotId")] public TweakDBID ReferencePerformerSlotId { get; set; }

		public scneventsSpawnEntityEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
