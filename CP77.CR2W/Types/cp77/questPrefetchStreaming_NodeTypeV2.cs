using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPrefetchStreaming_NodeTypeV2 : questIWorldDataManagerNodeType
	{
		[Ordinal(0)]  [RED("prefetchPositionRef")] public NodeRef PrefetchPositionRef { get; set; }
		[Ordinal(1)]  [RED("useStreamingOcclusion")] public CBool UseStreamingOcclusion { get; set; }
		[Ordinal(2)]  [RED("maxDistance")] public CFloat MaxDistance { get; set; }

		public questPrefetchStreaming_NodeTypeV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
