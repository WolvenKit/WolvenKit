using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleChassisComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("collisionResource")] public rRef<physicsSystemResource> CollisionResource { get; set; }
		[Ordinal(1)]  [RED("optionalPlayerOnlyCollisionResource")] public rRef<physicsSystemResource> OptionalPlayerOnlyCollisionResource { get; set; }

		public vehicleChassisComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
