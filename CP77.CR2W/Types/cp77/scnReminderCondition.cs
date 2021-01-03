using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnReminderCondition : ISerializable
	{
		[Ordinal(0)]  [RED("playing")] public CBool Playing { get; set; }
		[Ordinal(1)]  [RED("processStep")] public CEnum<scnReminderConditionProcessStep> ProcessStep { get; set; }
		[Ordinal(2)]  [RED("reminderActor")] public scnActorId ReminderActor { get; set; }
		[Ordinal(3)]  [RED("reminderParams")] public scnChoiceNodeNsReminderParams ReminderParams { get; set; }
		[Ordinal(4)]  [RED("running")] public CBool Running { get; set; }
		[Ordinal(5)]  [RED("startTime")] public scnSceneTime StartTime { get; set; }
		[Ordinal(6)]  [RED("useCustomReminder")] public CBool UseCustomReminder { get; set; }
		[Ordinal(7)]  [RED("waitTimeForLooping")] public scnSceneTime WaitTimeForLooping { get; set; }
		[Ordinal(8)]  [RED("waitTimeForReminderA")] public scnSceneTime WaitTimeForReminderA { get; set; }
		[Ordinal(9)]  [RED("waitTimeForReminderB")] public scnSceneTime WaitTimeForReminderB { get; set; }
		[Ordinal(10)]  [RED("waitTimeForReminderC")] public scnSceneTime WaitTimeForReminderC { get; set; }

		public scnReminderCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
