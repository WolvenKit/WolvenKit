using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotInstance : CVariable
	{
		[Ordinal(0)]  [RED("dataId")] public scnSceneWorkspotDataId DataId { get; set; }
		[Ordinal(1)]  [RED("localTransform")] public Transform LocalTransform { get; set; }
		[Ordinal(2)]  [RED("originMarker")] public scnMarker OriginMarker { get; set; }
		[Ordinal(3)]  [RED("playAtActorLocation")] public CBool PlayAtActorLocation { get; set; }
		[Ordinal(4)]  [RED("workspotInstanceId")] public scnSceneWorkspotInstanceId WorkspotInstanceId { get; set; }

		public scnWorkspotInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
