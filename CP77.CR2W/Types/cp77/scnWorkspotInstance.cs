using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotInstance : CVariable
	{
		[Ordinal(0)] [RED("workspotInstanceId")] public scnSceneWorkspotInstanceId WorkspotInstanceId { get; set; }
		[Ordinal(1)] [RED("dataId")] public scnSceneWorkspotDataId DataId { get; set; }
		[Ordinal(2)] [RED("localTransform")] public Transform LocalTransform { get; set; }
		[Ordinal(3)] [RED("playAtActorLocation")] public CBool PlayAtActorLocation { get; set; }
		[Ordinal(4)] [RED("originMarker")] public scnMarker OriginMarker { get; set; }

		public scnWorkspotInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
