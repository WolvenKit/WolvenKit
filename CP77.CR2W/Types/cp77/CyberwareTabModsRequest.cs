using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareTabModsRequest : redEvent
	{
		[Ordinal(0)] [RED("open")] public CBool Open { get; set; }
		[Ordinal(1)] [RED("wrapper")] public CHandle<CyberwareDisplayWrapper> Wrapper { get; set; }

		public CyberwareTabModsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
