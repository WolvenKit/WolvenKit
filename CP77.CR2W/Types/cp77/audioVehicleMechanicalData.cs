using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleMechanicalData : CVariable
	{
		[Ordinal(0)]  [RED("acelleration")] public CName Acelleration { get; set; }
		[Ordinal(1)]  [RED("brake")] public CName Brake { get; set; }
		[Ordinal(2)]  [RED("engineStartEvent")] public CName EngineStartEvent { get; set; }
		[Ordinal(3)]  [RED("engineStopEvent")] public CName EngineStopEvent { get; set; }
		[Ordinal(4)]  [RED("gear")] public CName Gear { get; set; }
		[Ordinal(5)]  [RED("gearDownBeginEvent")] public CName GearDownBeginEvent { get; set; }
		[Ordinal(6)]  [RED("gearDownEndEvent")] public CName GearDownEndEvent { get; set; }
		[Ordinal(7)]  [RED("gearUpBeginEvent")] public CName GearUpBeginEvent { get; set; }
		[Ordinal(8)]  [RED("gearUpEndEvent")] public CName GearUpEndEvent { get; set; }
		[Ordinal(9)]  [RED("rpm")] public CName Rpm { get; set; }
		[Ordinal(10)]  [RED("sidewaysThrottle")] public CName SidewaysThrottle { get; set; }
		[Ordinal(11)]  [RED("speed")] public CName Speed { get; set; }
		[Ordinal(12)]  [RED("suspensionSqueekEvent")] public CName SuspensionSqueekEvent { get; set; }
		[Ordinal(13)]  [RED("temperature")] public CName Temperature { get; set; }
		[Ordinal(14)]  [RED("throttle")] public CName Throttle { get; set; }
		[Ordinal(15)]  [RED("throttleOffEvent")] public CName ThrottleOffEvent { get; set; }
		[Ordinal(16)]  [RED("throttleOnEvent")] public CName ThrottleOnEvent { get; set; }
		[Ordinal(17)]  [RED("thrust")] public CName Thrust { get; set; }

		public audioVehicleMechanicalData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
