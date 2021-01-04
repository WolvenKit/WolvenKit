using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISpotUsageToken : CVariable
	{
		[Ordinal(0)]  [RED("spotUserId")] public entEntityID SpotUserId { get; set; }
		[Ordinal(1)]  [RED("usedSpotId")] public worldGlobalNodeID UsedSpotId { get; set; }

		public AISpotUsageToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
