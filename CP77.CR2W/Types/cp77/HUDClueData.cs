using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDClueData : CVariable
	{
		[Ordinal(0)] [RED("isClue")] public CBool IsClue { get; set; }
		[Ordinal(1)] [RED("clueGroupID")] public CName ClueGroupID { get; set; }

		public HUDClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
