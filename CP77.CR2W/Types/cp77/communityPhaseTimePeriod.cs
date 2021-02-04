using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class communityPhaseTimePeriod : communityTimePeriod
	{
		[Ordinal(0)]  [RED("quantity")] public CUInt16 Quantity { get; set; }
		[Ordinal(1)]  [RED("markings")] public CArray<CName> Markings { get; set; }
		[Ordinal(2)]  [RED("spotNodeRefs")] public CArray<NodeRef> SpotNodeRefs { get; set; }
		[Ordinal(3)]  [RED("categories")] public CArray<gameSpotSequenceCategory> Categories { get; set; }
		[Ordinal(4)]  [RED("isSequence")] public CBool IsSequence { get; set; }

		public communityPhaseTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
