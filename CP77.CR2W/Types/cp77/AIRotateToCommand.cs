using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIRotateToCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("target")] public AIPositionSpec Target { get; set; }
		[Ordinal(8)] [RED("angleTolerance")] public CFloat AngleTolerance { get; set; }
		[Ordinal(9)] [RED("angleOffset")] public CFloat AngleOffset { get; set; }
		[Ordinal(10)] [RED("speed")] public CFloat Speed { get; set; }

		public AIRotateToCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
