using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SideScrollerMiniGameScoreSystemAdvanced : gameScriptableSystem
	{
		[Ordinal(0)] [RED("scoreData", 3)] public CArrayFixedSize<CInt32> ScoreData { get; set; }
		[Ordinal(1)] [RED("gameNames", 3)] public CArrayFixedSize<CString> GameNames { get; set; }

		public SideScrollerMiniGameScoreSystemAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
