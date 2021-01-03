using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotSymbol : CVariable
	{
		[Ordinal(0)]  [RED("wsEditorEventId")] public CUInt64 WsEditorEventId { get; set; }
		[Ordinal(1)]  [RED("wsInstance")] public scnSceneWorkspotInstanceId WsInstance { get; set; }
		[Ordinal(2)]  [RED("wsNodeId")] public scnNodeId WsNodeId { get; set; }

		public scnWorkspotSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
