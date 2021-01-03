using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HighlightConnectionsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("highlightTargets")] public CArray<NodeRef> HighlightTargets { get; set; }
		[Ordinal(1)]  [RED("isTriggeredByMasterDevice")] public CBool IsTriggeredByMasterDevice { get; set; }
		[Ordinal(2)]  [RED("requestingDevice")] public entEntityID RequestingDevice { get; set; }
		[Ordinal(3)]  [RED("shouldHighlight")] public CBool ShouldHighlight { get; set; }

		public HighlightConnectionsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
