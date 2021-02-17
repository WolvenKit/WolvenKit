using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPrefabNode : worldNode
	{
		[Ordinal(2)] [RED("prefab")] public raRef<worldPrefab> Prefab { get; set; }
		[Ordinal(3)] [RED("instanceData")] public CHandle<worldPrefabInstanceData> InstanceData { get; set; }
		[Ordinal(4)] [RED("enabledVariants")] public CHandle<worldPrefabVariantsList> EnabledVariants { get; set; }
		[Ordinal(5)] [RED("canBeToggledInGame")] public CBool CanBeToggledInGame { get; set; }
		[Ordinal(6)] [RED("noCollision")] public CBool NoCollision { get; set; }
		[Ordinal(7)] [RED("enableRenderSceneLayerOverride")] public CBool EnableRenderSceneLayerOverride { get; set; }
		[Ordinal(8)] [RED("renderSceneLayerMask")] public CEnum<RenderSceneLayerMask> RenderSceneLayerMask { get; set; }
		[Ordinal(9)] [RED("ignoreMeshEmbeddedOccluders")] public CBool IgnoreMeshEmbeddedOccluders { get; set; }
		[Ordinal(10)] [RED("ignoreAllOccluders")] public CBool IgnoreAllOccluders { get; set; }
		[Ordinal(11)] [RED("occluderAutoHideDistanceScale")] public CUInt8 OccluderAutoHideDistanceScale { get; set; }
		[Ordinal(12)] [RED("proxyMeshOnly")] public CEnum<worldPrefabProxyMeshOnly> ProxyMeshOnly { get; set; }
		[Ordinal(13)] [RED("proxyScaleOverride")] public CBool ProxyScaleOverride { get; set; }
		[Ordinal(14)] [RED("proxyScale")] public Vector3 ProxyScale { get; set; }

		public worldPrefabNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
