using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SideScrollerMiniGameScoreSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("gameNames", 3)] public CArrayFixedSize<CString> GameNames { get; set; }
		[Ordinal(1)]  [RED("scoreData", 3)] public CArrayFixedSize<CInt32> ScoreData { get; set; }

		public SideScrollerMiniGameScoreSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
