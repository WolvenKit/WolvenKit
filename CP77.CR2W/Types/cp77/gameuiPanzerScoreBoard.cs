using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreBoard : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(0)]  [RED("champions")] public CArray<gameuiPanzerScoreRecordData> Champions { get; set; }
		[Ordinal(1)]  [RED("recordWidgetLibraryName")] public CName RecordWidgetLibraryName { get; set; }
		[Ordinal(2)]  [RED("scoreboardList")] public inkVerticalPanelWidgetReference ScoreboardList { get; set; }

		public gameuiPanzerScoreBoard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
