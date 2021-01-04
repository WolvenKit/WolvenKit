using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsVehicleHitEvent : gameeventsHitEvent
	{
		[Ordinal(0)]  [RED("preyVelocity")] public Vector4 PreyVelocity { get; set; }
		[Ordinal(1)]  [RED("vehicleVelocity")] public Vector4 VehicleVelocity { get; set; }

		public gameeventsVehicleHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
