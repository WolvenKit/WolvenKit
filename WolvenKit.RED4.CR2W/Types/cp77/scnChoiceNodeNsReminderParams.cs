using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsReminderParams : CVariable
	{
		[Ordinal(0)] [RED("reminderEnabled")] public CBool ReminderEnabled { get; set; }
		[Ordinal(1)] [RED("useCustomReminder")] public CBool UseCustomReminder { get; set; }
		[Ordinal(2)] [RED("reminderActor")] public scnActorId ReminderActor { get; set; }
		[Ordinal(3)] [RED("waitTimeForReminderA")] public scnSceneTime WaitTimeForReminderA { get; set; }
		[Ordinal(4)] [RED("waitTimeForReminderB")] public scnSceneTime WaitTimeForReminderB { get; set; }
		[Ordinal(5)] [RED("waitTimeForReminderC")] public scnSceneTime WaitTimeForReminderC { get; set; }
		[Ordinal(6)] [RED("waitTimeForLooping")] public scnSceneTime WaitTimeForLooping { get; set; }

		public scnChoiceNodeNsReminderParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
