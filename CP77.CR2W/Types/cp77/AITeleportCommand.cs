using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AITeleportCommand : AICommand
	{
		[Ordinal(0)]  [RED("doNavTest")] public CBool DoNavTest { get; set; }
		[Ordinal(1)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(2)]  [RED("rotation")] public CFloat Rotation { get; set; }

		public AITeleportCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
