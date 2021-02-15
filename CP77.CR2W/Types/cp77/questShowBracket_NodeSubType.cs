using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questShowBracket_NodeSubType : questITutorial_NodeSubType
	{
		[Ordinal(0)] [RED("bracketID")] public CName BracketID { get; set; }
		[Ordinal(1)] [RED("visible")] public CBool Visible { get; set; }
		[Ordinal(2)] [RED("bracketType")] public CEnum<gameTutorialBracketType> BracketType { get; set; }
		[Ordinal(3)] [RED("anchor")] public CEnum<inkEAnchor> Anchor { get; set; }
		[Ordinal(4)] [RED("offset")] public Vector2 Offset { get; set; }
		[Ordinal(5)] [RED("size")] public Vector2 Size { get; set; }
		[Ordinal(6)] [RED("ignoreDisabledTutorials")] public CBool IgnoreDisabledTutorials { get; set; }

		public questShowBracket_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
