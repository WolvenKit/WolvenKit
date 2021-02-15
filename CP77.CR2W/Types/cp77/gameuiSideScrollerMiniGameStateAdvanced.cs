using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameStateAdvanced : IScriptable
	{
		[Ordinal(0)] [RED("opertyMaxScore")] public CName OpertyMaxScore { get; set; }
		[Ordinal(1)] [RED("opertyCurrentLives")] public CName OpertyCurrentLives { get; set; }
		[Ordinal(2)] [RED("opertyCurrentScore")] public CName OpertyCurrentScore { get; set; }
		[Ordinal(3)] [RED("PropertyChanged")] public gameuiGameStatePropertyChangedCallback PropertyChanged_ { get; set; }

		public gameuiSideScrollerMiniGameStateAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
