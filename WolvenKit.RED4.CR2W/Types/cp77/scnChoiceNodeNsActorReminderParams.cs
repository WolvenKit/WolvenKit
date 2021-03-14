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
			get
			{
				if (_useCustomReminder == null)
				{
					_useCustomReminder = (CBool) CR2WTypeManager.Create("Bool", "useCustomReminder", cr2w, this);
				}
				return _useCustomReminder;
			}
			set
			{
				if (_useCustomReminder == value)
				{
					return;
				}
				_useCustomReminder = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reminderActor")] 
		public scnActorId ReminderActor
		{
			get
			{
				if (_reminderActor == null)
				{
					_reminderActor = (scnActorId) CR2WTypeManager.Create("scnActorId", "reminderActor", cr2w, this);
				}
				return _reminderActor;
			}
			set
			{
				if (_reminderActor == value)
				{
					return;
				}
				_reminderActor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("waitTimeForReminderA")] 
		public scnSceneTime WaitTimeForReminderA
		{
			get
			{
				if (_waitTimeForReminderA == null)
				{
					_waitTimeForReminderA = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "waitTimeForReminderA", cr2w, this);
				}
				return _waitTimeForReminderA;
			}
			set
			{
				if (_waitTimeForReminderA == value)
				{
					return;
				}
				_waitTimeForReminderA = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("waitTimeForReminderB")] 
		public scnSceneTime WaitTimeForReminderB
		{
			get
			{
				if (_waitTimeForReminderB == null)
				{
					_waitTimeForReminderB = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "waitTimeForReminderB", cr2w, this);
				}
				return _waitTimeForReminderB;
			}
			set
			{
				if (_waitTimeForReminderB == value)
				{
					return;
				}
				_waitTimeForReminderB = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("waitTimeForReminderC")] 
		public scnSceneTime WaitTimeForReminderC
		{
			get
			{
				if (_waitTimeForReminderC == null)
				{
					_waitTimeForReminderC = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "waitTimeForReminderC", cr2w, this);
				}
				return _waitTimeForReminderC;
			}
			set
			{
				if (_waitTimeForReminderC == value)
				{
					return;
				}
				_waitTimeForReminderC = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("waitTimeForLooping")] 
		public scnSceneTime WaitTimeForLooping
		{
			get
			{
				if (_waitTimeForLooping == null)
				{
					_waitTimeForLooping = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "waitTimeForLooping", cr2w, this);
				}
				return _waitTimeForLooping;
			}
			set
			{
				if (_waitTimeForLooping == value)
				{
					return;
				}
				_waitTimeForLooping = value;
				PropertySet(this);
			}
		}

		public scnChoiceNodeNsActorReminderParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
