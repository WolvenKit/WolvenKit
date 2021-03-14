using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MoveToScavengeTarget : AIbehaviortaskScript
	{
		private CFloat _lastTime;
		private CFloat _timeout;
		private CFloat _timeoutDuration;

		[Ordinal(0)] 
		[RED("lastTime")] 
		public CFloat LastTime
		{
			get
			{
				if (_lastTime == null)
				{
					_lastTime = (CFloat) CR2WTypeManager.Create("Float", "lastTime", cr2w, this);
				}
				return _lastTime;
			}
			set
			{
				if (_lastTime == value)
				{
					return;
				}
				_lastTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get
			{
				if (_timeout == null)
				{
					_timeout = (CFloat) CR2WTypeManager.Create("Float", "timeout", cr2w, this);
				}
				return _timeout;
			}
			set
			{
				if (_timeout == value)
				{
					return;
				}
				_timeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeoutDuration")] 
		public CFloat TimeoutDuration
		{
			get
			{
				if (_timeoutDuration == null)
				{
					_timeoutDuration = (CFloat) CR2WTypeManager.Create("Float", "timeoutDuration", cr2w, this);
				}
				return _timeoutDuration;
			}
			set
			{
				if (_timeoutDuration == value)
				{
					return;
				}
				_timeoutDuration = value;
				PropertySet(this);
			}
		}

		public MoveToScavengeTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
