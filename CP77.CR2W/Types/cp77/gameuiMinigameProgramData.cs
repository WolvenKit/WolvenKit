using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameProgramData : CVariable
	{
		[Ordinal(0)] [RED("actionID")] public TweakDBID ActionID { get; set; }
		[Ordinal(1)] [RED("programName")] public CName ProgramName { get; set; }

		public gameuiMinigameProgramData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
