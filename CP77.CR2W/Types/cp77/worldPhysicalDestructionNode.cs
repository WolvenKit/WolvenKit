using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalDestructionNode : worldNode
	{
		[Ordinal(0)]  [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(1)]  [RED("destructionLevelData")] public CArray<physicsDestructionLevelData> DestructionLevelData { get; set; }
		[Ordinal(2)]  [RED("destructionParams")] public physicsDestructionParams DestructionParams { get; set; }
		[Ordinal(3)]  [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
		[Ordinal(4)]  [RED("forceLODLevel")] public CInt32 ForceLODLevel { get; set; }
		[Ordinal(5)]  [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(6)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(7)]  [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(8)]  [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }

		public worldPhysicalDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
