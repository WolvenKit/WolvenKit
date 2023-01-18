using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsActorReminderParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("useCustomReminder")] 
		public CBool UseCustomReminder
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("reminderActor")] 
		public scnActorId ReminderActor
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(2)] 
		[RED("waitTimeForReminderA")] 
		public scnSceneTime WaitTimeForReminderA
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(3)] 
		[RED("waitTimeForReminderB")] 
		public scnSceneTime WaitTimeForReminderB
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(4)] 
		[RED("waitTimeForReminderC")] 
		public scnSceneTime WaitTimeForReminderC
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(5)] 
		[RED("waitTimeForLooping")] 
		public scnSceneTime WaitTimeForLooping
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(6)] 
		[RED("cutReminderEnabled")] 
		public CBool CutReminderEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("waitTimeToCutReminder")] 
		public CFloat WaitTimeToCutReminder
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnChoiceNodeNsActorReminderParams()
		{
			ReminderActor = new() { Id = 4294967295 };
			WaitTimeForReminderA = new();
			WaitTimeForReminderB = new();
			WaitTimeForReminderC = new();
			WaitTimeForLooping = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
