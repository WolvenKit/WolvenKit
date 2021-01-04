using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldTransform : CVariable
	{
		[Ordinal(0)]  [RED("Orientation")] public Quaternion Orientation { get; set; }
		[Ordinal(1)]  [RED("Position")] public WorldPosition Position { get; set; }

		public WorldTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
