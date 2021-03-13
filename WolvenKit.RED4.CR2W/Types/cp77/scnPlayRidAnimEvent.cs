using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayRidAnimEvent : scnPlayFPPControlAnimEvent
	{
		[Ordinal(31)] [RED("ridVersinon")] public CUInt32 RidVersinon { get; set; }
		[Ordinal(32)] [RED("animResRefId")] public scnRidAnimationSRRefId AnimResRefId { get; set; }
		[Ordinal(33)] [RED("animOriginMarker")] public scnMarker AnimOriginMarker { get; set; }
		[Ordinal(34)] [RED("actorPlacement")] public CEnum<scnRidActorPlacement> ActorPlacement { get; set; }
		[Ordinal(35)] [RED("actorHasCollision")] public CBool ActorHasCollision { get; set; }
		[Ordinal(36)] [RED("blendInTrajectoryBone")] public CFloat BlendInTrajectoryBone { get; set; }

		public scnPlayRidAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
