using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnTimedCondition : ISerializable
	{
		private scnSceneTime _duration;
		private CEnum<scnChoiceNodeNsTimedAction> _action;
		private CBool _timeLimitedFinish;

		[Ordinal(0)] 
		[RED("duration")] 
		public scnSceneTime Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<scnChoiceNodeNsTimedAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<scnChoiceNodeNsTimedAction>) CR2WTypeManager.Create("scnChoiceNodeNsTimedAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeLimitedFinish")] 
		public CBool TimeLimitedFinish
		{
			get
			{
				if (_timeLimitedFinish == null)
				{
					_timeLimitedFinish = (CBool) CR2WTypeManager.Create("Bool", "timeLimitedFinish", cr2w, this);
				}
				return _timeLimitedFinish;
			}
			set
			{
				if (_timeLimitedFinish == value)
				{
					return;
				}
				_timeLimitedFinish = value;
				PropertySet(this);
			}
		}

		public scnTimedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
