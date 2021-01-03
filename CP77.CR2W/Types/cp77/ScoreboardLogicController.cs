using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScoreboardLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("gridItem")] public CName GridItem { get; set; }
		[Ordinal(1)]  [RED("highScores")] public CArray<ScoreboardPlayer> HighScores { get; set; }
		[Ordinal(2)]  [RED("namesWidget")] public inkCompoundWidgetReference NamesWidget { get; set; }
		[Ordinal(3)]  [RED("scoresWidget")] public inkCompoundWidgetReference ScoresWidget { get; set; }

		public ScoreboardLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
