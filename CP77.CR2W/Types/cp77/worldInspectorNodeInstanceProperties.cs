using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInspectorNodeInstanceProperties : ISerializable
	{
		[Ordinal(0)]  [RED("renderProxyAddressForDebug")] public CUInt64 RenderProxyAddressForDebug { get; set; }
		[Ordinal(1)]  [RED("setupInfo")] public worldCompiledNodeInstanceSetupInfo SetupInfo { get; set; }
		[Ordinal(2)]  [RED("meshNode")] public CHandle<worldMeshNode> MeshNode { get; set; }
		[Ordinal(3)]  [RED("instancedMeshNode")] public CHandle<worldInstancedMeshNode> InstancedMeshNode { get; set; }
		[Ordinal(4)]  [RED("lastObserverDistanceToStreamingPoint")] public CFloat LastObserverDistanceToStreamingPoint { get; set; }
		[Ordinal(5)]  [RED("lastObserverDistanceToSecondaryReferencePoint")] public CFloat LastObserverDistanceToSecondaryReferencePoint { get; set; }

		public worldInspectorNodeInstanceProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
