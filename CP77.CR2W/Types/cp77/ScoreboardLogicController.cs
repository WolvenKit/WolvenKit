using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScoreboardLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("gridItem")] public CName GridItem { get; set; }
		[Ordinal(1)]  [RED("namesWidget")] public inkCompoundWidgetReference NamesWidget { get; set; }
		[Ordinal(2)]  [RED("scoresWidget")] public inkCompoundWidgetReference ScoresWidget { get; set; }
		[Ordinal(3)]  [RED("highScores")] public CArray<ScoreboardPlayer> HighScores { get; set; }

		public ScoreboardLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
