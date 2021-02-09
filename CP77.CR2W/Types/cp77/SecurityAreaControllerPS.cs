using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaControllerPS : MasterControllerPS
	{
		[Ordinal(104)]  [RED("system")] public CHandle<SecuritySystemControllerPS> System { get; set; }
		[Ordinal(105)]  [RED("usersInPerimeter")] public CArray<AreaEntry> UsersInPerimeter { get; set; }
		[Ordinal(106)]  [RED("isPlayerInside")] public CBool IsPlayerInside { get; set; }
		[Ordinal(107)]  [RED("securityAccessLevel")] public CEnum<ESecurityAccessLevel> SecurityAccessLevel { get; set; }
		[Ordinal(108)]  [RED("securityAreaType")] public CEnum<ESecurityAreaType> SecurityAreaType { get; set; }
		[Ordinal(109)]  [RED("eventsFilters")] public EventsFilters EventsFilters { get; set; }
		[Ordinal(110)]  [RED("areaTransitions")] public CArray<AreaTypeTransition> AreaTransitions { get; set; }
		[Ordinal(111)]  [RED("pendingDisableRequest")] public CBool PendingDisableRequest { get; set; }
		[Ordinal(112)]  [RED("lastOutput")] public OutputPersistentData LastOutput { get; set; }
		[Ordinal(113)]  [RED("questPlayerHasTriggeredCombat")] public CBool QuestPlayerHasTriggeredCombat { get; set; }
		[Ordinal(114)]  [RED("hasThisAreaReceivedCombatNotification")] public CBool HasThisAreaReceivedCombatNotification { get; set; }
		[Ordinal(115)]  [RED("pendingNotifyPlayerAboutTransition")] public CBool PendingNotifyPlayerAboutTransition { get; set; }

		public SecurityAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
