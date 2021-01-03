using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameStateAdvanced : IScriptable
	{
		[Ordinal(0)]  [RED("PropertyChanged")] public gameuiGameStatePropertyChangedCallback PropertyChanged { get; set; }
		[Ordinal(1)]  [RED("opertyCurrentLives")] public CName OpertyCurrentLives { get; set; }
		[Ordinal(2)]  [RED("opertyCurrentScore")] public CName OpertyCurrentScore { get; set; }
		[Ordinal(3)]  [RED("opertyMaxScore")] public CName OpertyMaxScore { get; set; }

		public gameuiSideScrollerMiniGameStateAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
