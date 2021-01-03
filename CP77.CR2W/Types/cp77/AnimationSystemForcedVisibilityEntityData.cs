using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimationSystemForcedVisibilityEntityData : IScriptable
	{
		[Ordinal(0)]  [RED("delayedForcedVisibilityInAnimSystemRequests")] public CArray<CHandle<ForcedVisibilityInAnimSystemData>> DelayedForcedVisibilityInAnimSystemRequests { get; set; }
		[Ordinal(1)]  [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(2)]  [RED("forcedVisibilityInAnimSystemRequests")] public CArray<CHandle<ForcedVisibilityInAnimSystemData>> ForcedVisibilityInAnimSystemRequests { get; set; }
		[Ordinal(3)]  [RED("hasVisibilityForcedInAnimSystem")] public CBool HasVisibilityForcedInAnimSystem { get; set; }
		[Ordinal(4)]  [RED("hasVisibilityForcedOnlyInFrustumInAnimSystem")] public CBool HasVisibilityForcedOnlyInFrustumInAnimSystem { get; set; }
		[Ordinal(5)]  [RED("owner")] public wCHandle<AnimationSystemForcedVisibilityManager> Owner { get; set; }

		public AnimationSystemForcedVisibilityEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
