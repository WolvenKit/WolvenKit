using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemInput : SecurityAreaEvent
	{
		[Ordinal(0)]  [RED("canPerformReprimand")] public CBool CanPerformReprimand { get; set; }
		[Ordinal(1)]  [RED("customRecipientsList")] public CArray<entEntityID> CustomRecipientsList { get; set; }
		[Ordinal(2)]  [RED("debugReporterCharRecord")] public CHandle<gamedataCharacter_Record> DebugReporterCharRecord { get; set; }
		[Ordinal(3)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(4)]  [RED("isSharingRestricted")] public CBool IsSharingRestricted { get; set; }
		[Ordinal(5)]  [RED("lastKnownPosition")] public Vector4 LastKnownPosition { get; set; }
		[Ordinal(6)]  [RED("notifier")] public CHandle<SharedGameplayPS> Notifier { get; set; }
		[Ordinal(7)]  [RED("objectOfInterest")] public wCHandle<gameObject> ObjectOfInterest { get; set; }
		[Ordinal(8)]  [RED("shouldLeadReprimend")] public CBool ShouldLeadReprimend { get; set; }
		[Ordinal(9)]  [RED("stimTypeTriggeredAlarm")] public CEnum<gamedataStimType> StimTypeTriggeredAlarm { get; set; }
		[Ordinal(10)]  [RED("type")] public CEnum<ESecurityNotificationType> Type { get; set; }

		public SecuritySystemInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
