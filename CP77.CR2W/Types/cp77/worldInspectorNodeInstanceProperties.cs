using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldInspectorNodeInstanceProperties : ISerializable
	{
		[Ordinal(0)]  [RED("instancedMeshNode")] public CHandle<worldInstancedMeshNode> InstancedMeshNode { get; set; }
		[Ordinal(1)]  [RED("lastObserverDistanceToSecondaryReferencePoint")] public CFloat LastObserverDistanceToSecondaryReferencePoint { get; set; }
		[Ordinal(2)]  [RED("lastObserverDistanceToStreamingPoint")] public CFloat LastObserverDistanceToStreamingPoint { get; set; }
		[Ordinal(3)]  [RED("meshNode")] public CHandle<worldMeshNode> MeshNode { get; set; }
		[Ordinal(4)]  [RED("renderProxyAddressForDebug")] public CUInt64 RenderProxyAddressForDebug { get; set; }
		[Ordinal(5)]  [RED("setupInfo")] public worldCompiledNodeInstanceSetupInfo SetupInfo { get; set; }

		public worldInspectorNodeInstanceProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
