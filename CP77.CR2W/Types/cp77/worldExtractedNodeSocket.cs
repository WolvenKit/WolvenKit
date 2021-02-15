using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldExtractedNodeSocket : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("displayName")] public CName DisplayName { get; set; }
		[Ordinal(2)] [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(3)] [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(4)] [RED("direction")] public Vector3 Direction { get; set; }
		[Ordinal(5)] [RED("type")] public CEnum<worldNodeSocketType> Type { get; set; }
		[Ordinal(6)] [RED("isSnapped")] public CBool IsSnapped { get; set; }
		[Ordinal(7)] [RED("color")] public CColor Color { get; set; }

		public worldExtractedNodeSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
