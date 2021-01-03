using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAddIdleWithBlendAnimEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("actorComponent")] public CName ActorComponent { get; set; }
		[Ordinal(1)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(2)]  [RED("targetWeight")] public CFloat TargetWeight { get; set; }

		public scnAddIdleWithBlendAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
