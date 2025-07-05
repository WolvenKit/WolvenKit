using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsReminderParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("reminderEnabled")] 
		public CBool ReminderEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("useCustomReminder")] 
		public CBool UseCustomReminder
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("reminderActor")] 
		public scnActorId ReminderActor
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(3)] 
		[RED("waitTimeForReminderA")] 
		public scnSceneTime WaitTimeForReminderA
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(4)] 
		[RED("waitTimeForReminderB")] 
		public scnSceneTime WaitTimeForReminderB
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(5)] 
		[RED("waitTimeForReminderC")] 
		public scnSceneTime WaitTimeForReminderC
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(6)] 
		[RED("waitTimeForLooping")] 
		public scnSceneTime WaitTimeForLooping
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		public scnChoiceNodeNsReminderParams()
		{
			ReminderActor = new scnActorId { Id = uint.MaxValue };
			WaitTimeForReminderA = new scnSceneTime();
			WaitTimeForReminderB = new scnSceneTime();
			WaitTimeForReminderC = new scnSceneTime();
			WaitTimeForLooping = new scnSceneTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
