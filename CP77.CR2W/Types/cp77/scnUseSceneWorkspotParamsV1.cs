using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnUseSceneWorkspotParamsV1 : questUseWorkspotParamsV1
	{
		[Ordinal(21)] [RED("workspotInstanceId")] public scnSceneWorkspotInstanceId WorkspotInstanceId { get; set; }
		[Ordinal(22)] [RED("playAtActorLocation")] public CBool PlayAtActorLocation { get; set; }
		[Ordinal(23)] [RED("itemOverride")] public workWorkspotItemOverride ItemOverride { get; set; }

		public scnUseSceneWorkspotParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
