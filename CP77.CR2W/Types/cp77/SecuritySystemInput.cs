using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemInput : SecurityAreaEvent
	{
		[Ordinal(27)] [RED("lastKnownPosition")] public Vector4 LastKnownPosition { get; set; }
		[Ordinal(28)] [RED("notifier")] public CHandle<SharedGameplayPS> Notifier { get; set; }
		[Ordinal(29)] [RED("type")] public CEnum<ESecurityNotificationType> Type { get; set; }
		[Ordinal(30)] [RED("objectOfInterest")] public wCHandle<gameObject> ObjectOfInterest { get; set; }
		[Ordinal(31)] [RED("canPerformReprimand")] public CBool CanPerformReprimand { get; set; }
		[Ordinal(32)] [RED("shouldLeadReprimend")] public CBool ShouldLeadReprimend { get; set; }
		[Ordinal(33)] [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(34)] [RED("customRecipientsList")] public CArray<entEntityID> CustomRecipientsList { get; set; }
		[Ordinal(35)] [RED("isSharingRestricted")] public CBool IsSharingRestricted { get; set; }
		[Ordinal(36)] [RED("debugReporterCharRecord")] public CHandle<gamedataCharacter_Record> DebugReporterCharRecord { get; set; }
		[Ordinal(37)] [RED("stimTypeTriggeredAlarm")] public CEnum<gamedataStimType> StimTypeTriggeredAlarm { get; set; }

		public SecuritySystemInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
