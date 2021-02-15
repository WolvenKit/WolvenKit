using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseSensorObjectComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("sensorObject")] public CHandle<senseSensorObject> SensorObject { get; set; }
		[Ordinal(6)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public senseSensorObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
