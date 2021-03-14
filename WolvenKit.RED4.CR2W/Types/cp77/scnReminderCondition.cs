using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnReminderCondition : ISerializable
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

		[Ordinal(6)] 
		[RED("startTime")] 
		public scnSceneTime StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("processStep")] 
		public CEnum<scnReminderConditionProcessStep> ProcessStep
		{
			get
			{
				if (_processStep == null)
				{
					_processStep = (CEnum<scnReminderConditionProcessStep>) CR2WTypeManager.Create("scnReminderConditionProcessStep", "processStep", cr2w, this);
				}
				return _processStep;
			}
			set
			{
				if (_processStep == value)
				{
					return;
				}
				_processStep = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playing")] 
		public CBool Playing
		{
			get
			{
				if (_playing == null)
				{
					_playing = (CBool) CR2WTypeManager.Create("Bool", "playing", cr2w, this);
				}
				return _playing;
			}
			set
			{
				if (_playing == value)
				{
					return;
				}
				_playing = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("running")] 
		public CBool Running
		{
			get
			{
				if (_running == null)
				{
					_running = (CBool) CR2WTypeManager.Create("Bool", "running", cr2w, this);
				}
				return _running;
			}
			set
			{
				if (_running == value)
				{
					return;
				}
				_running = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("reminderParams")] 
		public scnChoiceNodeNsReminderParams ReminderParams
		{
			get
			{
				if (_reminderParams == null)
				{
					_reminderParams = (scnChoiceNodeNsReminderParams) CR2WTypeManager.Create("scnChoiceNodeNsReminderParams", "reminderParams", cr2w, this);
				}
				return _reminderParams;
			}
			set
			{
				if (_reminderParams == value)
				{
					return;
				}
				_reminderParams = value;
				PropertySet(this);
			}
		}

		public scnReminderCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
