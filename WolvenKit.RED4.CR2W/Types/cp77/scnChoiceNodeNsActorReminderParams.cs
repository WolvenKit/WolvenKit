using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsActorReminderParams : ISerializable
	{
		private CBool _useCustomReminder;
		private scnActorId _reminderActor;
		private scnSceneTime _waitTimeForReminderA;
		private scnSceneTime _waitTimeForReminderB;
		private scnSceneTime _waitTimeForReminderC;
		private scnSceneTime _waitTimeForLooping;

		[Ordinal(0)] 
		[RED("useCustomReminder")] 
		public CBool UseCustomReminder
		{
			get => GetProperty(ref _useCustomReminder);
			set => SetProperty(ref _useCustomReminder, value);
		}

		[Ordinal(1)] 
		[RED("reminderActor")] 
		public scnActorId ReminderActor
		{
			get => GetProperty(ref _reminderActor);
			set => SetProperty(ref _reminderActor, value);
		}

		[Ordinal(2)] 
		[RED("waitTimeForReminderA")] 
		public scnSceneTime WaitTimeForReminderA
		{
			get => GetProperty(ref _waitTimeForReminderA);
			set => SetProperty(ref _waitTimeForReminderA, value);
		}

		[Ordinal(3)] 
		[RED("waitTimeForReminderB")] 
		public scnSceneTime WaitTimeForReminderB
		{
			get => GetProperty(ref _waitTimeForReminderB);
			set => SetProperty(ref _waitTimeForReminderB, value);
		}

		[Ordinal(4)] 
		[RED("waitTimeForReminderC")] 
		public scnSceneTime WaitTimeForReminderC
		{
			get => GetProperty(ref _waitTimeForReminderC);
			set => SetProperty(ref _waitTimeForReminderC, value);
		}

		[Ordinal(5)] 
		[RED("waitTimeForLooping")] 
		public scnSceneTime WaitTimeForLooping
		{
			get => GetProperty(ref _waitTimeForLooping);
			set => SetProperty(ref _waitTimeForLooping, value);
		}

		public scnChoiceNodeNsActorReminderParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
