using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnUseSceneWorkspotCommand : AIBaseUseWorkspotCommand
	{
		[Ordinal(0)]  [RED("itemOverride")] public workWorkspotItemOverride ItemOverride { get; set; }
		[Ordinal(1)]  [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(2)]  [RED("sceneInstanceId")] public scnSceneInstanceId SceneInstanceId { get; set; }
		[Ordinal(3)]  [RED("workspotInstanceId")] public scnSceneWorkspotInstanceId WorkspotInstanceId { get; set; }

		public scnUseSceneWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
