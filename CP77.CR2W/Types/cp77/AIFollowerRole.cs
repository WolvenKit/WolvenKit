using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFollowerRole : AIRole
	{
		[Ordinal(0)]  [RED("followerRef")] public gameEntityReference FollowerRef { get; set; }
		[Ordinal(1)]  [RED("followTarget")] public wCHandle<gameObject> FollowTarget { get; set; }
		[Ordinal(2)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(3)]  [RED("attitudeGroupName")] public CName AttitudeGroupName { get; set; }
		[Ordinal(4)]  [RED("followTargetSquads")] public CArray<CName> FollowTargetSquads { get; set; }
		[Ordinal(5)]  [RED("playerCombatListener")] public CUInt32 PlayerCombatListener { get; set; }
		[Ordinal(6)]  [RED("lastStealthLeaveTimeStamp")] public EngineTime LastStealthLeaveTimeStamp { get; set; }
		[Ordinal(7)]  [RED("friendlyTargetSlotListener")] public CHandle<gameAttachmentSlotsScriptListener> FriendlyTargetSlotListener { get; set; }
		[Ordinal(8)]  [RED("ownerTargetSlotListener")] public CHandle<gameAttachmentSlotsScriptListener> OwnerTargetSlotListener { get; set; }
		[Ordinal(9)]  [RED("isFriendMelee")] public CBool IsFriendMelee { get; set; }
		[Ordinal(10)]  [RED("isOwnerSniper")] public CBool IsOwnerSniper { get; set; }

		public AIFollowerRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
