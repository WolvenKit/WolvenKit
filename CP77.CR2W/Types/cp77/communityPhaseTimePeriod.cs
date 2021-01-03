using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class communityPhaseTimePeriod : communityTimePeriod
	{
		[Ordinal(0)]  [RED("categories")] public CArray<gameSpotSequenceCategory> Categories { get; set; }
		[Ordinal(1)]  [RED("isSequence")] public CBool IsSequence { get; set; }
		[Ordinal(2)]  [RED("markings")] public CArray<CName> Markings { get; set; }
		[Ordinal(3)]  [RED("quantity")] public CUInt16 Quantity { get; set; }
		[Ordinal(4)]  [RED("spotNodeRefs")] public CArray<NodeRef> SpotNodeRefs { get; set; }

		public communityPhaseTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
