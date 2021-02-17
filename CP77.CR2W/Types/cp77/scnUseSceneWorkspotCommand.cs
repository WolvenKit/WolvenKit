using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnUseSceneWorkspotCommand : AIBaseUseWorkspotCommand
	{
		[Ordinal(11)] [RED("sceneInstanceId")] public scnSceneInstanceId SceneInstanceId { get; set; }
		[Ordinal(12)] [RED("workspotInstanceId")] public scnSceneWorkspotInstanceId WorkspotInstanceId { get; set; }
		[Ordinal(13)] [RED("itemOverride")] public workWorkspotItemOverride ItemOverride { get; set; }
		[Ordinal(14)] [RED("nodeId")] public scnNodeId NodeId { get; set; }

		public scnUseSceneWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
