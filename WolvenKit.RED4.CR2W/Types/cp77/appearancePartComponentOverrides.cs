using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearancePartComponentOverrides : CVariable
	{
		[Ordinal(0)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(2)] [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(3)] [RED("useCustomTransform")] public CBool UseCustomTransform { get; set; }
		[Ordinal(4)] [RED("initialTransform")] public Transform InitialTransform { get; set; }
		[Ordinal(5)] [RED("visualScale")] public Vector3 VisualScale { get; set; }
		[Ordinal(6)] [RED("acceptDismemberment")] public CBool AcceptDismemberment { get; set; }

		public appearancePartComponentOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
