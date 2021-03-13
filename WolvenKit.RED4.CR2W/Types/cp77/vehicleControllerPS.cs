using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleControllerPS : gameComponentPS
	{
		[Ordinal(0)] [RED("vehicleDoors", 6)] public CStatic<vehicleVehicleSlotsState> VehicleDoors { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<vehicleEState> State { get; set; }
		[Ordinal(2)] [RED("lightMode")] public CEnum<vehicleELightMode> LightMode { get; set; }
		[Ordinal(3)] [RED("isAlarmOn")] public CBool IsAlarmOn { get; set; }

		public vehicleControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
