using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingNodeFilter : CVariable
	{
		[Ordinal(0)]  [RED("streamInNodesWithStreamingDistanceMoreThan")] public CFloat StreamInNodesWithStreamingDistanceMoreThan { get; set; }
		[Ordinal(1)]  [RED("streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan")] public CFloat StreamOutPrefabProxyMeshesWithStreamingDistanceMoreThan { get; set; }
		[Ordinal(2)]  [RED("meshNodesOnly")] public CBool MeshNodesOnly { get; set; }
		[Ordinal(3)]  [RED("meshResourceFilter")] public worldSceneRecordingNodeMeshResourceFilter MeshResourceFilter { get; set; }

		public worldSceneRecordingNodeFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
