using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetFollowTarget : FollowVehicleTask
	{
		private CHandle<gameIBlackboard> _blackboard;
		private wCHandle<vehicleBaseObject> _vehicle;
		private CFloat _lastTime;
		private CFloat _timeout;
		private CFloat _timeoutDuration;

		[Ordinal(0)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public GetFollowTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
