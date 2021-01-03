using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetSkinnedMeshComponent : entISkinTargetComponent
	{
		[Ordinal(0)]  [RED("HACK_isMaterialPriorityBumped")] public CBool HACK_isMaterialPriorityBumped { get; set; }
		[Ordinal(1)]  [RED("acceptDismemberment")] public CBool AcceptDismemberment { get; set; }
		[Ordinal(2)]  [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(3)]  [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(4)]  [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(5)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(6)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(7)]  [RED("morphResource")] public raRef<MorphTargetMesh> MorphResource { get; set; }
		[Ordinal(8)]  [RED("renderingPlaneAnimationParam")] public CName RenderingPlaneAnimationParam { get; set; }
		[Ordinal(9)]  [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(10)]  [RED("visibilityAnimationParam")] public CName VisibilityAnimationParam { get; set; }

		public entMorphTargetSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
