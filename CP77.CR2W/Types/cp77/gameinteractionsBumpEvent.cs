using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsBumpEvent : redEvent
	{
		[Ordinal(0)] [RED("side")] public CEnum<gameinteractionsBumpSide> Side { get; set; }
		[Ordinal(1)] [RED("sourceLocation")] public CEnum<gameinteractionsBumpLocation> SourceLocation { get; set; }
		[Ordinal(2)] [RED("direction")] public Vector4 Direction { get; set; }
		[Ordinal(3)] [RED("sourcePosition")] public Vector4 SourcePosition { get; set; }
		[Ordinal(4)] [RED("sourceSquaredDistance")] public CFloat SourceSquaredDistance { get; set; }
		[Ordinal(5)] [RED("sourceSpeed")] public CFloat SourceSpeed { get; set; }
		[Ordinal(6)] [RED("isMounted")] public CBool IsMounted { get; set; }
		[Ordinal(7)] [RED("sourceRadius")] public CFloat SourceRadius { get; set; }

		public gameinteractionsBumpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
