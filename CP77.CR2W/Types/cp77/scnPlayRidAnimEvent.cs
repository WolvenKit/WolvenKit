using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlayRidAnimEvent : scnPlayFPPControlAnimEvent
	{
		[Ordinal(0)]  [RED("actorHasCollision")] public CBool ActorHasCollision { get; set; }
		[Ordinal(1)]  [RED("actorPlacement")] public CEnum<scnRidActorPlacement> ActorPlacement { get; set; }
		[Ordinal(2)]  [RED("animOriginMarker")] public scnMarker AnimOriginMarker { get; set; }
		[Ordinal(3)]  [RED("animResRefId")] public scnRidAnimationSRRefId AnimResRefId { get; set; }
		[Ordinal(4)]  [RED("blendInTrajectoryBone")] public CFloat BlendInTrajectoryBone { get; set; }
		[Ordinal(5)]  [RED("ridVersinon")] public CUInt32 RidVersinon { get; set; }

		public scnPlayRidAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
