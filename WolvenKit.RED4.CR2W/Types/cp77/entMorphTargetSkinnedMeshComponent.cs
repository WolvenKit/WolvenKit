using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetSkinnedMeshComponent : entISkinTargetComponent
	{
		[Ordinal(10)] [RED("morphResource")] public raRef<MorphTargetMesh> MorphResource { get; set; }
		[Ordinal(11)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(12)] [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(13)] [RED("HACK_isMaterialPriorityBumped")] public CBool HACK_isMaterialPriorityBumped { get; set; }
		[Ordinal(14)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(15)] [RED("acceptDismemberment")] public CBool AcceptDismemberment { get; set; }
		[Ordinal(16)] [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(17)] [RED("renderingPlaneAnimationParam")] public CName RenderingPlaneAnimationParam { get; set; }
		[Ordinal(18)] [RED("visibilityAnimationParam")] public CName VisibilityAnimationParam { get; set; }
		[Ordinal(19)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(20)] [RED("tags")] public redTagList Tags { get; set; }

		public entMorphTargetSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
