using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAcousticZoneNode : worldNode
	{
		[Ordinal(4)] [RED("isBlocker")] public CBool IsBlocker { get; set; }
		[Ordinal(5)] [RED("tagName")] public CName TagName { get; set; }
		[Ordinal(6)] [RED("tagSpread")] public CFloat TagSpread { get; set; }

		public worldAcousticZoneNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
