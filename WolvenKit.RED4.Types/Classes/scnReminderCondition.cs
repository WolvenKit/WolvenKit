using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnReminderCondition : ISerializable
	{
		private CBool _useCustomReminder;
		private scnActorId _reminderActor;
		private scnSceneTime _waitTimeForReminderA;
		private scnSceneTime _waitTimeForReminderB;
		private scnSceneTime _waitTimeForReminderC;
		private scnSceneTime _waitTimeForLooping;
		private scnSceneTime _startTime;
		private CEnum<scnReminderConditionProcessStep> _processStep;
		private CBool _playing;
		private CBool _running;
		private scnChoiceNodeNsReminderParams _reminderParams;

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

		[Ordinal(6)] 
		[RED("startTime")] 
		public scnSceneTime StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(7)] 
		[RED("processStep")] 
		public CEnum<scnReminderConditionProcessStep> ProcessStep
		{
			get => GetProperty(ref _processStep);
			set => SetProperty(ref _processStep, value);
		}

		[Ordinal(8)] 
		[RED("playing")] 
		public CBool Playing
		{
			get => GetProperty(ref _playing);
			set => SetProperty(ref _playing, value);
		}

		[Ordinal(9)] 
		[RED("running")] 
		public CBool Running
		{
			get => GetProperty(ref _running);
			set => SetProperty(ref _running, value);
		}

		[Ordinal(10)] 
		[RED("reminderParams")] 
		public scnChoiceNodeNsReminderParams ReminderParams
		{
			get => GetProperty(ref _reminderParams);
			set => SetProperty(ref _reminderParams, value);
		}
	}
}
