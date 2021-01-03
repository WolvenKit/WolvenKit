using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("areaTransitions")] public CArray<AreaTypeTransition> AreaTransitions { get; set; }
		[Ordinal(1)]  [RED("eventsFilters")] public EventsFilters EventsFilters { get; set; }
		[Ordinal(2)]  [RED("hasThisAreaReceivedCombatNotification")] public CBool HasThisAreaReceivedCombatNotification { get; set; }
		[Ordinal(3)]  [RED("isPlayerInside")] public CBool IsPlayerInside { get; set; }
		[Ordinal(4)]  [RED("lastOutput")] public OutputPersistentData LastOutput { get; set; }
		[Ordinal(5)]  [RED("pendingDisableRequest")] public CBool PendingDisableRequest { get; set; }
		[Ordinal(6)]  [RED("pendingNotifyPlayerAboutTransition")] public CBool PendingNotifyPlayerAboutTransition { get; set; }
		[Ordinal(7)]  [RED("questPlayerHasTriggeredCombat")] public CBool QuestPlayerHasTriggeredCombat { get; set; }
		[Ordinal(8)]  [RED("securityAccessLevel")] public CEnum<ESecurityAccessLevel> SecurityAccessLevel { get; set; }
		[Ordinal(9)]  [RED("securityAreaType")] public CEnum<ESecurityAreaType> SecurityAreaType { get; set; }
		[Ordinal(10)]  [RED("system")] public CHandle<SecuritySystemControllerPS> System { get; set; }
		[Ordinal(11)]  [RED("usersInPerimeter")] public CArray<AreaEntry> UsersInPerimeter { get; set; }

		public SecurityAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
