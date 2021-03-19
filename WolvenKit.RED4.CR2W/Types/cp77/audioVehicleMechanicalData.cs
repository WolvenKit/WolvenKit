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
			get => GetProperty(ref _engineStartEvent);
			set => SetProperty(ref _engineStartEvent, value);
		}

		[Ordinal(1)] 
		[RED("engineStopEvent")] 
		public CName EngineStopEvent
		{
			get => GetProperty(ref _engineStopEvent);
			set => SetProperty(ref _engineStopEvent, value);
		}

		[Ordinal(2)] 
		[RED("gearUpBeginEvent")] 
		public CName GearUpBeginEvent
		{
			get => GetProperty(ref _gearUpBeginEvent);
			set => SetProperty(ref _gearUpBeginEvent, value);
		}

		[Ordinal(3)] 
		[RED("gearUpEndEvent")] 
		public CName GearUpEndEvent
		{
			get => GetProperty(ref _gearUpEndEvent);
			set => SetProperty(ref _gearUpEndEvent, value);
		}

		[Ordinal(4)] 
		[RED("gearDownBeginEvent")] 
		public CName GearDownBeginEvent
		{
			get => GetProperty(ref _gearDownBeginEvent);
			set => SetProperty(ref _gearDownBeginEvent, value);
		}

		[Ordinal(5)] 
		[RED("gearDownEndEvent")] 
		public CName GearDownEndEvent
		{
			get => GetProperty(ref _gearDownEndEvent);
			set => SetProperty(ref _gearDownEndEvent, value);
		}

		[Ordinal(6)] 
		[RED("throttleOnEvent")] 
		public CName ThrottleOnEvent
		{
			get => GetProperty(ref _throttleOnEvent);
			set => SetProperty(ref _throttleOnEvent, value);
		}

		[Ordinal(7)] 
		[RED("throttleOffEvent")] 
		public CName ThrottleOffEvent
		{
			get => GetProperty(ref _throttleOffEvent);
			set => SetProperty(ref _throttleOffEvent, value);
		}

		[Ordinal(8)] 
		[RED("suspensionSqueekEvent")] 
		public CName SuspensionSqueekEvent
		{
			get => GetProperty(ref _suspensionSqueekEvent);
			set => SetProperty(ref _suspensionSqueekEvent, value);
		}

		[Ordinal(9)] 
		[RED("acelleration")] 
		public CName Acelleration
		{
			get => GetProperty(ref _acelleration);
			set => SetProperty(ref _acelleration, value);
		}

		[Ordinal(10)] 
		[RED("speed")] 
		public CName Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(11)] 
		[RED("gear")] 
		public CName Gear
		{
			get => GetProperty(ref _gear);
			set => SetProperty(ref _gear, value);
		}

		[Ordinal(12)] 
		[RED("brake")] 
		public CName Brake
		{
			get => GetProperty(ref _brake);
			set => SetProperty(ref _brake, value);
		}

		[Ordinal(13)] 
		[RED("rpm")] 
		public CName Rpm
		{
			get => GetProperty(ref _rpm);
			set => SetProperty(ref _rpm, value);
		}

		[Ordinal(14)] 
		[RED("throttle")] 
		public CName Throttle
		{
			get => GetProperty(ref _throttle);
			set => SetProperty(ref _throttle, value);
		}

		[Ordinal(15)] 
		[RED("sidewaysThrottle")] 
		public CName SidewaysThrottle
		{
			get => GetProperty(ref _sidewaysThrottle);
			set => SetProperty(ref _sidewaysThrottle, value);
		}

		[Ordinal(16)] 
		[RED("thrust")] 
		public CName Thrust
		{
			get => GetProperty(ref _thrust);
			set => SetProperty(ref _thrust, value);
		}

		[Ordinal(17)] 
		[RED("temperature")] 
		public CName Temperature
		{
			get => GetProperty(ref _temperature);
			set => SetProperty(ref _temperature, value);
		}

		public audioVehicleMechanicalData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
