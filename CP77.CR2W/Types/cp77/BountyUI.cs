using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BountyUI : CVariable
	{
		[Ordinal(0)] [RED("issuedBy")] public CString IssuedBy { get; set; }
		[Ordinal(1)] [RED("moneyReward")] public CInt32 MoneyReward { get; set; }
		[Ordinal(2)] [RED("streetCredReward")] public CInt32 StreetCredReward { get; set; }
		[Ordinal(3)] [RED("transgressions")] public CArray<CString> Transgressions { get; set; }
		[Ordinal(4)] [RED("hasAccess")] public CBool HasAccess { get; set; }
		[Ordinal(5)] [RED("level")] public CInt32 Level { get; set; }

		public BountyUI(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
