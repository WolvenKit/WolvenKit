using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldExtractedNodeSocket : CVariable
	{
		[Ordinal(0)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(1)]  [RED("direction")] public Vector3 Direction { get; set; }
		[Ordinal(2)]  [RED("displayName")] public CName DisplayName { get; set; }
		[Ordinal(3)]  [RED("isSnapped")] public CBool IsSnapped { get; set; }
		[Ordinal(4)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(5)]  [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(6)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(7)]  [RED("type")] public CEnum<worldNodeSocketType> Type { get; set; }

		public worldExtractedNodeSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
