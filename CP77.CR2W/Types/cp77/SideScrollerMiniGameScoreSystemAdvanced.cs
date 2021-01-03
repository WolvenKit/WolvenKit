using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SideScrollerMiniGameScoreSystemAdvanced : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("gameNames", 3)] public CArrayFixedSize<CString> GameNames { get; set; }
		[Ordinal(1)]  [RED("scoreData", 3)] public CArrayFixedSize<CInt32> ScoreData { get; set; }

		public SideScrollerMiniGameScoreSystemAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
