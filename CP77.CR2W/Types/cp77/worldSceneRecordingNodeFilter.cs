using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingNodeFilter : CVariable
	{
		[Ordinal(0)]  [RED("meshNodesOnly")] public CBool MeshNodesOnly { get; set; }
		[Ordinal(1)]  [RED("meshResourceFilter")] public worldSceneRecordingNodeMeshResourceFilter MeshResourceFilter { get; set; }
		[Ordinal(2)]  [RED("streamInNodesWithStreamingDistanceMoreThan")] public CFloat StreamInNodesWithStreamingDistanceMoreThan { get; set; }
		[Ordinal(3)]  [RED("streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan")] public CFloat StreamOutPrefabProxyMeshesWithStreamingDistanceMoreThan { get; set; }

		public worldSceneRecordingNodeFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
