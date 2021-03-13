using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAddIdleWithBlendAnimEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(7)] [RED("actorComponent")] public CName ActorComponent { get; set; }
		[Ordinal(8)] [RED("targetWeight")] public CFloat TargetWeight { get; set; }

		public scnAddIdleWithBlendAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
