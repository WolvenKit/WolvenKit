using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsActorReminderParams : ISerializable
	{
		[Ordinal(0)]  [RED("useCustomReminder")] public CBool UseCustomReminder { get; set; }
		[Ordinal(1)]  [RED("reminderActor")] public scnActorId ReminderActor { get; set; }
		[Ordinal(2)]  [RED("waitTimeForReminderA")] public scnSceneTime WaitTimeForReminderA { get; set; }
		[Ordinal(3)]  [RED("waitTimeForReminderB")] public scnSceneTime WaitTimeForReminderB { get; set; }
		[Ordinal(4)]  [RED("waitTimeForReminderC")] public scnSceneTime WaitTimeForReminderC { get; set; }
		[Ordinal(5)]  [RED("waitTimeForLooping")] public scnSceneTime WaitTimeForLooping { get; set; }

		public scnChoiceNodeNsActorReminderParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
