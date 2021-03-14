using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeaveCoverImmediately : AIbehaviortaskScript
	{
		private CFloat _delay;
		private CBool _completeOnLeave;
		private CFloat _timeStamp;
		private CBool _triggered;

		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("completeOnLeave")] 
		public CBool CompleteOnLeave
		{
			get
			{
				if (_completeOnLeave == null)
				{
					_completeOnLeave = (CBool) CR2WTypeManager.Create("Bool", "completeOnLeave", cr2w, this);
				}
				return _completeOnLeave;
			}
			set
			{
				if (_completeOnLeave == value)
				{
					return;
				}
				_completeOnLeave = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get
			{
				if (_timeStamp == null)
				{
					_timeStamp = (CFloat) CR2WTypeManager.Create("Float", "timeStamp", cr2w, this);
				}
				return _timeStamp;
			}
			set
			{
				if (_timeStamp == value)
				{
					return;
				}
				_timeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("triggered")] 
		public CBool Triggered
		{
			get
			{
				if (_triggered == null)
				{
					_triggered = (CBool) CR2WTypeManager.Create("Bool", "triggered", cr2w, this);
				}
				return _triggered;
			}
			set
			{
				if (_triggered == value)
				{
					return;
				}
				_triggered = value;
				PropertySet(this);
			}
		}

		public LeaveCoverImmediately(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
