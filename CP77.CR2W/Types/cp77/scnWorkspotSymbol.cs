using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotSymbol : CVariable
	{
		[Ordinal(0)] [RED("wsInstance")] public scnSceneWorkspotInstanceId WsInstance { get; set; }
		[Ordinal(1)] [RED("wsNodeId")] public scnNodeId WsNodeId { get; set; }
		[Ordinal(2)] [RED("wsEditorEventId")] public CUInt64 WsEditorEventId { get; set; }

		public scnWorkspotSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
