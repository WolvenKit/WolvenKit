using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalDestructionNode : worldNode
	{
		[Ordinal(4)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(5)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(6)] [RED("forceLODLevel")] public CInt32 ForceLODLevel { get; set; }
		[Ordinal(7)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
		[Ordinal(8)] [RED("destructionParams")] public physicsDestructionParams DestructionParams { get; set; }
		[Ordinal(9)] [RED("destructionLevelData")] public CArray<physicsDestructionLevelData> DestructionLevelData { get; set; }
		[Ordinal(10)] [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(11)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(12)] [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }

		public worldPhysicalDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
