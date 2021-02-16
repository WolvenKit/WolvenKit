using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTutorialBracketData : CVariable
	{
		[Ordinal(0)] [RED("bracketID")] public CName BracketID { get; set; }
		[Ordinal(1)] [RED("bracketType")] public CEnum<gameTutorialBracketType> BracketType { get; set; }
		[Ordinal(2)] [RED("anchor")] public CEnum<inkEAnchor> Anchor { get; set; }
		[Ordinal(3)] [RED("offset")] public Vector2 Offset { get; set; }
		[Ordinal(4)] [RED("size")] public Vector2 Size { get; set; }

		public gameTutorialBracketData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
