using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("sensorObject")] public CHandle<senseSensorObject> SensorObject { get; set; }
		[Ordinal(1)]  [RED("visibleObject")] public CHandle<senseVisibleObject> VisibleObject { get; set; }
		[Ordinal(2)]  [RED("enableBeingDetectable")] public CBool EnableBeingDetectable { get; set; }

		public senseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
