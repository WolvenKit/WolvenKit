using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutPoint : ISerializable
	{
		[Ordinal(0)] [RED("position")] public Vector2 Position { get; set; }
		[Ordinal(1)] [RED("edges")] public CArray<CUInt32> Edges { get; set; }
		[Ordinal(2)] [RED("constraint")] public CInt32 Constraint { get; set; }
		[Ordinal(3)] [RED("isFree")] public CBool IsFree { get; set; }

		public worldBlockoutPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
