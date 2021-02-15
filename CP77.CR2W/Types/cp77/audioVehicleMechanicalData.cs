using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleMechanicalData : CVariable
	{
		[Ordinal(0)] [RED("engineStartEvent")] public CName EngineStartEvent { get; set; }
		[Ordinal(1)] [RED("engineStopEvent")] public CName EngineStopEvent { get; set; }
		[Ordinal(2)] [RED("gearUpBeginEvent")] public CName GearUpBeginEvent { get; set; }
		[Ordinal(3)] [RED("gearUpEndEvent")] public CName GearUpEndEvent { get; set; }
		[Ordinal(4)] [RED("gearDownBeginEvent")] public CName GearDownBeginEvent { get; set; }
		[Ordinal(5)] [RED("gearDownEndEvent")] public CName GearDownEndEvent { get; set; }
		[Ordinal(6)] [RED("throttleOnEvent")] public CName ThrottleOnEvent { get; set; }
		[Ordinal(7)] [RED("throttleOffEvent")] public CName ThrottleOffEvent { get; set; }
		[Ordinal(8)] [RED("suspensionSqueekEvent")] public CName SuspensionSqueekEvent { get; set; }
		[Ordinal(9)] [RED("acelleration")] public CName Acelleration { get; set; }
		[Ordinal(10)] [RED("speed")] public CName Speed { get; set; }
		[Ordinal(11)] [RED("gear")] public CName Gear { get; set; }
		[Ordinal(12)] [RED("brake")] public CName Brake { get; set; }
		[Ordinal(13)] [RED("rpm")] public CName Rpm { get; set; }
		[Ordinal(14)] [RED("throttle")] public CName Throttle { get; set; }
		[Ordinal(15)] [RED("sidewaysThrottle")] public CName SidewaysThrottle { get; set; }
		[Ordinal(16)] [RED("thrust")] public CName Thrust { get; set; }
		[Ordinal(17)] [RED("temperature")] public CName Temperature { get; set; }

		public audioVehicleMechanicalData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
