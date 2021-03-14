using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleMechanicalData : CVariable
	{
		private CName _engineStartEvent;
		private CName _engineStopEvent;
		private CName _gearUpBeginEvent;
		private CName _gearUpEndEvent;
		private CName _gearDownBeginEvent;
		private CName _gearDownEndEvent;
		private CName _throttleOnEvent;
		private CName _throttleOffEvent;
		private CName _suspensionSqueekEvent;
		private CName _acelleration;
		private CName _speed;
		private CName _gear;
		private CName _brake;
		private CName _rpm;
		private CName _throttle;
		private CName _sidewaysThrottle;
		private CName _thrust;
		private CName _temperature;

		[Ordinal(0)] 
		[RED("engineStartEvent")] 
		public CName EngineStartEvent
		{
			get
			{
				if (_engineStartEvent == null)
				{
					_engineStartEvent = (CName) CR2WTypeManager.Create("CName", "engineStartEvent", cr2w, this);
				}
				return _engineStartEvent;
			}
			set
			{
				if (_engineStartEvent == value)
				{
					return;
				}
				_engineStartEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("engineStopEvent")] 
		public CName EngineStopEvent
		{
			get
			{
				if (_engineStopEvent == null)
				{
					_engineStopEvent = (CName) CR2WTypeManager.Create("CName", "engineStopEvent", cr2w, this);
				}
				return _engineStopEvent;
			}
			set
			{
				if (_engineStopEvent == value)
				{
					return;
				}
				_engineStopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gearUpBeginEvent")] 
		public CName GearUpBeginEvent
		{
			get
			{
				if (_gearUpBeginEvent == null)
				{
					_gearUpBeginEvent = (CName) CR2WTypeManager.Create("CName", "gearUpBeginEvent", cr2w, this);
				}
				return _gearUpBeginEvent;
			}
			set
			{
				if (_gearUpBeginEvent == value)
				{
					return;
				}
				_gearUpBeginEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gearUpEndEvent")] 
		public CName GearUpEndEvent
		{
			get
			{
				if (_gearUpEndEvent == null)
				{
					_gearUpEndEvent = (CName) CR2WTypeManager.Create("CName", "gearUpEndEvent", cr2w, this);
				}
				return _gearUpEndEvent;
			}
			set
			{
				if (_gearUpEndEvent == value)
				{
					return;
				}
				_gearUpEndEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gearDownBeginEvent")] 
		public CName GearDownBeginEvent
		{
			get
			{
				if (_gearDownBeginEvent == null)
				{
					_gearDownBeginEvent = (CName) CR2WTypeManager.Create("CName", "gearDownBeginEvent", cr2w, this);
				}
				return _gearDownBeginEvent;
			}
			set
			{
				if (_gearDownBeginEvent == value)
				{
					return;
				}
				_gearDownBeginEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("gearDownEndEvent")] 
		public CName GearDownEndEvent
		{
			get
			{
				if (_gearDownEndEvent == null)
				{
					_gearDownEndEvent = (CName) CR2WTypeManager.Create("CName", "gearDownEndEvent", cr2w, this);
				}
				return _gearDownEndEvent;
			}
			set
			{
				if (_gearDownEndEvent == value)
				{
					return;
				}
				_gearDownEndEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("throttleOnEvent")] 
		public CName ThrottleOnEvent
		{
			get
			{
				if (_throttleOnEvent == null)
				{
					_throttleOnEvent = (CName) CR2WTypeManager.Create("CName", "throttleOnEvent", cr2w, this);
				}
				return _throttleOnEvent;
			}
			set
			{
				if (_throttleOnEvent == value)
				{
					return;
				}
				_throttleOnEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("throttleOffEvent")] 
		public CName ThrottleOffEvent
		{
			get
			{
				if (_throttleOffEvent == null)
				{
					_throttleOffEvent = (CName) CR2WTypeManager.Create("CName", "throttleOffEvent", cr2w, this);
				}
				return _throttleOffEvent;
			}
			set
			{
				if (_throttleOffEvent == value)
				{
					return;
				}
				_throttleOffEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("suspensionSqueekEvent")] 
		public CName SuspensionSqueekEvent
		{
			get
			{
				if (_suspensionSqueekEvent == null)
				{
					_suspensionSqueekEvent = (CName) CR2WTypeManager.Create("CName", "suspensionSqueekEvent", cr2w, this);
				}
				return _suspensionSqueekEvent;
			}
			set
			{
				if (_suspensionSqueekEvent == value)
				{
					return;
				}
				_suspensionSqueekEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("acelleration")] 
		public CName Acelleration
		{
			get
			{
				if (_acelleration == null)
				{
					_acelleration = (CName) CR2WTypeManager.Create("CName", "acelleration", cr2w, this);
				}
				return _acelleration;
			}
			set
			{
				if (_acelleration == value)
				{
					return;
				}
				_acelleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("speed")] 
		public CName Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CName) CR2WTypeManager.Create("CName", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("gear")] 
		public CName Gear
		{
			get
			{
				if (_gear == null)
				{
					_gear = (CName) CR2WTypeManager.Create("CName", "gear", cr2w, this);
				}
				return _gear;
			}
			set
			{
				if (_gear == value)
				{
					return;
				}
				_gear = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("brake")] 
		public CName Brake
		{
			get
			{
				if (_brake == null)
				{
					_brake = (CName) CR2WTypeManager.Create("CName", "brake", cr2w, this);
				}
				return _brake;
			}
			set
			{
				if (_brake == value)
				{
					return;
				}
				_brake = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rpm")] 
		public CName Rpm
		{
			get
			{
				if (_rpm == null)
				{
					_rpm = (CName) CR2WTypeManager.Create("CName", "rpm", cr2w, this);
				}
				return _rpm;
			}
			set
			{
				if (_rpm == value)
				{
					return;
				}
				_rpm = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("throttle")] 
		public CName Throttle
		{
			get
			{
				if (_throttle == null)
				{
					_throttle = (CName) CR2WTypeManager.Create("CName", "throttle", cr2w, this);
				}
				return _throttle;
			}
			set
			{
				if (_throttle == value)
				{
					return;
				}
				_throttle = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("sidewaysThrottle")] 
		public CName SidewaysThrottle
		{
			get
			{
				if (_sidewaysThrottle == null)
				{
					_sidewaysThrottle = (CName) CR2WTypeManager.Create("CName", "sidewaysThrottle", cr2w, this);
				}
				return _sidewaysThrottle;
			}
			set
			{
				if (_sidewaysThrottle == value)
				{
					return;
				}
				_sidewaysThrottle = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("thrust")] 
		public CName Thrust
		{
			get
			{
				if (_thrust == null)
				{
					_thrust = (CName) CR2WTypeManager.Create("CName", "thrust", cr2w, this);
				}
				return _thrust;
			}
			set
			{
				if (_thrust == value)
				{
					return;
				}
				_thrust = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("temperature")] 
		public CName Temperature
		{
			get
			{
				if (_temperature == null)
				{
					_temperature = (CName) CR2WTypeManager.Create("CName", "temperature", cr2w, this);
				}
				return _temperature;
			}
			set
			{
				if (_temperature == value)
				{
					return;
				}
				_temperature = value;
				PropertySet(this);
			}
		}

		public audioVehicleMechanicalData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
