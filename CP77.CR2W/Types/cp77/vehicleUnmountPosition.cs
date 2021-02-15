using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleUnmountPosition : CVariable
	{
		[Ordinal(0)] [RED("direction")] public CEnum<vehicleExitDirection> Direction { get; set; }
		[Ordinal(1)] [RED("position")] public WorldPosition Position { get; set; }

		public vehicleUnmountPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
