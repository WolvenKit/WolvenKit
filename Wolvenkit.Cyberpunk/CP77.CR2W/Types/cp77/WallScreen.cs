using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WallScreen : TV
	{
		[Ordinal(0)]  [RED("factOnFullyOpened")] public CName FactOnFullyOpened { get; set; }
		[Ordinal(1)]  [RED("movementPattern")] public SMovementPattern MovementPattern { get; set; }
		[Ordinal(2)]  [RED("objectMover")] public CHandle<ObjectMoverComponent> ObjectMover { get; set; }

		public WallScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
