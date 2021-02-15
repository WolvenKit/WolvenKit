using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HighlightConnectionsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("shouldHighlight")] public CBool ShouldHighlight { get; set; }
		[Ordinal(1)] [RED("isTriggeredByMasterDevice")] public CBool IsTriggeredByMasterDevice { get; set; }
		[Ordinal(2)] [RED("highlightTargets")] public CArray<NodeRef> HighlightTargets { get; set; }
		[Ordinal(3)] [RED("requestingDevice")] public entEntityID RequestingDevice { get; set; }

		public HighlightConnectionsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
