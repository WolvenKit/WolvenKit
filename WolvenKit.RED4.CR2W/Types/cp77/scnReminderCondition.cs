using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnReminderCondition : ISerializable
	{
		[Ordinal(0)] [RED("useCustomReminder")] public CBool UseCustomReminder { get; set; }
		[Ordinal(1)] [RED("reminderActor")] public scnActorId ReminderActor { get; set; }
		[Ordinal(2)] [RED("waitTimeForReminderA")] public scnSceneTime WaitTimeForReminderA { get; set; }
		[Ordinal(3)] [RED("waitTimeForReminderB")] public scnSceneTime WaitTimeForReminderB { get; set; }
		[Ordinal(4)] [RED("waitTimeForReminderC")] public scnSceneTime WaitTimeForReminderC { get; set; }
		[Ordinal(5)] [RED("waitTimeForLooping")] public scnSceneTime WaitTimeForLooping { get; set; }
		[Ordinal(6)] [RED("startTime")] public scnSceneTime StartTime { get; set; }
		[Ordinal(7)] [RED("processStep")] public CEnum<scnReminderConditionProcessStep> ProcessStep { get; set; }
		[Ordinal(8)] [RED("playing")] public CBool Playing { get; set; }
		[Ordinal(9)] [RED("running")] public CBool Running { get; set; }
		[Ordinal(10)] [RED("reminderParams")] public scnChoiceNodeNsReminderParams ReminderParams { get; set; }

		public scnReminderCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
